using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class IntegerEstablisher : StructEstablisher<IntegerEstablisher, int> {

        public IntegerEstablisher(int value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsGreaterThan(int threshold) {
            if (Value <= threshold) {
                HandleException("int value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsGreaterThanOrEqualTo(int threshold) {
            if (Value < threshold) {
                HandleException("int value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsLessThan(int threshold) {
            if (Value >= threshold) {
                HandleException("int value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsLessThanOrEqualTo(int threshold) {
            if (Value > threshold) {
                HandleException("int value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsMinValue() {
            if (Value != int.MinValue) {
                HandleException("value must equal int.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNotMinValue() {
            if (Value == int.MinValue) {
                HandleException("value must not equal int.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsMaxValue() {
            if (Value != int.MaxValue) {
                HandleException("value must equal int.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNotMaxValue() {
            if (Value == int.MaxValue) {
                HandleException("value must not equal int.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsPositive() {
            if (Value < 0) {
                HandleException("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNegative() {
            if (Value > 0) {
                HandleException("value must be less than zero");
            }

            return this;
        }

    }

}
