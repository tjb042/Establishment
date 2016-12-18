using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class UShortEstablisher : BaseStructEstablisher<ushort> {

        public bool IsGreaterThan(ushort baseline, ushort threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("ushort value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(ushort baseline, ushort threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("ushort value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(ushort baseline, ushort threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("ushort value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(ushort baseline, ushort threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("ushort value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(ushort value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(ushort value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

        public bool IsMinValue(ushort value) {
            if (value != ushort.MinValue) {
                return HandleFailure(new ArgumentException("value must equal ushort.MinValue"));
            }

            return true;
        }

        public bool IsNotMinValue(ushort value) {
            if (value == ushort.MinValue) {
                return HandleFailure(new ArgumentException("value must not equal ushort.MinValue"));
            }

            return true;
        }

        public bool IsMaxValue(ushort value) {
            if (value != ushort.MaxValue) {
                return HandleFailure(new ArgumentException("value must equal ushort.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxValue(ushort value) {
            if (value == ushort.MaxValue) {
                return HandleFailure(new ArgumentException("value must not equal ushort.MaxValue"));
            }

            return true;
        }

    }

}
