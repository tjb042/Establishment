using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class TimeSpanEstablisher : BaseEstablisher<TimeSpan>, IStructEstablisher<TimeSpanEstablisher, TimeSpan> {

        internal TimeSpanEstablisher(TimeSpan value) : base(value) { }

        public TimeSpanEstablisher IsZero() {
            if (Value.Ticks != TimeSpan.Zero.Ticks) {
                HandleFailure("TimeSpan must equal zero");
            }

            return this;
        }

        public TimeSpanEstablisher IsNotZero() {
            if (Value.Ticks == TimeSpan.Zero.Ticks) {
                HandleFailure("TimeSpan must not equal zero");
            }

            return this;
        }

        public TimeSpanEstablisher IsMaxSpan() {
            if (Value.Ticks != TimeSpan.MaxValue.Ticks) {
                HandleFailure("TimeSpan must equal TimeSpan.MaxValue");
            }

            return this;
        }

        public TimeSpanEstablisher IsNotMaxSpan() {
            if (Value.Ticks == TimeSpan.MaxValue.Ticks) {
                HandleFailure("TimeSpan must not equal TimeSpan.MaxValue");
            }

            return this;
        }

        public TimeSpanEstablisher IsMinSpan() {
            if (Value.Ticks != TimeSpan.MinValue.Ticks) {
                HandleFailure("TimeSpan must equal TimeSpan.MinValue");
            }

            return this;
        }

        public TimeSpanEstablisher IsNotMinSpan() {
            if (Value.Ticks == TimeSpan.MinValue.Ticks) {
                HandleFailure("TimeSpan must not equal TimeSpan.MinValue");
            }

            return this;
        }

        public TimeSpanEstablisher IsGreaterThan(TimeSpan threshold) {
            if (Value <= threshold) {
                HandleFailure("TimeSpan value must be greater than " + threshold.ToString());
            }

            return this;
        }

        public TimeSpanEstablisher IsGreaterThanOrEqualTo(TimeSpan threshold) {
            if (Value < threshold) {
                HandleFailure("TimeSpan value must be greater than or equal to " + threshold.ToString());
            }

            return this;
        }

        public TimeSpanEstablisher IsLessThan(TimeSpan threshold) {
            if (Value >= threshold) {
                HandleFailure("TimeSpan value must be less than " + threshold.ToString());
            }

            return this;
        }

        public TimeSpanEstablisher IsLessThanOrEqualTo(TimeSpan threshold) {
            if (Value > threshold) {
                HandleFailure("TimeSpan value must be less than or equal to " + threshold.ToString());
            }

            return this;
        }

        public TimeSpanEstablisher IsDefault() {
            return base.IsDefault<TimeSpanEstablisher>();
        }

        public TimeSpanEstablisher IsNotDefault() {
            return base.IsNotDefault<TimeSpanEstablisher>();
        }

        public TimeSpanEstablisher IsEqualTo(TimeSpan constraint) {
            return base.IsEqualTo<TimeSpanEstablisher>(constraint);
        }

        public TimeSpanEstablisher IsNotEqualTo(TimeSpan constraint) {
            return base.IsNotEqualTo<TimeSpanEstablisher>(constraint);
        }

    }

}
