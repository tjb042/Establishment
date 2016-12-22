using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DoubleEstablisher : BaseEstablisher<double>, IStructEstablisher<DoubleEstablisher, double> {

        public DoubleEstablisher(double value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsGreaterThan(double threshold) {
            if (Value <= threshold) {
                HandleFailure("double value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
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
                HandleFailure("double value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
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
                HandleFailure("double value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
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
                HandleFailure("double value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>double.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsMinValue() {
            if (Value != double.MinValue) {
                HandleFailure("value must equal double.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>double.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotMinValue() {
            if (Value == double.MinValue) {
                HandleFailure("value must not equal double.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>double.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsMaxValue() {
            if (Value != double.MaxValue) {
                HandleFailure("value must equal double.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>double.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotMaxValue() {
            if (Value == double.MaxValue) {
                HandleFailure("value must not equal double.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsPositive() {
            if (Value < 0D) {
                HandleFailure("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNegative() {
            if (Value > 0D) {
                HandleFailure("value must be less than zero");
            }

            return this;
        }
        
        /// <summary>
        /// Establishes that the supplied value equals <c>default(double)</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsDefault() {
            return base.IsDefault<DoubleEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(double)</c>
        /// </summary>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotDefault() {
            return base.IsNotDefault<DoubleEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsEqualTo(double constraint) {
            return base.IsEqualTo<DoubleEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="DoubleEstablisher"/></returns>
        public DoubleEstablisher IsNotEqualTo(double constraint) {
            return base.IsNotEqualTo<DoubleEstablisher>(constraint);
        }

    }

}
