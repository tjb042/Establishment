using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class IntPtrEstablisher {

        public static BaseEstablisher<IntPtr> IsZero(this BaseEstablisher<IntPtr> establisher) {
            if (establisher.Value != IntPtr.Zero) {
                establisher.RaiseException("IntPtr must be equal to zero");
            }

            return establisher;
        }

        public static BaseEstablisher<IntPtr> IsNotZero(this BaseEstablisher<IntPtr> establisher) {
            if (establisher.Value == IntPtr.Zero) {
                establisher.RaiseException("IntPtr must not be equal to zero");
            }

            return establisher;
        }

    }

}
