using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    [CLSCompliant(false)]
    public class UShortEstablisher : StructEstablisher<UShortEstablisher, ushort> {

        public UShortEstablisher(ushort value) : base(value) {
            
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsGreaterThan(ushort threshold) {
            if (Value <= threshold) {
                HandleException("ushort value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsGreaterThanOrEqualTo(ushort threshold) {
            if (Value < threshold) {
                HandleException("ushort value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }
        
        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsLessThan(ushort threshold) {
            if (Value >= threshold) {
                HandleException("ushort value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsLessThanOrEqualTo(ushort threshold) {
            if (Value > threshold) {
                HandleException("ushort value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals zero
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsZero() {
            if (Value != 0) {
                HandleException("value must be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal zero
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsNotZero() {
            if (Value == 0) {
                HandleException("value must not be zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ushort.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsMinValue() {
            if (Value != ushort.MinValue) {
                HandleException("value must equal ushort.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ushort.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsNotMinValue() {
            if (Value == ushort.MinValue) {
                HandleException("value must not equal ushort.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>ushort.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsMaxValue() {
            if (Value != ushort.MaxValue) {
                HandleException("value must equal ushort.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>ushort.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="UShortEstablisher"/></returns>
        public UShortEstablisher IsNotMaxValue() {
            if (Value == ushort.MaxValue) {
                HandleException("value must not equal ushort.MaxValue");
            }

            return this;
        }

    }

}
