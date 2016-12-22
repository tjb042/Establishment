using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class UShortEstablisher : BaseEstablisher<ushort>, IStructEstablisher<UShortEstablisher, ushort> {

        internal UShortEstablisher(ushort value) : base(value) {
            
        }

        public UShortEstablisher IsGreaterThan(ushort threshold) {
            if (Value <= threshold) {
                HandleFailure("ushort value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public UShortEstablisher IsGreaterThanOrEqualTo(ushort threshold) {
            if (Value < threshold) {
                HandleFailure("ushort value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public UShortEstablisher IsLessThan(ushort threshold) {
            if (Value >= threshold) {
                HandleFailure("ushort value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public UShortEstablisher IsLessThanOrEqualTo(ushort threshold) {
            if (Value > threshold) {
                HandleFailure("ushort value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public UShortEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        public UShortEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        public UShortEstablisher IsMinValue() {
            if (Value != ushort.MinValue) {
                HandleFailure("value must equal ushort.MinValue");
            }

            return this;
        }

        public UShortEstablisher IsNotMinValue() {
            if (Value == ushort.MinValue) {
                HandleFailure("value must not equal ushort.MinValue");
            }

            return this;
        }

        public UShortEstablisher IsMaxValue() {
            if (Value != ushort.MaxValue) {
                HandleFailure("value must equal ushort.MaxValue");
            }

            return this;
        }

        public UShortEstablisher IsNotMaxValue() {
            if (Value == ushort.MaxValue) {
                HandleFailure("value must not equal ushort.MaxValue");
            }

            return this;
        }

        public UShortEstablisher IsDefault() {
            return base.IsDefault<UShortEstablisher>();
        }

        public UShortEstablisher IsNotDefault() {
            return base.IsNotDefault<UShortEstablisher>();
        }

        public UShortEstablisher IsEqualTo(ushort constraint) {
            return base.IsEqualTo<UShortEstablisher>(constraint);
        }

        public UShortEstablisher IsNotEqualTo(ushort constraint) {
            return base.IsNotEqualTo<UShortEstablisher>(constraint);
        }

    }

}
