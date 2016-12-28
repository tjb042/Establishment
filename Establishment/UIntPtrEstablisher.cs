using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class UIntPtrEstablisher : BaseEstablisher<UIntPtr>, IStructEstablisher<UIntPtrEstablisher, UIntPtr> {

        internal UIntPtrEstablisher(UIntPtr value) : base(value) { }

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

        public UIntPtrEstablisher IsDefault() {
            return base.IsDefault<UIntPtrEstablisher>();
        }

        public UIntPtrEstablisher IsNotDefault() {
            return base.IsNotDefault<UIntPtrEstablisher>();
        }

        public UIntPtrEstablisher IsEqualTo(UIntPtr constraint) {
            return base.IsEqualTo<UIntPtrEstablisher>(constraint);
        }

        public UIntPtrEstablisher IsNotEqualTo(UIntPtr constraint) {
            return base.IsNotEqualTo<UIntPtrEstablisher>(constraint);
        }
    }
}
