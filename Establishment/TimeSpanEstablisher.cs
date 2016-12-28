﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class TimeSpanEstablisher : StructEstablisher<TimeSpanEstablisher, TimeSpan> {

        public TimeSpanEstablisher(TimeSpan value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.Zero</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsZero() {
            if (Value.Ticks != TimeSpan.Zero.Ticks) {
                HandleException("TimeSpan must equal zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.Zero</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsNotZero() {
            if (Value.Ticks == TimeSpan.Zero.Ticks) {
                HandleException("TimeSpan must not equal zero");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsMaxSpan() {
            if (Value.Ticks != TimeSpan.MaxValue.Ticks) {
                HandleException("TimeSpan must equal TimeSpan.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsNotMaxSpan() {
            if (Value.Ticks == TimeSpan.MaxValue.Ticks) {
                HandleException("TimeSpan must not equal TimeSpan.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>TimeSpan.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsMinSpan() {
            if (Value.Ticks != TimeSpan.MinValue.Ticks) {
                HandleException("TimeSpan must equal TimeSpan.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>TimeSpan.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsNotMinSpan() {
            if (Value.Ticks == TimeSpan.MinValue.Ticks) {
                HandleException("TimeSpan must not equal TimeSpan.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsGreaterThan(TimeSpan threshold) {
            if (Value <= threshold) {
                HandleException("TimeSpan value must be greater than " + threshold.ToString());
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsGreaterThanOrEqualTo(TimeSpan threshold) {
            if (Value < threshold) {
                HandleException("TimeSpan value must be greater than or equal to " + threshold.ToString());
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsLessThan(TimeSpan threshold) {
            if (Value >= threshold) {
                HandleException("TimeSpan value must be less than " + threshold.ToString());
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsLessThanOrEqualTo(TimeSpan threshold) {
            if (Value > threshold) {
                HandleException("TimeSpan value must be less than or equal to " + threshold.ToString());
            }

            return this;
        }

    }

}
