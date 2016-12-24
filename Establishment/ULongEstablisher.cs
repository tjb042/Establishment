using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class ULongEstablisher : BaseEstablisher<ulong>, IStructEstablisher<ULongEstablisher, ulong> {

        internal ULongEstablisher(ulong value) : base(value) {
            
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsGreaterThan(ulong threshold) {
            if (Value <= threshold) {
                HandleFailure("ulong value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsGreaterThanOrEqualTo(ulong threshold) {
            if (Value < threshold) {
                HandleFailure("ulong value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsLessThan(ulong threshold) {
            if (Value >= threshold) {
                HandleFailure("ulong value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsLessThanOrEqualTo(ulong threshold) {
            if (Value > threshold) {
                HandleFailure("ulong value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ulong.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsMinValue() {
            if (Value != ulong.MinValue) {
                HandleFailure("value must equal ulong.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ulong.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsNotMinValue() {
            if (Value == ulong.MinValue) {
                HandleFailure("value must not equal ulong.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ulong.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsMaxValue() {
            if (Value != ulong.MaxValue) {
                HandleFailure("value must equal ulong.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ulong.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsNotMaxValue() {
            if (Value == ulong.MaxValue) {
                HandleFailure("value must not equal ulong.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(ulong)</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public new ULongEstablisher IsDefault() {
            return base.IsDefault<ULongEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(ulong)</c>
        /// </summary>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public new ULongEstablisher IsNotDefault() {
            return base.IsNotDefault<ULongEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsEqualTo(ulong constraint) {
            return base.IsEqualTo<ULongEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="ULongEstablisher"/></returns>
        public ULongEstablisher IsNotEqualTo(ulong constraint) {
            return base.IsNotEqualTo<ULongEstablisher>(constraint);
        }

    }

}
