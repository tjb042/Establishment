using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class SByteEstablisher : BaseEstablisher<sbyte>, IStructEstablisher<SByteEstablisher, sbyte> {

        internal SByteEstablisher(sbyte value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsGreaterThan(sbyte threshold) {
            if (Value <= threshold) {
                HandleException("sbyte value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsGreaterThanOrEqualTo(sbyte threshold) {
            if (Value < threshold) {
                HandleException("sbyte value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsLessThan(sbyte threshold) {
            if (Value >= threshold) {
                HandleException("sbyte value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsLessThanOrEqualTo(sbyte threshold) {
            if (Value > threshold) {
                HandleException("sbyte value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>sbyte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsMinValue() {
            if (Value != sbyte.MinValue) {
                HandleException("value must equal sbyte.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>sbyte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsNotMinValue() {
            if (Value == sbyte.MinValue) {
                HandleException("value must not equal sbyte.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>sbyte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsMaxValue() {
            if (Value != sbyte.MaxValue) {
                HandleException("value must equal sbyte.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>sbyte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsNotMaxValue() {
            if (Value == sbyte.MaxValue) {
                HandleException("value must not equal sbyte.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsPositive() {
            if (Value < 0) {
                HandleException("value must be greater than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to zero
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsNegative() {
            if (Value > 0) {
                HandleException("value must be less than zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(sbyte)</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public new SByteEstablisher IsDefault() {
            return base.IsDefault<SByteEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(sbyte)</c>
        /// </summary>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public new SByteEstablisher IsNotDefault() {
            return base.IsNotDefault<SByteEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsEqualTo(sbyte constraint) {
            return base.IsEqualTo<SByteEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value is not equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="SByteEstablisher"/></returns>
        public SByteEstablisher IsNotEqualTo(sbyte constraint) {
            return base.IsNotEqualTo<SByteEstablisher>(constraint);
        }

    }

}
