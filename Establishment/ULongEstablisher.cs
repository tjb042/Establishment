using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ULongEstablisher : BaseStructEstablisher<ulong> {

        internal ULongEstablisher(ulong value) : base(value) {
            
        }

        public ULongEstablisher IsGreaterThan(ulong threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("ulong value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ULongEstablisher IsGreaterThanOrEqualTo(ulong threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("ulong value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ULongEstablisher IsLessThan(ulong threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("ulong value must be less than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ULongEstablisher IsLessThanOrEqualTo(ulong threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("ulong value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ULongEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public ULongEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public ULongEstablisher IsMinValue() {
            if (Value != ulong.MinValue) {
                HandleFailure(new ArgumentException("value must equal ulong.MinValue"));
            }

            return this;
        }

        public ULongEstablisher IsNotMinValue() {
            if (Value == ulong.MinValue) {
                HandleFailure(new ArgumentException("value must not equal ulong.MinValue"));
            }

            return this;
        }

        public ULongEstablisher IsMaxValue() {
            if (Value != ulong.MaxValue) {
                HandleFailure(new ArgumentException("value must equal ulong.MaxValue"));
            }

            return this;
        }

        public ULongEstablisher IsNotMaxValue() {
            if (Value == ulong.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal ulong.MaxValue"));
            }

            return this;
        }

    }

}
