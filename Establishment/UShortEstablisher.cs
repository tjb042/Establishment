using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class UShortEstablisher : BaseStructEstablisher<ushort> {

        internal UShortEstablisher(ushort value) : base(value) {
            
        }

        public UShortEstablisher IsGreaterThan(ushort threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("ushort value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UShortEstablisher IsGreaterThanOrEqualTo(ushort threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("ushort value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UShortEstablisher IsLessThan(ushort threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("ushort value must be less than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UShortEstablisher IsLessThanOrEqualTo(ushort threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("ushort value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UShortEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public UShortEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public UShortEstablisher IsMinValue() {
            if (Value != ushort.MinValue) {
                HandleFailure(new ArgumentException("value must equal ushort.MinValue"));
            }

            return this;
        }

        public UShortEstablisher IsNotMinValue() {
            if (Value == ushort.MinValue) {
                HandleFailure(new ArgumentException("value must not equal ushort.MinValue"));
            }

            return this;
        }

        public UShortEstablisher IsMaxValue() {
            if (Value != ushort.MaxValue) {
                HandleFailure(new ArgumentException("value must equal ushort.MaxValue"));
            }

            return this;
        }

        public UShortEstablisher IsNotMaxValue() {
            if (Value == ushort.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal ushort.MaxValue"));
            }

            return this;
        }

    }

}
