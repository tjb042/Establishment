using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ByteEstablisher : BaseStructEstablisher<byte> {

        public bool IsGreaterThan(byte baseline, byte threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("byte value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(byte baseline, byte threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("byte value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(byte baseline, byte threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("byte value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(byte baseline, byte threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("byte value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(byte value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(byte value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

    }

}
