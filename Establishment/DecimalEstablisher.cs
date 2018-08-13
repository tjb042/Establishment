using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class DecimalEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsGreaterThan(this BaseEstablisher<decimal> establisher, decimal threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("decimal value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsGreaterThanOrEqualTo(this BaseEstablisher<decimal> establisher, decimal threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("decimal value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsLessThan(this BaseEstablisher<decimal> establisher, decimal threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("decimal value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsLessThanOrEqualTo(this BaseEstablisher<decimal> establisher, decimal threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("decimal value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsZero(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsNotZero(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>decimal.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsMinValue(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value != decimal.MinValue) {
                establisher.RaiseException("value must equal decimal.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>decimal.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsNotMinValue(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value == decimal.MinValue) {
                establisher.RaiseException("value must not equal decimal.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>decimal.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsMaxValue(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value != decimal.MaxValue) {
                establisher.RaiseException("value must equal decimal.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>decimal.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsNotMaxValue(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value == decimal.MaxValue) {
                establisher.RaiseException("value must not equal decimal.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsPositive(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value < 0m) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public static BaseEstablisher<decimal> IsNegative(this BaseEstablisher<decimal> establisher) {
            if (establisher.Value > 0m) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
