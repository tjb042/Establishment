using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class UlongEstablisher : BaseStructEstablisher<ulong> {

        public bool IsGreaterThan(ulong baseline, ulong threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("ulong value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(ulong baseline, ulong threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("ulong value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(ulong baseline, ulong threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("ulong value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(ulong baseline, ulong threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("ulong value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(ulong value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(ulong value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

        public bool IsMinValue(ulong value) {
            if (value != ulong.MinValue) {
                return HandleFailure(new ArgumentException("value must equal ulong.MinValue"));
            }

            return true;
        }

        public bool IsNotMinValue(ulong value) {
            if (value == ulong.MinValue) {
                return HandleFailure(new ArgumentException("value must not equal ulong.MinValue"));
            }

            return true;
        }

        public bool IsMaxValue(ulong value) {
            if (value != ulong.MaxValue) {
                return HandleFailure(new ArgumentException("value must equal ulong.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxValue(ulong value) {
            if (value == ulong.MaxValue) {
                return HandleFailure(new ArgumentException("value must not equal ulong.MaxValue"));
            }

            return true;
        }

    }

}
