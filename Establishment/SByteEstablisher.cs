using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class SByteEstablisher : BaseStructEstablisher<sbyte> {

        internal SByteEstablisher(sbyte value) : base(value) { }

        public SByteEstablisher IsGreaterThan(sbyte threshold) {
            if (Value <= threshold) {
                HandleFailure("sbyte value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public SByteEstablisher IsGreaterThanOrEqualTo(sbyte threshold) {
            if (Value < threshold) {
                HandleFailure("sbyte value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public SByteEstablisher IsLessThan(sbyte threshold) {
            if (Value >= threshold) {
                HandleFailure("sbyte value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public SByteEstablisher IsLessThanOrEqualTo(sbyte threshold) {
            if (Value > threshold) {
                HandleFailure("sbyte value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public SByteEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        public SByteEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        public SByteEstablisher IsMinValue() {
            if (Value != sbyte.MinValue) {
                HandleFailure("value must equal sbyte.MinValue");
            }

            return this;
        }

        public SByteEstablisher IsNotMinValue() {
            if (Value == sbyte.MinValue) {
                HandleFailure("value must not equal sbyte.MinValue");
            }

            return this;
        }

        public SByteEstablisher IsMaxValue() {
            if (Value != sbyte.MaxValue) {
                HandleFailure("value must equal sbyte.MaxValue");
            }

            return this;
        }

        public SByteEstablisher IsNotMaxValue() {
            if (Value == sbyte.MaxValue) {
                HandleFailure("value must not equal sbyte.MaxValue");
            }

            return this;
        }

        public SByteEstablisher IsPositive() {
            if (Value < 0) {
                HandleFailure("value must be greater than zero");
            }

            return this;
        }

        public SByteEstablisher IsNegative() {
            if (Value > 0) {
                HandleFailure("value must be less than zero");
            }

            return this;
        }

    }

}
