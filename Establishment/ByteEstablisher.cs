using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ByteEstablisher : BaseStructEstablisher<byte> {

        internal ByteEstablisher(byte value) : base(value) { }

        public ByteEstablisher IsGreaterThan(byte threshold) {
            if (Value <= threshold) {
                HandleFailure("byte value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ByteEstablisher IsGreaterThanOrEqualTo(byte threshold) {
            if (Value < threshold) {
                HandleFailure("byte value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ByteEstablisher IsLessThan(byte threshold) {
            if (Value >= threshold) {
                HandleFailure("byte value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ByteEstablisher IsLessThanOrEqualTo(byte threshold) {
            if (Value > threshold) {
                HandleFailure("byte value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ByteEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        public ByteEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        public ByteEstablisher IsMinValue() {
            if (Value != byte.MinValue) {
                HandleFailure("value must equal byte.MinValue");
            }

            return this;
        }

        public ByteEstablisher IsNotMinValue() {
            if (Value == byte.MinValue) {
                HandleFailure("value must not equal byte.MinValue");
            }

            return this;
        }

        public ByteEstablisher IsMaxValue() {
            if (Value != byte.MaxValue) {
                HandleFailure("value must equal byte.MaxValue");
            }

            return this;
        }

        public ByteEstablisher IsNotMaxValue() {
            if (Value == byte.MaxValue) {
                HandleFailure("value must not equal byte.MaxValue");
            }

            return this;
        }

    }

}
