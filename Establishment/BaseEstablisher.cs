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
        internal BaseEstablisher(TType value) {
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
        protected TType DefaultTypeValue {
            get;
            private set;
        }

        /// <summary>
        /// The runtime type of <paramref name="TType"/>
        /// </summary>
        protected Type GenericType {
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
        protected IEqualityComparer<TType> DefaultComparer {
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
        protected virtual void HandleException(string message) {
            HandleException(message, null);
        }

        /// <summary>
        /// Base error handler that throws or catches exceptions based on <see cref="ThrowExceptionOnFailure"/>
        /// </summary>
        /// <param name="message">The message used in the generated exception</param>
        /// <param name="innerException">The inner exception capture during validation</param>
        protected virtual void HandleException(string message, Exception innerException) {
            Exception ex;
            if (string.IsNullOrEmpty(Options.ParameterName)) {
                ex = new ArgumentException(message, innerException);
            }
            else {
                ex = new ArgumentException(message, Options.ParameterName, innerException);
            }

            HasExceptions = true;
            LastException = ex;

            if (Options.ThrowExceptionOnFailure.GetValueOrDefault(Establish.ThrowExceptionOnFailure)) {
                throw ex;
            }
        }

        protected TEstablisher IsDefault<TEstablisher>() where TEstablisher : BaseEstablisher<TType> {
            if (!DefaultComparer.Equals(Value, DefaultTypeValue)) {
                HandleException(GenericType.Name + " must equal its default value");
            }

            return this as TEstablisher;
        }

        protected TEstablisher IsNotDefault<TEstablisher>() where TEstablisher : BaseEstablisher<TType> {
            if (DefaultComparer.Equals(Value, DefaultTypeValue)) {
                HandleException(GenericType.Name + " must not equal its default value");
            }

            return this as TEstablisher;
        }

        protected TEstablisher IsDBNull<TEstablisher>() where TEstablisher : BaseEstablisher<TType> {
            if (!Convert.IsDBNull(Value)) {
                HandleException(GenericType.Name + " must equal DBNull.Value");
            }

            return this as TEstablisher;
        }

        protected TEstablisher IsNotDBNull<TEstablisher>() where TEstablisher : BaseEstablisher<TType> {
            if (Convert.IsDBNull(Value)) {
                HandleException(GenericType.Name + " must not equal DBNull.Value");
            }

            return this as TEstablisher;
        }

        protected TEstablisher IsEqualTo<TEstablisher>(TType constraint) where TEstablisher : BaseEstablisher<TType> {
            if (!DefaultComparer.Equals(Value, constraint)) {
                HandleException(GenericType.Name + " is not equal to a required constraint");
            }

            return this as TEstablisher;
        }

        protected TEstablisher IsNotEqualTo<TEstablisher>(TType constraint) where TEstablisher : BaseEstablisher<TType> {
            if (DefaultComparer.Equals(Value, constraint)) {
                HandleException(GenericType.Name + " must not equal a blacklist constraint");
            }

            return this as TEstablisher;
        }

        protected TEstablisher Satisfies<TEstablisher>(Action<TType> action) where TEstablisher : BaseEstablisher<TType> {
            try {
                action(Value);
            }
            catch (Exception ex) {
                HandleException("bool value does not satisfy user action", ex);
            }

            return this as TEstablisher;
        }

        protected TEstablisher Satisfies<TEstablisher>(Func<TType, bool> predicate) where TEstablisher : BaseEstablisher<TType> {
            try {
                if (!predicate(Value)) {
                    // failure
                    HandleException("bool value does not satisfy user action");
                }
            }
            catch (Exception ex) {
                // failure
                HandleException("bool value does not satisfy user action", ex);
            }

            return this as TEstablisher;
        }

    }

}
