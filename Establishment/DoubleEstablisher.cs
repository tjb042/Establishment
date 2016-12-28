using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DoubleEstablisher : StructEstablisher<DoubleEstablisher, double> {

        public DoubleEstablisher(double value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsGreaterThan(double threshold) {
            if (Value <= threshold) {
                HandleException("double value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsGreaterThanOrEqualTo(double threshold) {
            if (Value < threshold) {
                HandleException("double value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsLessThan(double threshold) {
            if (Value >= threshold) {
                HandleException("double value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsLessThanOrEqualTo(double threshold) {
            if (Value > threshold) {
                HandleException("double value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>double.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsMinValue() {
            if (Value != double.MinValue) {
                HandleException("value must equal double.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>double.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotMinValue() {
            if (Value == double.MinValue) {
                HandleException("value must not equal double.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>double.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsMaxValue() {
            if (Value != double.MaxValue) {
                HandleException("value must equal double.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>double.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotMaxValue() {
            if (Value == double.MaxValue) {
                HandleException("value must not equal double.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsPositive() {
            if (Value < 0D) {
                HandleException("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNegative() {
            if (Value > 0D) {
                HandleException("value must be less than zero");
            }

            return this;
        }
        
    }

}
