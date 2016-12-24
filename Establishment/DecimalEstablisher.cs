using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DecimalEstablisher : BaseEstablisher<decimal>, IStructEstablisher<DecimalEstablisher, decimal> {

        internal DecimalEstablisher(decimal value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsGreaterThan(decimal threshold) {
            if (Value <= threshold) {
                HandleException("decimal value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsGreaterThanOrEqualTo(decimal threshold) {
            if (Value < threshold) {
                HandleException("decimal value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsLessThan(decimal threshold) {
            if (Value >= threshold) {
                HandleException("decimal value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsLessThanOrEqualTo(decimal threshold) {
            if (Value > threshold) {
                HandleException("decimal value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>decimal.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsMinValue() {
            if (Value != decimal.MinValue) {
                HandleException("value must equal decimal.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>decimal.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsNotMinValue() {
            if (Value == decimal.MinValue) {
                HandleException("value must not equal decimal.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>decimal.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsMaxValue() {
            if (Value != decimal.MaxValue) {
                HandleException("value must equal decimal.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>decimal.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsNotMaxValue() {
            if (Value == decimal.MaxValue) {
                HandleException("value must not equal decimal.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsPositive() {
            if (Value < 0m) {
                HandleException("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsNegative() {
            if (Value > 0m) {
                HandleException("value must be less than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(decimal)</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public new DecimalEstablisher IsDefault() {
            return base.IsDefault<DecimalEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(decimal)</c>
        /// </summary>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public new DecimalEstablisher IsNotDefault() {
            return base.IsNotDefault<DecimalEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsEqualTo(decimal constraint) {
            return base.IsEqualTo<DecimalEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="DecimalEstablisher"/></returns>
        public DecimalEstablisher IsNotEqualTo(decimal constraint) {
            return base.IsNotEqualTo<DecimalEstablisher>(constraint);
        }

        public DecimalEstablisher Satisfies(Action<decimal> action) {
            return base.Satisfies<DecimalEstablisher>(action);
        }

        public DecimalEstablisher Satisfies(Func<decimal, bool> predicate) {
            return base.Satisfies<DecimalEstablisher>(predicate);
        }

    }

}
