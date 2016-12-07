using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class FloatEstablisher : BaseStructEstablisher<float> {

        public bool IsGreaterThan(float baseline, float threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("float value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(float baseline, float threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("float value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(float baseline, float threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("float value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(float baseline, float threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("float value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(float value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(float value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

    }

}
