using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class TimeSpanEstablisher {

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.Zero</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsZero(this StructEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks != TimeSpan.Zero.Ticks) {
                establisher.RaiseException("TimeSpan must equal zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.Zero</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsNotZero(this StructEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks == TimeSpan.Zero.Ticks) {
                establisher.RaiseException("TimeSpan must not equal zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsMaxSpan(this StructEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks != TimeSpan.MaxValue.Ticks) {
                establisher.RaiseException("TimeSpan must equal TimeSpan.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsNotMaxSpan(this StructEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks == TimeSpan.MaxValue.Ticks) {
                establisher.RaiseException("TimeSpan must not equal TimeSpan.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsMinSpan(this StructEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks != TimeSpan.MinValue.Ticks) {
                establisher.RaiseException("TimeSpan must equal TimeSpan.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsNotMinSpan(this StructEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks == TimeSpan.MinValue.Ticks) {
                establisher.RaiseException("TimeSpan must not equal TimeSpan.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsGreaterThan(this StructEstablisher<TimeSpan> establisher, TimeSpan threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("TimeSpan value must be greater than " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsGreaterThanOrEqualTo(this StructEstablisher<TimeSpan> establisher, TimeSpan threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("TimeSpan value must be greater than or equal to " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsLessThan(this StructEstablisher<TimeSpan> establisher, TimeSpan threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("TimeSpan value must be less than " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static StructEstablisher<TimeSpan> IsLessThanOrEqualTo(this StructEstablisher<TimeSpan> establisher, TimeSpan threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("TimeSpan value must be less than or equal to " + threshold.ToString());
            }

            return establisher;
        }

    }

}
