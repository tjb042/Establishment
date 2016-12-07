using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class GuidEstablisher : BaseStructEstablisher<Guid> {

        public override bool IsDefault(Guid value) {
            if (value != Guid.Empty) {
                return HandleFailure(new ArgumentException("guid must be empty"));
            }

            return true;
        }

        public override bool IsNotDefault(Guid value) {
            if (value == Guid.Empty) {
                return HandleFailure(new ArgumentException("guid must not be empty"));
            }

            return true;
        }

    }

}
