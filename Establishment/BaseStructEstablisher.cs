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

        protected readonly TType _defaultTType;
        protected readonly Type _type;
        protected readonly string _typeName;
        protected readonly IEqualityComparer<TType> _defaultComparer;

        public BaseStructEstablisher(TType baseline) : base(baseline) {
            _defaultTType = default(TType);
            _type = typeof(TType);
            _typeName = _type.Name;
            _defaultComparer = EqualityComparer<TType>.Default;
        }

        public virtual BaseStructEstablisher<TType> IsDefault() {
            if (!_defaultComparer.Equals(Value, _defaultTType)) {
                HandleFailure(new ArgumentException(_typeName + " value must be default"));
            }

            return this;
        }

        public virtual BaseStructEstablisher<TType> IsNotDefault() {
            if (_defaultComparer.Equals(Value, _defaultTType)) {
                HandleFailure(new ArgumentException(_typeName + " value must not be default"));
            }

            return this;
        }

        public virtual BaseStructEstablisher<TType> IsEqual(TType constraint) {
            if (!_defaultComparer.Equals(Value, constraint)) {
                HandleFailure(new ArgumentException(_typeName + " value must equal constraint"));
            }

            return this;
        }

        public virtual BaseStructEstablisher<TType> IsNotEqual(TType constraint) {
            if (_defaultComparer.Equals(Value, constraint)) {
                HandleFailure(new ArgumentException(_typeName + " value must nto equal constraint"));
            }

            return this;
        }

    }

}
