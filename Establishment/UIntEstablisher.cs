using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class UIntegerEstablisher : BaseStructEstablisher<uint> {

        public bool IsGreaterThan(uint baseline, uint threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("uint value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(uint baseline, uint threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("uint value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(uint baseline, uint threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("uint value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(uint baseline, uint threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("uint value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(uint value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(uint value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

        public bool IsMinValue(uint value) {
            if (value != uint.MinValue) {
                return HandleFailure(new ArgumentException("value must equal uint.MinValue"));
            }

            return true;
        }

        public bool IsNotMinValue(uint value) {
            if (value == uint.MinValue) {
                return HandleFailure(new ArgumentException("value must not equal uint.MinValue"));
            }

            return true;
        }

        public bool IsMaxValue(uint value) {
            if (value != uint.MaxValue) {
                return HandleFailure(new ArgumentException("value must equal uint.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxValue(uint value) {
            if (value == uint.MaxValue) {
                return HandleFailure(new ArgumentException("value must not equal uint.MaxValue"));
            }

            return true;
        }

    }

}
