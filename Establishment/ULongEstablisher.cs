using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public static class ULongEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsGreaterThan(this BaseEstablisher<ulong> establisher, ulong threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("ulong value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsGreaterThanOrEqualTo(this BaseEstablisher<ulong> establisher, ulong threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("ulong value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsLessThan(this BaseEstablisher<ulong> establisher, ulong threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("ulong value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsLessThanOrEqualTo(this BaseEstablisher<ulong> establisher, ulong threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("ulong value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsZero(this BaseEstablisher<ulong> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsNotZero(this BaseEstablisher<ulong> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ulong.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsMinValue(this BaseEstablisher<ulong> establisher) {
            if (establisher.Value != ulong.MinValue) {
                establisher.RaiseException("value must equal ulong.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ulong.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsNotMinValue(this BaseEstablisher<ulong> establisher) {
            if (establisher.Value == ulong.MinValue) {
                establisher.RaiseException("value must not equal ulong.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ulong.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsMaxValue(this BaseEstablisher<ulong> establisher) {
            if (establisher.Value != ulong.MaxValue) {
                establisher.RaiseException("value must equal ulong.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ulong.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public static BaseEstablisher<ulong> IsNotMaxValue(this BaseEstablisher<ulong> establisher) {
            if (establisher.Value == ulong.MaxValue) {
                establisher.RaiseException("value must not equal ulong.MaxValue");
            }

            return establisher;
        }

    }

}
