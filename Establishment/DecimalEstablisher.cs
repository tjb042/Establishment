using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DecimalEstablisher : BaseStructEstablisher<decimal> {

        internal DecimalEstablisher(decimal value) : base(value) { }

        public DecimalEstablisher IsGreaterThan(decimal threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("decimal value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public DecimalEstablisher IsGreaterThanOrEqualTo(decimal threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("decimal value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public DecimalEstablisher IsLessThan(decimal threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("decimal value must be less than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public DecimalEstablisher IsLessThanOrEqualTo(decimal threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("decimal value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public DecimalEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public DecimalEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public DecimalEstablisher IsMinValue() {
            if (Value != decimal.MinValue) {
                HandleFailure(new ArgumentException("value must equal decimal.MinValue"));
            }

            return this;
        }

        public DecimalEstablisher IsNotMinValue() {
            if (Value == decimal.MinValue) {
                HandleFailure(new ArgumentException("value must not equal decimal.MinValue"));
            }

            return this;
        }

        public DecimalEstablisher IsMaxValue() {
            if (Value != decimal.MaxValue) {
                HandleFailure(new ArgumentException("value must equal decimal.MaxValue"));
            }

            return this;
        }

        public DecimalEstablisher IsNotMaxValue() {
            if (Value == decimal.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal decimal.MaxValue"));
            }

            return this;
        }

    }

}
