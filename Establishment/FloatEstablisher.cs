using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class FloatEstablisher : BaseEstablisher<float>, IStructEstablisher<FloatEstablisher, float> {

        internal FloatEstablisher(float value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsGreaterThan(float threshold) {
            if (Value <= threshold) {
                HandleException("float value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsGreaterThanOrEqualTo(float threshold) {
            if (Value < threshold) {
                HandleException("float value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsLessThan(float threshold) {
            if (Value >= threshold) {
                HandleException("float value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsLessThanOrEqualTo(float threshold) {
            if (Value > threshold) {
                HandleException("float value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>float.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsMinValue() {
            if (Value != float.MinValue) {
                HandleException("value must equal float.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>float.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsNotMinValue() {
            if (Value == float.MinValue) {
                HandleException("value must not equal float.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>float.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsMaxValue() {
            if (Value != float.MaxValue) {
                HandleException("value must equal float.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>float.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsNotMaxValue() {
            if (Value == float.MaxValue) {
                HandleException("value must not equal float.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsPositive() {
            if (Value < 0f) {
                HandleException("value must be greater than zero");
            }

            return this;
        }

        //Establishes that the supplied value is less than or equal to zero
        public FloatEstablisher IsNegative() {
            if (Value > 0f) {
                HandleException("value must be less than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(float)</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsDefault() {
            return base.IsDefault<FloatEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(float)</c>
        /// </summary>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsNotDefault() {
            return base.IsNotDefault<FloatEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsEqualTo(float constraint) {
            return base.IsEqualTo<FloatEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="FloatEstablisher"/></returns>
        public FloatEstablisher IsNotEqualTo(float constraint) {
            return base.IsNotEqualTo<FloatEstablisher>(constraint);
        }

        public FloatEstablisher Satisfies(Action<float> action) {
            return base.Satisfies<FloatEstablisher>(action);
        }

        public FloatEstablisher Satisfies(Func<float, bool> predicate) {
            return base.Satisfies<FloatEstablisher>(predicate);
        }

    }

}
