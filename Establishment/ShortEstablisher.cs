using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ShortEstablisher : StructEstablisher<ShortEstablisher, short> {

        public ShortEstablisher(short value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public ShortEstablisher IsGreaterThan(short threshold) {
            if (Value <= threshold) {
                HandleException("short value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public ShortEstablisher IsGreaterThanOrEqualTo(short threshold) {
            if (Value < threshold) {
                HandleException("short value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public ShortEstablisher IsLessThan(short threshold) {
            if (Value >= threshold) {
                HandleException("short value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public ShortEstablisher IsLessThanOrEqualTo(short threshold) {
            if (Value > threshold) {
                HandleException("short value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>short.MinValue</c>
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsMinValue() {
            if (Value != short.MinValue) {
                HandleException("value must equal short.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>short.MinValue</c>
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsNotMinValue() {
            if (Value == short.MinValue) {
                HandleException("value must not equal short.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>short.MaxValue</c>
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsMaxValue() {
            if (Value != short.MaxValue) {
                HandleException("value must equal short.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>short.MaxValue</c>
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsNotMaxValue() {
            if (Value == short.MaxValue) {
                HandleException("value must not equal short.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsPositive() {
            if (Value < 0) {
                HandleException("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns></returns>
        public ShortEstablisher IsNegative() {
            if (Value > 0) {
                HandleException("value must be less than zero");
            }

            return this;
        }

    }

}
