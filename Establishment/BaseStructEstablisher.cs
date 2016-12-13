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
    public class BaseStructEstablisher<TType> : BaseEstablisher where TType : struct {

        protected readonly TType _defaultTType;
        protected readonly Type _type;
        protected readonly string _typeName;
        protected readonly IEqualityComparer<TType> _defaultComparer;

        public BaseStructEstablisher() {
            _defaultTType = default(TType);
            _type = typeof(TType);
            _typeName = _type.Name;
            _defaultComparer = EqualityComparer<TType>.Default;
        }

        public virtual bool IsDefault(TType value) {
            if (!_defaultComparer.Equals(value, _defaultTType)) {
                return HandleFailure(new ArgumentException(_typeName + " value must be default"));
            }

            return true;
        }

        public virtual bool IsNotDefault(TType value) {
            if (_defaultComparer.Equals(value, _defaultTType)) {
                return HandleFailure(new ArgumentException(_typeName + " value must not be default"));
            }

            return true;
        }

        public virtual bool IsEqual(TType value, TType constraint) {
            if (!_defaultComparer.Equals(value, constraint)) {
                return HandleFailure(new ArgumentException(_typeName + " value must equal constraint"));
            }

            return true;
        }

        public virtual bool IsNotEqual(TType value, TType constraint) {
            if (_defaultComparer.Equals(value, constraint)) {
                return HandleFailure(new ArgumentException(_typeName + " value must nto equal constraint"));
            }

            return true;
        }

    }

}
