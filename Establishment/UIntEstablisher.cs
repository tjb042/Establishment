using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public static class UIntegerEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsGreaterThan(this StructEstablisher<uint> establisher, uint threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("uint value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsGreaterThanOrEqualTo(this StructEstablisher<uint> establisher, uint threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("uint value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsLessThan(this StructEstablisher<uint> establisher, uint threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("uint value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsLessThanOrEqualTo(this StructEstablisher<uint> establisher, uint threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("uint value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsZero(this StructEstablisher<uint> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsNotZero(this StructEstablisher<uint> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>uint.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsMinValue(this StructEstablisher<uint> establisher) {
            if (establisher.Value != uint.MinValue) {
                establisher.RaiseException("value must equal uint.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>uint.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsNotMinValue(this StructEstablisher<uint> establisher) {
            if (establisher.Value == uint.MinValue) {
                establisher.RaiseException("value must not equal uint.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>uint.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsMaxValue(this StructEstablisher<uint> establisher) {
            if (establisher.Value != uint.MaxValue) {
                establisher.RaiseException("value must equal uint.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>uint.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public static StructEstablisher<uint> IsNotMaxValue(this StructEstablisher<uint> establisher) {
            if (establisher.Value == uint.MaxValue) {
                establisher.RaiseException("value must not equal uint.MaxValue");
            }

            return establisher;
        }

    }

}
