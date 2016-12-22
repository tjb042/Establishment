using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    /// <summary>
    /// Base establishment provider for value types
    /// </summary>
    /// <typeparam name="TType">A value type</typeparam>
    public class BaseStructEstablisher<TType> : BaseEstablisher<TType> where TType : struct {

        public BaseStructEstablisher(TType baseline) : base(baseline) {
            DefaultTType = default(TType);
        }

        protected TType DefaultTType {
            get;
            private set;
        }

        public virtual BaseStructEstablisher<TType> IsDefault() {
            if (!DefaultComparer.Equals(Value, DefaultTType)) {
                HandleFailure(GenericType.Name + " value must be default");
            }

            return this;
        }

        public virtual BaseStructEstablisher<TType> IsNotDefault() {
            if (DefaultComparer.Equals(Value, DefaultTType)) {
                HandleFailure(GenericType.Name + " value must not be default");
            }

            return this;
        }

        public virtual BaseStructEstablisher<TType> IsEqualTo(TType constraint) {
            if (!DefaultComparer.Equals(Value, constraint)) {
                HandleFailure(GenericType.Name + " value must equal constraint");
            }

            return this;
        }

        public virtual BaseStructEstablisher<TType> IsNotEqualTo(TType constraint) {
            if (DefaultComparer.Equals(Value, constraint)) {
                HandleFailure(GenericType.Name + " value must nto equal constraint");
            }

            return this;
        }

    }

}
