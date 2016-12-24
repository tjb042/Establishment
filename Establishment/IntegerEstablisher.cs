using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class IntegerEstablisher : BaseEstablisher<int>, IStructEstablisher<IntegerEstablisher, int> {

        internal IntegerEstablisher(int value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsGreaterThan(int threshold) {
            if (Value <= threshold) {
                HandleFailure("int value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
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
                HandleFailure("int value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
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
                HandleFailure("int value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
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
                HandleFailure("int value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsMinValue() {
            if (Value != int.MinValue) {
                HandleFailure("value must equal int.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNotMinValue() {
            if (Value == int.MinValue) {
                HandleFailure("value must not equal int.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsMaxValue() {
            if (Value != int.MaxValue) {
                HandleFailure("value must equal int.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>int.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNotMaxValue() {
            if (Value == int.MaxValue) {
                HandleFailure("value must not equal int.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsPositive() {
            if (Value < 0) {
                HandleFailure("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNegative() {
            if (Value > 0) {
                HandleFailure("value must be less than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(int)</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public new IntegerEstablisher IsDefault() {
            return base.IsDefault<IntegerEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(int)</c>
        /// </summary>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public new IntegerEstablisher IsNotDefault() {
            return base.IsNotDefault<IntegerEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsEqualTo(int constraint) {
            return base.IsEqualTo<IntegerEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="IntegerEstablisher"/></returns>
        public IntegerEstablisher IsNotEqualTo(int constraint) {
            return base.IsNotEqualTo<IntegerEstablisher>(constraint);
        }

    }

}
