using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {
    
    public class DoubleEstablisher : BaseStructEstablisher<double> {

        public bool IsGreaterThan(double baseline, double threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("double value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(double baseline, double threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("double value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(double baseline, double threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("double value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(double baseline, double threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("double value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsZero(double value) {
            if (value != 0) {
                return HandleFailure(new ArgumentException("value must be zero"));
            }

            return true;
        }

        public bool IsNotZero(double value) {
            if (value == 0) {
                return HandleFailure(new ArgumentException("value must not be zero"));
            }

            return true;
        }

    }

}
