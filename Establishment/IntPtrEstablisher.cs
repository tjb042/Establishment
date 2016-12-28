using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class IntPtrEstablisher : BaseEstablisher<IntPtr>, IStructEstablisher<IntPtrEstablisher, IntPtr> {

        internal IntPtrEstablisher(IntPtr value) : base(value) { }

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

        public IntPtrEstablisher IsDefault() {
            return base.IsDefault<IntPtrEstablisher>();
        }

        public IntPtrEstablisher IsNotDefault() {
            return base.IsNotDefault<IntPtrEstablisher>();
        }

        public IntPtrEstablisher IsEqualTo(IntPtr constraint) {
            return base.IsEqualTo<IntPtrEstablisher>(constraint);
        }

        public IntPtrEstablisher IsNotEqualTo(IntPtr constraint) {
            return base.IsNotEqualTo<IntPtrEstablisher>(constraint);
        }

        public IntPtrEstablisher Satisfies(Action<IntPtr> action) {
            return base.Satisfies<IntPtrEstablisher>(action);
        }

        public IntPtrEstablisher Satisfies(Func<IntPtr, bool> predicate) {
            return base.Satisfies<IntPtrEstablisher>(predicate);
        }

    }

}
