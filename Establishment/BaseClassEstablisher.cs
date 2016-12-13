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
    public class BaseClassEstablisher<TType> : BaseEstablisher where TType : class {

        protected readonly Type _type;
        protected readonly string _typeName;

        /// <summary>
        /// Initializes a new instance of <see cref="BaseClassEstablisher<TType>"/>
        /// </summary>
        public BaseClassEstablisher() {
            _type = typeof(TType);
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is <c>null</c>
        /// </summary>
        /// <param name="value">The value to evaluate</param>
        /// <returns><c>true</c> if <paramref name="value"/> is null; otherwise, <c>false</c></returns>
        public virtual bool IsNull(TType value) {
            if (value != null) {
                return HandleFailure(new ArgumentException(_typeName + " value must be null"));
            }

            return true;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not <c>null</c>
        /// </summary>
        /// <param name="value">The value to evaluate</param>
        /// <returns><c>true</c> if <paramref name="value"/> is not null; otherwise, <c>false</c></returns>
        public virtual bool IsNotNull(TType value) {
            if (value == null) {
                return HandleFailure(new ArgumentException(_typeName + " value cannot be null"));
            }

            return true;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="value">The inital value to compare</param>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> equals <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        public virtual bool IsEqual(TType value, TType constraint) {
            if (value != constraint) {
                return HandleFailure(new ArgumentException(_typeName + " value must equal constraint"));
            }
            
            return true;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="value">The inital value to compare</param>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> does not equal <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        public virtual bool IsNotEqual(TType value, TType constraint) {
            if (value == constraint) {
                return HandleFailure(new ArgumentNullException(_typeName + "value must not equal constraint"));
            }

            return true;
        }

    }

}
