using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class LongEstablisher : BaseEstablisher<long>, IStructEstablisher<LongEstablisher, long> {

        internal LongEstablisher(long value) : base(value) { }

        public LongEstablisher IsGreaterThan(long threshold) {
            if (Value <= threshold) {
                HandleFailure("long value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public LongEstablisher IsGreaterThanOrEqualTo(long threshold) {
            if (Value < threshold) {
                HandleFailure("long value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public LongEstablisher IsLessThan(long threshold) {
            if (Value >= threshold) {
                HandleFailure("long value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public LongEstablisher IsLessThanOrEqualTo(long threshold) {
            if (Value > threshold) {
                HandleFailure("long value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public LongEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        public LongEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        public LongEstablisher IsMinValue() {
            if (Value != long.MinValue) {
                HandleFailure("value must equal long.MinValue");
            }

            return this;
        }

        public LongEstablisher IsNotMinValue() {
            if (Value == long.MinValue) {
                HandleFailure("value must not equal long.MinValue");
            }

            return this;
        }

        public LongEstablisher IsMaxValue() {
            if (Value != long.MaxValue) {
                HandleFailure("value must equal long.MaxValue");
            }

            return this;
        }

        public LongEstablisher IsNotMaxValue() {
            if (Value == long.MaxValue) {
                HandleFailure("value must not equal long.MaxValue");
            }

            return this;
        }

        public LongEstablisher IsPositive() {
            if (Value < 0L) {
                HandleFailure("value must be greater than zero");
            }

            return this;
        }

        public LongEstablisher IsNegative() {
            if (Value > 0L) {
                HandleFailure("value must be less than zero");
            }

            return this;
        }

        public LongEstablisher IsDefault() {
            return base.IsDefault<LongEstablisher>();
        }

        public LongEstablisher IsNotDefault() {
            return base.IsNotDefault<LongEstablisher>();
        }

        public LongEstablisher IsEqualTo(long constraint) {
            return base.IsEqualTo<LongEstablisher>(constraint);
        }

        public LongEstablisher IsNotEqualTo(long constraint) {
            return base.IsNotEqualTo<LongEstablisher>(constraint);
        }

    }

}
