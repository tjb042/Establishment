using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ObjectEstablisher : BaseEstablisher<object> {

        internal ObjectEstablisher(object value) : base(value) { }

        public ObjectEstablisher IsDBNull() {
            return base.IsDBNull<ObjectEstablisher>();
        }

        public ObjectEstablisher IsNotDBNull() {
            return base.IsNotDBNull<ObjectEstablisher>();
        }

        public ObjectEstablisher IsDefault() {
            return IsDefault<ObjectEstablisher>();
        }

        public ObjectEstablisher IsNotDefault() {
            return IsNotDefault<ObjectEstablisher>();
        }

    }

}
