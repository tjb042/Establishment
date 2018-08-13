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
        public static BaseEstablisher<TimeSpan> IsZero(this BaseEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks != TimeSpan.Zero.Ticks) {
                establisher.RaiseException("TimeSpan must equal zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.Zero</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static BaseEstablisher<TimeSpan> IsNotZero(this BaseEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks == TimeSpan.Zero.Ticks) {
                establisher.RaiseException("TimeSpan must not equal zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static BaseEstablisher<TimeSpan> IsMaxSpan(this BaseEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks != TimeSpan.MaxValue.Ticks) {
                establisher.RaiseException("TimeSpan must equal TimeSpan.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static BaseEstablisher<TimeSpan> IsNotMaxSpan(this BaseEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks == TimeSpan.MaxValue.Ticks) {
                establisher.RaiseException("TimeSpan must not equal TimeSpan.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static BaseEstablisher<TimeSpan> IsMinSpan(this BaseEstablisher<TimeSpan> establisher) {
            if (establisher.Value.Ticks != TimeSpan.MinValue.Ticks) {
                establisher.RaiseException("TimeSpan must equal TimeSpan.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public static BaseEstablisher<TimeSpan> IsNotMinSpan(this BaseEstablisher<TimeSpan> establisher) {
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
        public static BaseEstablisher<TimeSpan> IsGreaterThan(this BaseEstablisher<TimeSpan> establisher, TimeSpan threshold) {
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
        public static BaseEstablisher<TimeSpan> IsGreaterThanOrEqualTo(this BaseEstablisher<TimeSpan> establisher, TimeSpan threshold) {
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
        public static BaseEstablisher<TimeSpan> IsLessThan(this BaseEstablisher<TimeSpan> establisher, TimeSpan threshold) {
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
        public static BaseEstablisher<TimeSpan> IsLessThanOrEqualTo(this BaseEstablisher<TimeSpan> establisher, TimeSpan threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("TimeSpan value must be less than or equal to " + threshold.ToString());
            }

            return establisher;
        }

    }

}
