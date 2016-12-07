using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class BooleanEstablisher : BaseStructEstablisher<bool> {

        public bool IsTrue(bool value) {
            if (!value) {
                return HandleFailure(new ArgumentException("bool value must be true"));
            }

            return true;
        }

        public bool IsFalse(bool value) {
            if (value) {
                return HandleFailure(new ArgumentException("bool value must be false"));
            }

            return true;
        }

    }

}
