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
        public static StructEstablisher<int> IsGreaterThan(this StructEstablisher<int> establisher, int threshold) {
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
        public static StructEstablisher<int> IsGreaterThanOrEqualTo(this StructEstablisher<int> establisher, int threshold) {
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
        public static StructEstablisher<int> IsLessThan(this StructEstablisher<int> establisher, int threshold) {
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
        public static StructEstablisher<int> IsLessThanOrEqualTo(this StructEstablisher<int> establisher, int threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("int value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsZero(this StructEstablisher<int> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsNotZero(this StructEstablisher<int> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsMinValue(this StructEstablisher<int> establisher) {
            if (establisher.Value != int.MinValue) {
                establisher.RaiseException("value must equal int.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsNotMinValue(this StructEstablisher<int> establisher) {
            if (establisher.Value == int.MinValue) {
                establisher.RaiseException("value must not equal int.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsMaxValue(this StructEstablisher<int> establisher) {
            if (establisher.Value != int.MaxValue) {
                establisher.RaiseException("value must equal int.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsNotMaxValue(this StructEstablisher<int> establisher) {
            if (establisher.Value == int.MaxValue) {
                establisher.RaiseException("value must not equal int.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsPositive(this StructEstablisher<int> establisher) {
            if (establisher.Value < 0) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public static StructEstablisher<int> IsNegative(this StructEstablisher<int> establisher) {
            if (establisher.Value > 0) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
