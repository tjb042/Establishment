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
        public static StructEstablisher<ushort> IsGreaterThan(this StructEstablisher<ushort> establisher, ushort threshold) {
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
        public static StructEstablisher<ushort> IsGreaterThanOrEqualTo(this StructEstablisher<ushort> establisher, ushort threshold) {
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
        public static StructEstablisher<ushort> IsLessThan(this StructEstablisher<ushort> establisher, ushort threshold) {
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
        public static StructEstablisher<ushort> IsLessThanOrEqualTo(this StructEstablisher<ushort> establisher, ushort threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("ushort value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static StructEstablisher<ushort> IsZero(this StructEstablisher<ushort> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static StructEstablisher<ushort> IsNotZero(this StructEstablisher<ushort> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ushort.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static StructEstablisher<ushort> IsMinValue(this StructEstablisher<ushort> establisher) {
            if (establisher.Value != ushort.MinValue) {
                establisher.RaiseException("value must equal ushort.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ushort.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static StructEstablisher<ushort> IsNotMinValue(this StructEstablisher<ushort> establisher) {
            if (establisher.Value == ushort.MinValue) {
                establisher.RaiseException("value must not equal ushort.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ushort.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static StructEstablisher<ushort> IsMaxValue(this StructEstablisher<ushort> establisher) {
            if (establisher.Value != ushort.MaxValue) {
                establisher.RaiseException("value must equal ushort.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ushort.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public static StructEstablisher<ushort> IsNotMaxValue(this StructEstablisher<ushort> establisher) {
            if (establisher.Value == ushort.MaxValue) {
                establisher.RaiseException("value must not equal ushort.MaxValue");
            }

            return establisher;
        }

    }

}
