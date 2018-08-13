using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class ByteEstablisher {

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsGreaterThan(this BaseEstablisher<byte> establisher, byte threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("byte value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsGreaterThanOrEqualTo(this BaseEstablisher<byte> establisher, byte threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("byte value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsLessThan(this BaseEstablisher<byte> establisher, byte threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("byte value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsLessThanOrEqualTo(this BaseEstablisher<byte> establisher, byte threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("byte value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsZero(this BaseEstablisher<byte> establisher) {
            if (establisher.Value != 0) {
                establisher.RaiseException("value must be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsNotZero(this BaseEstablisher<byte> establisher) {
            if (establisher.Value == 0) {
                establisher.RaiseException("value must not be zero");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>byte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsMinValue(this BaseEstablisher<byte> establisher) {
            if (establisher.Value != byte.MinValue) {
                establisher.RaiseException("value must equal byte.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>byte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsNotMinValue(this BaseEstablisher<byte> establisher) {
            if (establisher.Value == byte.MinValue) {
                establisher.RaiseException("value must not equal byte.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>byte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsMaxValue(this BaseEstablisher<byte> establisher) {
            if (establisher.Value != byte.MaxValue) {
                establisher.RaiseException("value must equal byte.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>byte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="BaseEstablisher<byte>"/></returns>
        public static BaseEstablisher<byte> IsNotMaxValue(this BaseEstablisher<byte> establisher) {
            if (establisher.Value == byte.MaxValue) {
                establisher.RaiseException("value must not equal byte.MaxValue");
            }

            return establisher;
        }

    }

}
