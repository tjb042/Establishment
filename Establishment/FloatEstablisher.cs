using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class FloatEstablisher : BaseEstablisher<float>, IStructEstablisher<FloatEstablisher, float> {

        internal FloatEstablisher(float value) : base(value) { }

        public FloatEstablisher IsGreaterThan(float threshold) {
            if (Value <= threshold) {
                HandleFailure("float value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public FloatEstablisher IsGreaterThanOrEqualTo(float threshold) {
            if (Value < threshold) {
                HandleFailure("float value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public FloatEstablisher IsLessThan(float threshold) {
            if (Value >= threshold) {
                HandleFailure("float value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public FloatEstablisher IsLessThanOrEqualTo(float threshold) {
            if (Value > threshold) {
                HandleFailure("float value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public FloatEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        public FloatEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        public FloatEstablisher IsMinValue() {
            if (Value != float.MinValue) {
                HandleFailure("value must equal float.MinValue");
            }

            return this;
        }

        public FloatEstablisher IsNotMinValue() {
            if (Value == float.MinValue) {
                HandleFailure("value must not equal float.MinValue");
            }

            return this;
        }

        public FloatEstablisher IsMaxValue() {
            if (Value != float.MaxValue) {
                HandleFailure("value must equal float.MaxValue");
            }

            return this;
        }

        public FloatEstablisher IsNotMaxValue() {
            if (Value == float.MaxValue) {
                HandleFailure("value must not equal float.MaxValue");
            }

            return this;
        }

        public FloatEstablisher IsPositive() {
            if (Value < 0f) {
                HandleFailure("value must be greater than zero");
            }

            return this;
        }

        public FloatEstablisher IsNegative() {
            if (Value > 0f) {
                HandleFailure("value must be less than zero");
            }

            return this;
        }

        public FloatEstablisher IsDefault() {
            return base.IsDefault<FloatEstablisher>();
        }

        public FloatEstablisher IsNotDefault() {
            return base.IsNotDefault<FloatEstablisher>();
        }

        public FloatEstablisher IsEqualTo(float constraint) {
            return base.IsEqualTo<FloatEstablisher>(constraint);
        }

        public FloatEstablisher IsNotEqualTo(float constraint) {
            return base.IsNotEqualTo<FloatEstablisher>(constraint);
        }

    }

}
