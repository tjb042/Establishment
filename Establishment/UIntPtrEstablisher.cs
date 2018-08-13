using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public static class UIntPtrEstablisher {

        public static BaseEstablisher<UIntPtr> IsZero(this BaseEstablisher<UIntPtr> establisher) {
            if (establisher.Value != UIntPtr.Zero) {
                establisher.RaiseException("UIntPtr must be equal to zero");
            }

            return establisher;
        }

        public static BaseEstablisher<UIntPtr> IsNotZero(this BaseEstablisher<UIntPtr> establisher) {
            if (establisher.Value == UIntPtr.Zero) {
                establisher.RaiseException("UIntPtr must not be equal to zero");
            }

            return establisher;
        }

    }
}
