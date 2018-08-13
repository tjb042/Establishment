using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class LongEstablisher  {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsGreaterThan(this BaseEstablisher<long> establisher, long threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("long value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsGreaterThanOrEqualTo(this BaseEstablisher<long> establisher, long threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("long value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsLessThan(this BaseEstablisher<long> establisher, long threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("long value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsLessThanOrEqualTo(this BaseEstablisher<long> establisher, long threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("long value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsZero(this BaseEstablisher<long> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsNotZero(this BaseEstablisher<long> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>long.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsMinValue(this BaseEstablisher<long> establisher) {
            if (establisher.Value != long.MinValue) {
                establisher.RaiseException("value must equal long.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>long.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsNotMinValue(this BaseEstablisher<long> establisher) {
            if (establisher.Value == long.MinValue) {
                establisher.RaiseException("value must not equal long.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>long.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsMaxValue(this BaseEstablisher<long> establisher) {
            if (establisher.Value != long.MaxValue) {
                establisher.RaiseException("value must equal long.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>long.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsNotMaxValue(this BaseEstablisher<long> establisher) {
            if (establisher.Value == long.MaxValue) {
                establisher.RaiseException("value must not equal long.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsPositive(this BaseEstablisher<long> establisher) {
            if (establisher.Value < 0L) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static BaseEstablisher<long> IsNegative(this BaseEstablisher<long> establisher) {
            if (establisher.Value > 0L) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
