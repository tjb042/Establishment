using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class TimeSpanEstablisher : BaseEstablisher<TimeSpan>, IStructEstablisher<TimeSpanEstablisher, TimeSpan> {

        internal TimeSpanEstablisher(TimeSpan value) : base(value) { }

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

        /// <summary>
        /// Establishes that the supplied value equals <c>default(TimeSpan)</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsDefault() {
            return base.IsDefault<TimeSpanEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(TimeSpan)</c>
        /// </summary>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsNotDefault() {
            return base.IsNotDefault<TimeSpanEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsEqualTo(TimeSpan constraint) {
            return base.IsEqualTo<TimeSpanEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="TimeSpanEstablisher"/></returns>
        public TimeSpanEstablisher IsNotEqualTo(TimeSpan constraint) {
            return base.IsNotEqualTo<TimeSpanEstablisher>(constraint);
        }

        public TimeSpanEstablisher Satisfies(Action<TimeSpan> action) {
            return base.Satisfies<TimeSpanEstablisher>(action);
        }

        public TimeSpanEstablisher Satisfies(Func<TimeSpan, bool> predicate) {
            return base.Satisfies<TimeSpanEstablisher>(predicate);
        }

    }

}
