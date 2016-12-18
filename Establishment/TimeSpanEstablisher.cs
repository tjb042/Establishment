using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class TimeSpanEstablisher : BaseStructEstablisher<TimeSpan> {

        public bool IsZero(TimeSpan baseline) {
            if (baseline.Ticks != TimeSpan.Zero.Ticks) {
                return HandleFailure(new ArgumentException("TimeSpan must equal zero"));
            }

            return true;
        }

        public bool IsNotZero(TimeSpan baseline) {
            if (baseline.Ticks == TimeSpan.Zero.Ticks) {
                return HandleFailure(new ArgumentException("TimeSpan must not equal zero"));
            }

            return true;
        }

        public bool IsMaxSpan(TimeSpan baseline) {
            if (baseline.Ticks != TimeSpan.MaxValue.Ticks) {
                return HandleFailure(new ArgumentException("TimeSpan must equal TimeSpan.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxSpan(TimeSpan baseline) {
            if (baseline.Ticks == TimeSpan.MaxValue.Ticks) {
                return HandleFailure(new ArgumentException("TimeSpan must not equal TimeSpan.MaxValue"));
            }

            return true;
        }

        public bool IsMinSpan(TimeSpan baseline) {
            if (baseline.Ticks != TimeSpan.MinValue.Ticks) {
                return HandleFailure(new ArgumentException("TimeSpan must equal TimeSpan.MinValue"));
            }

            return true;
        }

        public bool IsNotMinSpan(TimeSpan baseline) {
            if (baseline.Ticks == TimeSpan.MinValue.Ticks) {
                return HandleFailure(new ArgumentException("TimeSpan must not equal TimeSpan.MinValue"));
            }

            return true;
        }

        public bool IsGreaterThan(TimeSpan baseline, TimeSpan threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("TimeSpan value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(TimeSpan baseline, TimeSpan threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("TimeSpan value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(TimeSpan baseline, TimeSpan threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("TimeSpan value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(TimeSpan baseline, TimeSpan threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("TimeSpan value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

    }

}
