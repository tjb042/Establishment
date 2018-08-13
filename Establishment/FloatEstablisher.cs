using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class FloatEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsGreaterThan(this BaseEstablisher<float> establisher, float threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("float value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsGreaterThanOrEqualTo(this BaseEstablisher<float> establisher, float threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("float value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsLessThan(this BaseEstablisher<float> establisher, float threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("float value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsLessThanOrEqualTo(this BaseEstablisher<float> establisher, float threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("float value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsZero(this BaseEstablisher<float> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsNotZero(this BaseEstablisher<float> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>float.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsMinValue(this BaseEstablisher<float> establisher) {
            if (establisher.Value != float.MinValue) {
                establisher.RaiseException("value must equal float.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>float.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsNotMinValue(this BaseEstablisher<float> establisher) {
            if (establisher.Value == float.MinValue) {
                establisher.RaiseException("value must not equal float.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>float.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsMaxValue(this BaseEstablisher<float> establisher) {
            if (establisher.Value != float.MaxValue) {
                establisher.RaiseException("value must equal float.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>float.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsNotMaxValue(this BaseEstablisher<float> establisher) {
            if (establisher.Value == float.MaxValue) {
                establisher.RaiseException("value must not equal float.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public static BaseEstablisher<float> IsPositive(this BaseEstablisher<float> establisher) {
            if (establisher.Value < 0f) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        //Establishes that the supplied value is less than or equal to zero
        public static BaseEstablisher<float> IsNegative(this BaseEstablisher<float> establisher) {
            if (establisher.Value > 0f) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
