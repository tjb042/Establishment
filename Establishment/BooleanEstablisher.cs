using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class BooleanEstablisher : BaseEstablisher<bool>, IStructEstablisher<BooleanEstablisher, bool> {

        internal BooleanEstablisher(bool value) : base(value) { }

        public BooleanEstablisher IsTrue() {
            if (!Value) {
                HandleFailure("bool value must be true");
            }

            return this;
        }

        public BooleanEstablisher IsFalse() {
            if (Value) {
                HandleFailure("bool value must be false");
            }

            return this;
        }

        public BooleanEstablisher IsDefault() {
            return base.IsDefault<BooleanEstablisher>();
        }

        public BooleanEstablisher IsNotDefault() {
            return base.IsNotDefault<BooleanEstablisher>();
        }

        public BooleanEstablisher IsEqualTo(bool constraint) {
            return base.IsEqualTo<BooleanEstablisher>(constraint);
        }

        public BooleanEstablisher IsNotEqualTo(bool constraint) {
            return base.IsNotEqualTo<BooleanEstablisher>(constraint);
        }

    }

}
