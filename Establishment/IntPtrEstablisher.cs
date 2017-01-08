using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class IntPtrEstablisher {

        public static StructEstablisher<IntPtr> IsZero(this StructEstablisher<IntPtr> establisher) {
            if (establisher.Value != IntPtr.Zero) {
                establisher.RaiseException("IntPtr must be equal to zero");
            }

            return establisher;
        }

        public static StructEstablisher<IntPtr> IsNotZero(this StructEstablisher<IntPtr> establisher) {
            if (establisher.Value == IntPtr.Zero) {
                establisher.RaiseException("IntPtr must not be equal to zero");
            }

            return establisher;
        }

    }

}
