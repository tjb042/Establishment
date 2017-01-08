using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class ShortEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static StructEstablisher<short> IsGreaterThan(this StructEstablisher<short> establisher, short threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("short value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static StructEstablisher<short> IsGreaterThanOrEqualTo(this StructEstablisher<short> establisher, short threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("short value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static StructEstablisher<short> IsLessThan(this StructEstablisher<short> establisher, short threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("short value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static StructEstablisher<short> IsLessThanOrEqualTo(this StructEstablisher<short> establisher, short threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("short value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsZero(this StructEstablisher<short> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsNotZero(this StructEstablisher<short> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>short.MinValue</c>
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsMinValue(this StructEstablisher<short> establisher) {
            if (establisher.Value != short.MinValue) {
                establisher.RaiseException("value must equal short.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>short.MinValue</c>
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsNotMinValue(this StructEstablisher<short> establisher) {
            if (establisher.Value == short.MinValue) {
                establisher.RaiseException("value must not equal short.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>short.MaxValue</c>
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsMaxValue(this StructEstablisher<short> establisher) {
            if (establisher.Value != short.MaxValue) {
                establisher.RaiseException("value must equal short.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>short.MaxValue</c>
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsNotMaxValue(this StructEstablisher<short> establisher) {
            if (establisher.Value == short.MaxValue) {
                establisher.RaiseException("value must not equal short.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsPositive(this StructEstablisher<short> establisher) {
            if (establisher.Value < 0) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns></returns>
        public static StructEstablisher<short> IsNegative(this StructEstablisher<short> establisher) {
            if (establisher.Value > 0) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
