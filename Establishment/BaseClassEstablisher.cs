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

        /// <summary>
        /// Initializes a new instance of <see cref="BaseClassEstablisher"/>
        /// </summary>
        /// <param name="baseline">The default value to load into this instance. Used for comparison tests</param>
        public BaseClassEstablisher(TType baseline) : base(baseline) {
            
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is <c>null</c>
        /// </summary>
        /// <returns><c>true</c> if <paramref name="value"/> is null; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsNull() {
            if (Value != null) {
                HandleFailure(new ArgumentException(GenericType.Name + " value must be null"));
            }

            return this;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not <c>null</c>
        /// </summary>
        /// <returns><c>true</c> if <paramref name="value"/> is not null; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsNotNull() {
            if (Value == null) {
                HandleFailure(new ArgumentException(GenericType.Name + " value cannot be null"));
            }

            return this;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> equals <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsEqual(TType constraint) {
            if (!DefaultComparer.Equals(Value, constraint)) {
                HandleFailure(new ArgumentException(GenericType.Name + " value must equal constraint"));
            }

            return this;
        }

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> does not equal <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        public virtual BaseClassEstablisher<TType> IsNotEqual(TType constraint) {
            if (DefaultComparer.Equals(Value, constraint)) {
                HandleFailure(new ArgumentNullException(GenericType.Name + "value must not equal constraint"));
            }

            return this;
        }

    }

}
