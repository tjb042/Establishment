using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class UIntPtrEstablisher : StructEstablisher<UIntPtrEstablisher, UIntPtr> {

        public UIntPtrEstablisher(UIntPtr value) : base(value) { }

        public UIntPtrEstablisher IsZero() {
            if (Value != UIntPtr.Zero) {
                HandleException("UIntPtr must be equal to zero");
            }

            return this;
        }

        public UIntPtrEstablisher IsNotZero() {
            if (Value == UIntPtr.Zero) {
                HandleException("UIntPtr must not be equal to zero");
            }

            return this;
        }

    }
}
