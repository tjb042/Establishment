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
        public static StructEstablisher<sbyte> IsGreaterThan(this StructEstablisher<sbyte> establisher, sbyte threshold) {
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
        public static StructEstablisher<sbyte> IsGreaterThanOrEqualTo(this StructEstablisher<sbyte> establisher, sbyte threshold) {
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
        public static StructEstablisher<sbyte> IsLessThan(this StructEstablisher<sbyte> establisher, sbyte threshold) {
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
        public static StructEstablisher<sbyte> IsLessThanOrEqualTo(this StructEstablisher<sbyte> establisher, sbyte threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("sbyte value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsZero(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsNotZero(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>sbyte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsMinValue(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value != sbyte.MinValue) {
                establisher.RaiseException("value must equal sbyte.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>sbyte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsNotMinValue(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value == sbyte.MinValue) {
                establisher.RaiseException("value must not equal sbyte.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>sbyte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsMaxValue(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value != sbyte.MaxValue) {
                establisher.RaiseException("value must equal sbyte.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>sbyte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsNotMaxValue(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value == sbyte.MaxValue) {
                establisher.RaiseException("value must not equal sbyte.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsPositive(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value < 0) {
                establisher.RaiseException("value must be greater than zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public static StructEstablisher<sbyte> IsNegative(this StructEstablisher<sbyte> establisher) {
            if (establisher.Value > 0) {
                establisher.RaiseException("value must be less than zero");
            }

            return establisher;
        }

    }

}
