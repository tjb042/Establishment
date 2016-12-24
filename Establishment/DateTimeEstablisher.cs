using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DateTimeEstablisher : BaseEstablisher<DateTime>, IStructEstablisher<DateTimeEstablisher, DateTime> {

        private static DateTime UnixEpoch = new DateTime(1970, 1, 1);

        internal DateTimeEstablisher(DateTime value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value equals <c>DateTime.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsMinDate() {
            if (Value != DateTime.MinValue) {
                HandleException("DateTime value must be equal to DateTime.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>DateTime.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsNotMinDate() {
            if (Value == DateTime.MinValue) {
                HandleException("DateTime value must not be equal to DateTime.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>DateTime.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsMaxDate() {
            if (Value != DateTime.MaxValue) {
                HandleException("DateTime value must be equal to DateTime.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>DateTime.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsNotMaxDate() {
            if (Value == DateTime.MaxValue) {
                HandleException("DateTime value must not be equal to DateTime.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsUnixEpoch() {
            if (Value != UnixEpoch) {
                HandleException("DateTime value must be equal to UnixEpoch");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsNotUnixEpoch() {
            if (Value == UnixEpoch) {
                HandleException("DateTime value must not be equal to UnixEpoch");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value occurs before Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsBeforeUnixEpoch() {
            if (Value >= UnixEpoch) {
                HandleException("DateTime value must occur before UnixEpoch");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value occurs after Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsAfterUnixEpoch() {
            if (Value < UnixEpoch) {
                HandleException("DateTime value must occur after UnixEpoch");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsGreaterThan(DateTime threshold) {
            if (Value <= threshold) {
                HandleException("DateTime value must be greater than " + threshold.ToString());
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsGreaterThanOrEqualTo(DateTime threshold) {
            if (Value < threshold) {
                HandleException("DateTime value must be greater than or equal to " + threshold.ToString());
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsLessThan(DateTime threshold) {
            if (Value >= threshold) {
                HandleException("DateTime value must be less than " + threshold.ToString());
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsLessThanOrEqualTo(DateTime threshold) {
            if (Value > threshold) {
                HandleException("DateTime value must be less than or equal to " + threshold.ToString());
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value occurs after <c>DateTime.Now</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsInTheFuture() {
            if (DateTime.Now >= Value) {
                HandleException("DateTime value must be a date and time in the future");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value occurs before <c>DateTime.Now</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsInThePast() {
            if (DateTime.Now <= Value) {
                HandleException("DateTime value must be a date and time in the past");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value's <c>DayOfWeek</c> does not equal Saturday or Sunday
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsWeekday() {
            switch (Value.DayOfWeek) {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    HandleException("DateTime value must fall on a weekday");
                    break;
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value's <c>DayOfWeek</c> equals Saturday or Sunday 
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsNotWeekday() {
            switch (Value.DayOfWeek) {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    HandleException("DateTime value must not fall on a weekday"); 
                    break;
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(DateTime)</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public new DateTimeEstablisher IsDefault() {
            return base.IsDefault<DateTimeEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(DateTime)</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public new DateTimeEstablisher IsNotDefault() {
            return base.IsNotDefault<DateTimeEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsEqualTo(DateTime constraint) {
            return base.IsEqualTo<DateTimeEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public DateTimeEstablisher IsNotEqualTo(DateTime constraint) {
            return base.IsNotEqualTo<DateTimeEstablisher>(constraint);
        }

    }

}
