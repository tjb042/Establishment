using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public static class SByteEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsGreaterThan(this BaseEstablisher<sbyte> establisher, sbyte threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("sbyte value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsGreaterThanOrEqualTo(this BaseEstablisher<sbyte> establisher, sbyte threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("sbyte value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsLessThan(this BaseEstablisher<sbyte> establisher, sbyte threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("sbyte value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsLessThanOrEqualTo(this BaseEstablisher<sbyte> establisher, sbyte threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("sbyte value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsZero(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsNotZero(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>sbyte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsMinValue(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value != sbyte.MinValue) {
                establisher.RaiseException("value must equal sbyte.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>sbyte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsNotMinValue(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value == sbyte.MinValue) {
                establisher.RaiseException("value must not equal sbyte.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>sbyte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsMaxValue(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value != sbyte.MaxValue) {
                establisher.RaiseException("value must equal sbyte.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>sbyte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsNotMaxValue(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value == sbyte.MaxValue) {
                establisher.RaiseException("value must not equal sbyte.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsPositive(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value < 0) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static BaseEstablisher<sbyte> IsNegative(this BaseEstablisher<sbyte> establisher) {
            if (establisher.Value > 0) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
