using Establishment.Exceptions;
using Establishment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    /// <summary>
    /// Base establishment provider for all types
    /// </summary>
    /// <typeparam name="TType">Any generic struct or class type</typeparam>
    public class BaseEstablisher<TType> {

        private EstablisherOptions _establisherOptions = null;

        /// <summary>
        /// Initializes a new instance of <see cref="BaseEstablisher"/>
        /// </summary>
        /// <param name="value">An instance of <paramref name="TType"/> used for tests</param>
        public BaseEstablisher(TType value) {
            Value = value;
            GenericType = typeof(TType);
            DefaultTypeValue = default(TType);

            DefaultComparer = EqualityComparer<TType>.Default;
        }

        /// <summary>
        /// The <paramref name="TType"/> value provided to this establisher
        /// </summary>
        public TType Value {
            get;
            protected set;
        }

        /// <summary>
        /// The default value for TType (via default(Type))
        /// </summary>
        internal TType DefaultTypeValue {
            get;
            private set;
        }

        /// <summary>
        /// The runtime type of <paramref name="TType"/>
        /// </summary>
        public Type GenericType {
            get;
            private set;
        }

        public EstablisherOptions Options {
            get {
                if (_establisherOptions == null) {
                    _establisherOptions = new EstablisherOptions() {
                        ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
                    };
                }

                return _establisherOptions;
            }
            internal set {
                _establisherOptions = value;
            }
        }

        /// <summary>
        /// The default .NET comparer for <paramref name="TType"/>
        /// </summary>
        internal IEqualityComparer<TType> DefaultComparer {
            get;
            private set;
        }

        /// <summary>
        /// Indicates if any exceptions have been thrown during test methods
        /// </summary>
        public bool HasExceptions {
            get;
            protected set;
        }

        /// <summary>
        /// The last excpetion thrown
        /// </summary>
        public Exception LastException {
            get;
            protected set;
        }

        /// <summary>
        /// Base error handler that throws or catches exceptions based on <see cref="ThrowExceptionOnFailure"/>
        /// </summary>
        /// <param name="message">The message used in the generated exception</param>
        public virtual void RaiseException(string message) {
            RaiseException(message, null);
        }

        /// <summary>
        /// Base error handler that throws or catches exceptions based on <see cref="ThrowExceptionOnFailure"/>
        /// </summary>
        /// <param name="message">The message used in the generated exception</param>
        /// <param name="innerException">The inner exception capture during validation</param>
        public virtual void RaiseException(string message, Exception innerException) {
            Exception ex;
            if (string.IsNullOrEmpty(Options.ParameterName)) {
                ex = new EstablishmentException(message, innerException);
            }
            else {
                ex = new EstablishmentException(message, Options.ParameterName, innerException);
            }

            HasExceptions = true;
            LastException = ex;

            if (Options.ThrowExceptionOnFailure.GetValueOrDefault(Establish.ThrowExceptionOnFailure)) {
                throw ex;
            }
        }

        public BaseEstablisher<TType> IsDBNull()
        {
            if (!Convert.IsDBNull(Value))
            {
                RaiseException(GenericType.Name + " must equal DBNull.Value");
            }

            return this;
        }

        public BaseEstablisher<TType> IsNotDBNull()
        {
            if (Convert.IsDBNull(Value))
            {
                RaiseException(GenericType.Name + " must not equal DBNull.Value");
            }

            return this;
        }

        public BaseEstablisher<TType> IsEqualTo(TType constraint)
        {
            if (!DefaultComparer.Equals(Value, constraint))
            {
                RaiseException(GenericType.Name + " is not equal to a required constraint");
            }

            return this;
        }

        public BaseEstablisher<TType> IsNotEqualTo(TType constraint)
        {
            if (DefaultComparer.Equals(Value, constraint))
            {
                RaiseException(GenericType.Name + " must not equal a blacklist constraint");
            }

            return this;
        }

        public BaseEstablisher<TType> Satisfies(Action<TType> action)
        {
            Establish.For(action).IsNotNull();

            try
            {
                action(Value);
            }
            catch (Exception ex)
            {
                RaiseException("bool value does not satisfy user action", ex);
            }

            return this;
        }

        public BaseEstablisher<TType> Satisfies(Func<TType, bool> predicate)
        {
            Establish.For(predicate).IsNotNull();

            try
            {
                if (!predicate(Value))
                {
                    // failure
                    RaiseException("bool value does not satisfy user action");
                }
            }
            catch (Exception ex)
            {
                // failure
                RaiseException("bool value does not satisfy user action", ex);
            }

            return this;
        }

        public BaseEstablisher<TType> ThrowExceptionOnFailure(bool throwException)
        {
            Options.ThrowExceptionOnFailure = throwException;

            return this;
        }

    }

}
