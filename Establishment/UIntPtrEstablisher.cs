using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public static class UIntPtrEstablisher {

        public static StructEstablisher<UIntPtr> IsZero(this StructEstablisher<UIntPtr> establisher) {
            if (establisher.Value != UIntPtr.Zero) {
                establisher.RaiseException("UIntPtr must be equal to zero");
            }

            return establisher;
        }

        public static StructEstablisher<UIntPtr> IsNotZero(this StructEstablisher<UIntPtr> establisher) {
            if (establisher.Value == UIntPtr.Zero) {
                establisher.RaiseException("UIntPtr must not be equal to zero");
            }

            return establisher;
        }

    }
}
