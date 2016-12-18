using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class SByteEstablisher : BaseStructEstablisher<sbyte> {

        public bool IsGreaterThan(sbyte baseline, sbyte threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("sbyte value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(sbyte baseline, sbyte threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("sbyte value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(sbyte baseline, sbyte threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("sbyte value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(sbyte baseline, sbyte threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("sbyte value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(sbyte value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(sbyte value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

        public bool IsMinValue(sbyte value) {
            if (value != sbyte.MinValue) {
                return HandleFailure(new ArgumentException("value must equal sbyte.MinValue"));
            }

            return true;
        }

        public bool IsNotMinValue(sbyte value) {
            if (value == sbyte.MinValue) {
                return HandleFailure(new ArgumentException("value must not equal sbyte.MinValue"));
            }

            return true;
        }

        public bool IsMaxValue(sbyte value) {
            if (value != sbyte.MaxValue) {
                return HandleFailure(new ArgumentException("value must equal sbyte.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxValue(sbyte value) {
            if (value == sbyte.MaxValue) {
                return HandleFailure(new ArgumentException("value must not equal sbyte.MaxValue"));
            }

            return true;
        }

    }

}
