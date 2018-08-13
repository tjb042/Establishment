using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public static class UShortEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsGreaterThan(this BaseEstablisher<ushort> establisher, ushort threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("ushort value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsGreaterThanOrEqualTo(this BaseEstablisher<ushort> establisher, ushort threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("ushort value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }
        
        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsLessThan(this BaseEstablisher<ushort> establisher, ushort threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("ushort value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsLessThanOrEqualTo(this BaseEstablisher<ushort> establisher, ushort threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("ushort value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsZero(this BaseEstablisher<ushort> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsNotZero(this BaseEstablisher<ushort> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ushort.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsMinValue(this BaseEstablisher<ushort> establisher) {
            if (establisher.Value != ushort.MinValue) {
                establisher.RaiseException("value must equal ushort.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ushort.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsNotMinValue(this BaseEstablisher<ushort> establisher) {
            if (establisher.Value == ushort.MinValue) {
                establisher.RaiseException("value must not equal ushort.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ushort.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsMaxValue(this BaseEstablisher<ushort> establisher) {
            if (establisher.Value != ushort.MaxValue) {
                establisher.RaiseException("value must equal ushort.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ushort.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static BaseEstablisher<ushort> IsNotMaxValue(this BaseEstablisher<ushort> establisher) {
            if (establisher.Value == ushort.MaxValue) {
                establisher.RaiseException("value must not equal ushort.MaxValue");
            }

            return establisher;
        }

    }

}
