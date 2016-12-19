using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class UIntegerEstablisher : BaseStructEstablisher<uint> {

        internal UIntegerEstablisher(uint value) : base(value) { }

        public UIntegerEstablisher IsGreaterThan(uint threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("uint value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UIntegerEstablisher IsGreaterThanOrEqualTo(uint threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("uint value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UIntegerEstablisher IsLessThan(uint threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("uint value must be less than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UIntegerEstablisher IsLessThanOrEqualTo(uint threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("uint value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public UIntegerEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public UIntegerEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public UIntegerEstablisher IsMinValue() {
            if (Value != uint.MinValue) {
                HandleFailure(new ArgumentException("value must equal uint.MinValue"));
            }

            return this;
        }

        public UIntegerEstablisher IsNotMinValue() {
            if (Value == uint.MinValue) {
                HandleFailure(new ArgumentException("value must not equal uint.MinValue"));
            }

            return this;
        }

        public UIntegerEstablisher IsMaxValue() {
            if (Value != uint.MaxValue) {
                HandleFailure(new ArgumentException("value must equal uint.MaxValue"));
            }

            return this;
        }

        public UIntegerEstablisher IsNotMaxValue() {
            if (Value == uint.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal uint.MaxValue"));
            }

            return this;
        }

    }

}
