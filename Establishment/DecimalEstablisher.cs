using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DecimalEstablisher : BaseStructEstablisher<decimal> {

        public bool IsGreaterThan(decimal baseline, decimal threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("decimal value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(decimal baseline, decimal threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("decimal value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(decimal baseline, decimal threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("decimal value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(decimal baseline, decimal threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("decimal value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(decimal value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(decimal value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

        public bool IsMinValue(decimal value) {
            if (value != decimal.MinValue) {
                return HandleFailure(new ArgumentException("value must equal decimal.MinValue"));
            }

            return true;
        }

        public bool IsNotMinValue(decimal value) {
            if (value == decimal.MinValue) {
                return HandleFailure(new ArgumentException("value must not equal decimal.MinValue"));
            }

            return true;
        }

        public bool IsMaxValue(decimal value) {
            if (value != decimal.MaxValue) {
                return HandleFailure(new ArgumentException("value must equal decimal.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxValue(decimal value) {
            if (value == decimal.MaxValue) {
                return HandleFailure(new ArgumentException("value must not equal decimal.MaxValue"));
            }

            return true;
        }

    }

}
