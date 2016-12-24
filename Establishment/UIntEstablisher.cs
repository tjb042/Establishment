using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class UIntegerEstablisher : BaseEstablisher<uint>, IStructEstablisher<UIntegerEstablisher, uint> {

        internal UIntegerEstablisher(uint value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsGreaterThan(uint threshold) {
            if (Value <= threshold) {
                HandleException("uint value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsGreaterThanOrEqualTo(uint threshold) {
            if (Value < threshold) {
                HandleException("uint value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsLessThan(uint threshold) {
            if (Value >= threshold) {
                HandleException("uint value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsLessThanOrEqualTo(uint threshold) {
            if (Value > threshold) {
                HandleException("uint value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>uint.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsMinValue() {
            if (Value != uint.MinValue) {
                HandleException("value must equal uint.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>uint.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsNotMinValue() {
            if (Value == uint.MinValue) {
                HandleException("value must not equal uint.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>uint.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsMaxValue() {
            if (Value != uint.MaxValue) {
                HandleException("value must equal uint.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>uint.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsNotMaxValue() {
            if (Value == uint.MaxValue) {
                HandleException("value must not equal uint.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(uint)</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsDefault() {
            return base.IsDefault<UIntegerEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(uint)</c>
        /// </summary>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsNotDefault() {
            return base.IsNotDefault<UIntegerEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsEqualTo(uint constraint) {
            return base.IsEqualTo<UIntegerEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="UIntegerEstablisher"/></returns>
        public UIntegerEstablisher IsNotEqualTo(uint constraint) {
            return base.IsNotEqualTo<UIntegerEstablisher>(constraint);
        }

        public UIntegerEstablisher Satisfies(Action<uint> action) {
            return base.Satisfies<UIntegerEstablisher>(action);
        }

        public UIntegerEstablisher Satisfies(Func<uint, bool> predicate) {
            return base.Satisfies<UIntegerEstablisher>(predicate);
        }

    }

}
