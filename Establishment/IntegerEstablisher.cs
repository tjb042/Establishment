using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class IntegerEstablisher : BaseStructEstablisher<int> {

        public bool IsGreaterThan(int baseline, int threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("int value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(int baseline, int threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("int value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(int baseline, int threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("int value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(int baseline, int threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("int value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(int value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(int value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

    }

}
