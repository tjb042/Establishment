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

        protected string _typeName = typeof(TType).Name;

        public virtual bool IsNull(TType value) {
            if (value != null) {
                return HandleFailure(new ArgumentException(_typeName + " value must be null"));
            }

            return true;
        }

        public virtual bool IsNotNull(TType value) {
            if (value == null) {
                return HandleFailure(new ArgumentException(_typeName + " value cannot be null"));
            }

            return true;
        }

    }

}
