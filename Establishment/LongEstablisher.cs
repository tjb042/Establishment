using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class LongEstablisher : StructEstablisher<LongEstablisher, long> {

        public LongEstablisher(long value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsGreaterThan(long threshold) {
            if (Value <= threshold) {
                HandleException("long value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsGreaterThanOrEqualTo(long threshold) {
            if (Value < threshold) {
                HandleException("long value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsLessThan(long threshold) {
            if (Value >= threshold) {
                HandleException("long value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsLessThanOrEqualTo(long threshold) {
            if (Value > threshold) {
                HandleException("long value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>long.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsMinValue() {
            if (Value != long.MinValue) {
                HandleException("value must equal long.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>long.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsNotMinValue() {
            if (Value == long.MinValue) {
                HandleException("value must not equal long.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>long.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsMaxValue() {
            if (Value != long.MaxValue) {
                HandleException("value must equal long.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>long.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsNotMaxValue() {
            if (Value == long.MaxValue) {
                HandleException("value must not equal long.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsPositive() {
            if (Value < 0L) {
                HandleException("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="LongEstablisher"/></returns>
        public LongEstablisher IsNegative() {
            if (Value > 0L) {
                HandleException("value must be less than zero");
            }

            return this;
        }

    }

}
