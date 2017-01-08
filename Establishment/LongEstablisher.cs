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
        public static StructEstablisher<long> IsGreaterThan(this StructEstablisher<long> establisher, long threshold) {
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
        public static StructEstablisher<long> IsGreaterThanOrEqualTo(this StructEstablisher<long> establisher, long threshold) {
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
        public static StructEstablisher<long> IsLessThan(this StructEstablisher<long> establisher, long threshold) {
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
        public static StructEstablisher<long> IsLessThanOrEqualTo(this StructEstablisher<long> establisher, long threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("long value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsZero(this StructEstablisher<long> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsNotZero(this StructEstablisher<long> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>long.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsMinValue(this StructEstablisher<long> establisher) {
            if (establisher.Value != long.MinValue) {
                establisher.RaiseException("value must equal long.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>long.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsNotMinValue(this StructEstablisher<long> establisher) {
            if (establisher.Value == long.MinValue) {
                establisher.RaiseException("value must not equal long.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>long.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsMaxValue(this StructEstablisher<long> establisher) {
            if (establisher.Value != long.MaxValue) {
                establisher.RaiseException("value must equal long.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>long.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsNotMaxValue(this StructEstablisher<long> establisher) {
            if (establisher.Value == long.MaxValue) {
                establisher.RaiseException("value must not equal long.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsPositive(this StructEstablisher<long> establisher) {
            if (establisher.Value < 0L) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public static StructEstablisher<long> IsNegative(this StructEstablisher<long> establisher) {
            if (establisher.Value > 0L) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
