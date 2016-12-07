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

        protected TType _defaultTType = default(TType);
        protected string _typeName = typeof(TType).Name;

        public virtual bool IsDefault(TType value) {
            if (!_defaultTType.Equals(value)) {
                return HandleFailure(new ArgumentException(_typeName + " value must be default"));
            }

            return true;
        }

        public virtual bool IsNotDefault(TType value) {
            if (_defaultTType.Equals(value)) {
                return HandleFailure(new ArgumentException(_typeName + " value must not be default"));
            }

            return true;
        }
    }

}
