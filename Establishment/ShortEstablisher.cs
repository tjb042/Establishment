using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ShortEstablisher : BaseStructEstablisher<short> {

        internal ShortEstablisher(short value) : base(value) { }

        public ShortEstablisher IsGreaterThan(short threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("short value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ShortEstablisher IsGreaterThanOrEqualTo(short threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("short value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ShortEstablisher IsLessThan(short threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("short value must be less than " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ShortEstablisher IsLessThanOrEqualTo(short threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("short value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture)));
            }

            return this;
        }

        public ShortEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public ShortEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public ShortEstablisher IsMinValue() {
            if (Value != short.MinValue) {
                HandleFailure(new ArgumentException("value must equal short.MinValue"));
            }

            return this;
        }

        public ShortEstablisher IsNotMinValue() {
            if (Value == short.MinValue) {
                HandleFailure(new ArgumentException("value must not equal short.MinValue"));
            }

            return this;
        }

        public ShortEstablisher IsMaxValue() {
            if (Value != short.MaxValue) {
                HandleFailure(new ArgumentException("value must equal short.MaxValue"));
            }

            return this;
        }

        public ShortEstablisher IsNotMaxValue() {
            if (Value == short.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal short.MaxValue"));
            }

            return this;
        }

    }

}
