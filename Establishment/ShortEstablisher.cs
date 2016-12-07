using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ShortEstablisher : BaseStructEstablisher<short> {

        public bool IsGreaterThan(short baseline, short threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("short value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(short baseline, short threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("short value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(short baseline, short threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("short value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(short baseline, short threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("short value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(short value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(short value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

    }

}
