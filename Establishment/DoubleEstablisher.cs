using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {
    
    public class DoubleEstablisher : BaseStructEstablisher<double> {

        public DoubleEstablisher(double value) : base(value) { }

        public DoubleEstablisher IsGreaterThan(double threshold) {
            if (Value <= threshold) {
                HandleFailure("double value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public DoubleEstablisher IsGreaterThanOrEqualTo(double threshold) {
            if (Value < threshold) {
                HandleFailure("double value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public DoubleEstablisher IsLessThan(double threshold) {
            if (Value >= threshold) {
                HandleFailure("double value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public DoubleEstablisher IsLessThanOrEqualTo(double threshold) {
            if (Value > threshold) {
                HandleFailure("double value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public DoubleEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        public DoubleEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        public DoubleEstablisher IsMinValue() {
            if (Value != double.MinValue) {
                HandleFailure("value must equal double.MinValue");
            }

            return this;
        }

        public DoubleEstablisher IsNotMinValue() {
            if (Value == double.MinValue) {
                HandleFailure("value must not equal double.MinValue");
            }

            return this;
        }

        public DoubleEstablisher IsMaxValue() {
            if (Value != double.MaxValue) {
                HandleFailure("value must equal double.MaxValue");
            }

            return this;
        }

        public DoubleEstablisher IsNotMaxValue() {
            if (Value == double.MaxValue) {
                HandleFailure("value must not equal double.MaxValue");
            }

            return this;
        }

        public DoubleEstablisher IsPositive() {
            if (Value < 0D) {
                HandleFailure("value must be greater than zero");
            }

            return this;
        }

        public DoubleEstablisher IsNegative() {
            if (Value > 0D) {
                HandleFailure("value must be less than zero");
            }

            return this;
        }

    }

}
