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
    public abstract class BaseEstablisher<TType> {

        private string _parameterName = null;

        /// <summary>
        /// Initializes a new instance of <see cref="BaseEstablisher"/>
        /// </summary>
        /// <param name="value">An instance of <paramref name="TType"/> used for tests</param>
        protected BaseEstablisher(TType value) {
            Value = value;
            ThrowExceptionOnFailure = true;
            GenericType = typeof(TType);
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
        /// The runtime type of <paramref name="TType"/>
        /// </summary>
        protected Type GenericType {
            get;
            private set;
        }

        /// <summary>
        /// If provided, the name of the parameter wrapped by this instance.
        /// </summary>
        public string ParameterName {
            get {
                return this._parameterName;
            }
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    this._parameterName = null;
                }
                else {
                    this._parameterName = value.Trim();
                }
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
        /// Indicates if a test should throw an exception is a value does not meet the supplied criteria, or fail silently
        /// </summary>
        public bool ThrowExceptionOnFailure { 
            get; 
            set; 
        }

        /// <summary>
        /// Base error handler that throws or catches exceptions based on <see cref="ThrowExceptionOnFailure"/>
        /// </summary>
        /// <param name="ex"></param>
        protected virtual void HandleFailure(string message) {
            Exception ex;
            if (string.IsNullOrEmpty(ParameterName)) {
                ex = new ArgumentException(message);
            }
            else {
                ex = new ArgumentException(message, ParameterName);
            }

            HasExceptions = true;
            LastException = ex;

            if (ThrowExceptionOnFailure) {
                throw ex;
            }
        }

    }

}
