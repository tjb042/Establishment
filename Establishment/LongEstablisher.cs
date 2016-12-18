using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {
    
    public class LongEstablisher : BaseStructEstablisher<long> {

        public bool IsGreaterThan(long baseline, long threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("long value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(long baseline, long threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("long value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(long baseline, long threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("long value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(long baseline, long threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("long value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(long value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(long value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

        public bool IsMinValue(long value) {
            if (value != long.MinValue) {
                return HandleFailure(new ArgumentException("value must equal long.MinValue"));
            }

            return true;
        }

        public bool IsNotMinValue(long value) {
            if (value == long.MinValue) {
                return HandleFailure(new ArgumentException("value must not equal long.MinValue"));
            }

            return true;
        }

        public bool IsMaxValue(long value) {
            if (value != long.MaxValue) {
                return HandleFailure(new ArgumentException("value must equal long.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxValue(long value) {
            if (value == long.MaxValue) {
                return HandleFailure(new ArgumentException("value must not equal long.MaxValue"));
            }

            return true;
        }

    }

}
