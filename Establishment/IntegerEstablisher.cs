using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class IntegerEstablisher : BaseStructEstablisher<int> {

        internal IntegerEstablisher(int value) : base(value) { }

        public IntegerEstablisher IsGreaterThan(int threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("int value must be greater than " + threshold.ToString()));
            }

            return this;
        }

        public IntegerEstablisher IsGreaterThanOrEqualTo(int threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("int value must be greater than or equal to " + threshold.ToString()));
            }

            return this;
        }

        public IntegerEstablisher IsLessThan(int threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("int value must be less than " + threshold.ToString()));
            }

            return this;
        }

        public IntegerEstablisher IsLessThanOrEqualTo(int threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("int value must be less than or equal to " + threshold.ToString()));
            }

            return this;
        }

        public IntegerEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public IntegerEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public IntegerEstablisher IsMinValue() {
            if (Value != int.MinValue) {
                HandleFailure(new ArgumentException("value must equal int.MinValue"));
            }

            return this;
        }

        public IntegerEstablisher IsNotMinValue() {
            if (Value == int.MinValue) {
                HandleFailure(new ArgumentException("value must not equal int.MinValue"));
            }

            return this;
        }

        public IntegerEstablisher IsMaxValue() {
            if (Value != int.MaxValue) {
                HandleFailure(new ArgumentException("value must equal int.MaxValue"));
            }

            return this;
        }

        public IntegerEstablisher IsNotMaxValue() {
            if (Value == int.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal int.MaxValue"));
            }

            return this;
        }

    }

}
