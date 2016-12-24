using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ByteEstablisher : BaseEstablisher<byte>, IStructEstablisher<ByteEstablisher, byte> {

        internal ByteEstablisher(byte value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsGreaterThan(byte threshold) {
            if (Value <= threshold) {
                HandleFailure("byte value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsGreaterThanOrEqualTo(byte threshold) {
            if (Value < threshold) {
                HandleFailure("byte value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsLessThan(byte threshold) {
            if (Value >= threshold) {
                HandleFailure("byte value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsLessThanOrEqualTo(byte threshold) {
            if (Value > threshold) {
                HandleFailure("byte value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>byte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsMinValue() {
            if (Value != byte.MinValue) {
                HandleFailure("value must equal byte.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>byte.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsNotMinValue() {
            if (Value == byte.MinValue) {
                HandleFailure("value must not equal byte.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>byte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsMaxValue() {
            if (Value != byte.MaxValue) {
                HandleFailure("value must equal byte.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>byte.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsNotMaxValue() {
            if (Value == byte.MaxValue) {
                HandleFailure("value must not equal byte.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(byte)</c>
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public new ByteEstablisher IsDefault() {
            return base.IsDefault<ByteEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(byte)</c>
        /// </summary>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public new ByteEstablisher IsNotDefault() {
            return base.IsNotDefault<ByteEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The value to compare against</param>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsEqualTo(byte constraint) {
            return base.IsEqualTo<ByteEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The value to compare against</param>
        /// <returns>The current <see cref="ByteEstablisher"/></returns>
        public ByteEstablisher IsNotEqualTo(byte constraint) {
            return base.IsNotEqualTo<ByteEstablisher>(constraint);
        }

    }

}
