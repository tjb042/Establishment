using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class IntPtrEstablisher : StructEstablisher<IntPtrEstablisher, IntPtr> {

        public IntPtrEstablisher(IntPtr value) : base(value) { }

        public IntPtrEstablisher IsZero() {
            if (Value != IntPtr.Zero) {
                HandleException("IntPtr must be equal to zero");
            }

            return this;
        }

        public IntPtrEstablisher IsNotZero() {
            if (Value == IntPtr.Zero) {
                HandleException("IntPtr must not be equal to zero");
            }

            return this;
        }

    }

}
