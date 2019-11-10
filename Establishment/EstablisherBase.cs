using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Establishment
{
    
    public class EstablisherBase<T>
    {

        private List<Exception> aggregatedExceptions;

        public EstablisherBase(T value)
        {
            Value = value;
            TDefault = default(T);
            TType = typeof(T);
            ParameterName = $"{TType.Name} instance";

            aggregatedExceptions = new List<Exception>();
        }

        public EstablisherBase(T value, string paramName) : this(value)
        {
            ParameterName = paramName;
        }

        public T Value { get; }

        public T TDefault { get; }

        public Type TType { get; }

        public IEqualityComparer<T> DefaultComparer { get; }

        public string ParameterName { get; }

        public bool ThrowExceptionOnFailure { get; set; }

        public bool HasExceptions => aggregatedExceptions.Any();

        public IEnumerable<Exception> Exceptions => aggregatedExceptions.AsReadOnly();

        public void RaiseException(Exception exception)
        {
            aggregatedExceptions.Add(exception);
            
            if (ThrowExceptionOnFailure)
            {
                throw exception;
            }
        }

        public void RaiseArgumentException(string message)
        {
            var exception = new ArgumentException(message, ParameterName);

            RaiseException(exception);
        }

        public void RaiseArgumentException(string message, Exception innerException)
        {
            var exception = new ArgumentException(message, ParameterName, innerException);

            RaiseException(exception);
        }

        public EstablisherBase<T> IsEqualTo(T constraint)
        {
            if (!DefaultComparer.Equals(Value, constraint))
            {
                RaiseArgumentException($"{ParameterName} must equal {TType.Name} constraint.");
            }

            return this;
        }

        public EstablisherBase<T> IsNotEqualTo(T constraint)
        {
            if (DefaultComparer.Equals(Value, constraint))
            {
                RaiseArgumentException($"{ParameterName} must not equal {TType.Name} constraint.");
            }

            return this;
        }

        public EstablisherBase<T> Satisfies(Func<T, bool> predicate)
        {
            Establish.For(predicate).IsNotNull();

            try
            {
                var isSuccess = predicate(Value);
                if (!isSuccess)
                {
                    // failure
                    RaiseArgumentException($"{ParameterName} failed to satisfy a predicate condition.");
                }
            }
            catch (Exception ex)
            {
                RaiseArgumentException($"{ParameterName} threw an exception while attempting to satisfy a predicate condition. See inner exception for more details.", ex);
            }

            return this;
        }

        public EstablisherBase<T> Property<T1>(Func<T, T1> selector, Action<EstablisherBase<T1>> action)
        {
            var paramName = $"{typeof(T1).Name} instance";

            return Property<T1>(selector, paramName, action);
        }

        public EstablisherBase<T> Property<T1>(Func<T, T1> selector, string paramName, Action<EstablisherBase<T1>> action)
        {
            try
            {
                var childValue = selector(Value);
                var childEstablisher = Establish.For(childValue, paramName).ThrowExceptions(this.ThrowExceptionOnFailure);

                action(childEstablisher);
            }
            catch (Exception ex)
            {
                RaiseArgumentException($"{ParameterName} threw an exception while attempting to perform validation on a child object. See inner exception for details.", ex);
            }

            return this;
        }

        public EstablisherBase<T> ThrowExceptions(bool throwExceptions)
        {
            ThrowExceptionOnFailure = throwExceptions;

            return this;
        }

    }

}
