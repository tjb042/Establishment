using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class DoubleEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsGreaterThan(this BaseEstablisher<double> establisher, double threshold) {
            if (establisher.Value  <= threshold) {
                establisher.RaiseException("double value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsGreaterThanOrEqualTo(this BaseEstablisher<double> establisher, double threshold) {
            if (establisher.Value  < threshold) {
                establisher.RaiseException("double value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsLessThan(this BaseEstablisher<double> establisher, double threshold) {
            if (establisher.Value  >= threshold) {
                establisher.RaiseException("double value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsLessThanOrEqualTo(this BaseEstablisher<double> establisher, double threshold) {
            if (establisher.Value  > threshold) {
                establisher.RaiseException("double value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsZero(this BaseEstablisher<double> establisher) {
            if (establisher.Value  != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsNotZero(this BaseEstablisher<double> establisher) {
            if (establisher.Value  == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>double.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsMinValue(this BaseEstablisher<double> establisher) {
            if (establisher.Value  != double.MinValue) {
                establisher.RaiseException("value must equal double.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>double.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsNotMinValue(this BaseEstablisher<double> establisher) {
            if (establisher.Value  == double.MinValue) {
                establisher.RaiseException("value must not equal double.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>double.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsMaxValue(this BaseEstablisher<double> establisher) {
            if (establisher.Value  != double.MaxValue) {
                establisher.RaiseException("value must equal double.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>double.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsNotMaxValue(this BaseEstablisher<double> establisher) {
            if (establisher.Value  == double.MaxValue) {
                establisher.RaiseException("value must not equal double.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsPositive(this BaseEstablisher<double> establisher) {
            if (establisher.Value  < 0D) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public static BaseEstablisher<double> IsNegative(this BaseEstablisher<double> establisher) {
            if (establisher.Value  > 0D) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }
        
    }

}
