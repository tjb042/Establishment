using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class BooleanEstablisher : BaseStructEstablisher<bool> {

        internal BooleanEstablisher(bool value) : base(value) { }

        public BooleanEstablisher IsTrue(bool value) {
            if (!Value) {
                HandleFailure(new ArgumentException("bool value must be true"));
            }

            return this;
        }

        public BooleanEstablisher IsFalse(bool value) {
            if (Value) {
                HandleFailure(new ArgumentException("bool value must be false"));
            }

            return this;
        }

    }

}
