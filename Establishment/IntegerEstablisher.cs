using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class IntegerEstablisher {
        
        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsGreaterThan(this BaseEstablisher<int> establisher, int threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("int value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsGreaterThanOrEqualTo(this BaseEstablisher<int> establisher, int threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("int value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsLessThan(this BaseEstablisher<int> establisher, int threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("int value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsLessThanOrEqualTo(this BaseEstablisher<int> establisher, int threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("int value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsZero(this BaseEstablisher<int> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsNotZero(this BaseEstablisher<int> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsMinValue(this BaseEstablisher<int> establisher) {
            if (establisher.Value != int.MinValue) {
                establisher.RaiseException("value must equal int.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsNotMinValue(this BaseEstablisher<int> establisher) {
            if (establisher.Value == int.MinValue) {
                establisher.RaiseException("value must not equal int.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsMaxValue(this BaseEstablisher<int> establisher) {
            if (establisher.Value != int.MaxValue) {
                establisher.RaiseException("value must equal int.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsNotMaxValue(this BaseEstablisher<int> establisher) {
            if (establisher.Value == int.MaxValue) {
                establisher.RaiseException("value must not equal int.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsPositive(this BaseEstablisher<int> establisher) {
            if (establisher.Value < 0) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static BaseEstablisher<int> IsNegative(this BaseEstablisher<int> establisher) {
            if (establisher.Value > 0) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
