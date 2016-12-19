using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    /// <summary>
    /// Base establishment provider for reference types
    /// </summary>
    /// <typeparam name="TType">A reference type</typeparam>
    public class BaseClassEstablisher<TType> : BaseEstablisher<TType> where TType : class {

        protected readonly Type _type;
        protected readonly string _typeName;
        protected readonly IEqualityComparer<TType> _defaultComparer;

        /// <summary>
        /// Initializes a new instance of <see cref="BaseClassEstablisher"/>
        /// </summary>
        public BaseClassEstablisher(TType baseline) : base(baseline) {
            _type = typeof(TType);
            _typeName = _type.Name;
            _defaultComparer = EqualityComparer<TType>.Default;
        }

        public bool ThrowExceptionOnFailure { get; set; }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is <c>null</c>
        /// </summary>
        /// <param name="value">The value to evaluate</param>
        /// <returns><c>true</c> if <paramref name="value"/> is null; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsNull(TType value) {
            if (value != null) {
                HandleFailure(new ArgumentException(_typeName + " value must be null"));
            }

            return this;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not <c>null</c>
        /// </summary>
        /// <param name="value">The value to evaluate</param>
        /// <returns><c>true</c> if <paramref name="value"/> is not null; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsNotNull(TType value) {
            if (value == null) {
                HandleFailure(new ArgumentException(_typeName + " value cannot be null"));
            }

            return this;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="value">The inital value to compare</param>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> equals <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsEqual(TType value, TType constraint) {
            if (!_defaultComparer.Equals(value, constraint)) {
                HandleFailure(new ArgumentException(_typeName + " value must equal constraint"));
            }

            return this;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="value">The inital value to compare</param>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> does not equal <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsNotEqual(TType value, TType constraint) {
            if (_defaultComparer.Equals(value, constraint)) {
                HandleFailure(new ArgumentNullException(_typeName + "value must not equal constraint"));
            }

            return this;
        }

    }

}
