using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {
    
    public class LongEstablisher : BaseStructEstablisher<long> {

        internal LongEstablisher(long value) : base(value) { }

        public LongEstablisher IsGreaterThan(long threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("long value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public LongEstablisher IsGreaterThanOrEqualTo(long threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("long value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public LongEstablisher IsLessThan(long threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("long value must be less than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public LongEstablisher IsLessThanOrEqualTo(long threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("long value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public LongEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public LongEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public LongEstablisher IsMinValue() {
            if (Value != long.MinValue) {
                HandleFailure(new ArgumentException("value must equal long.MinValue"));
            }

            return this;
        }

        public LongEstablisher IsNotMinValue() {
            if (Value == long.MinValue) {
                HandleFailure(new ArgumentException("value must not equal long.MinValue"));
            }

            return this;
        }

        public LongEstablisher IsMaxValue() {
            if (Value != long.MaxValue) {
                HandleFailure(new ArgumentException("value must equal long.MaxValue"));
            }

            return this;
        }

        public LongEstablisher IsNotMaxValue() {
            if (Value == long.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal long.MaxValue"));
            }

            return this;
        }

        public LongEstablisher IsPositive() {
            if (Value < 0L) {
                HandleFailure(new ArgumentException("value must be greater than zero"));
            }

            return this;
        }

        public LongEstablisher IsNegative() {
            if (Value > 0L) {
                HandleFailure(new ArgumentException("value must be less than zero"));
            }

            return this;
        }

    }

}
