using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class DateTimeEstablisher {

        private static DateTime UnixEpoch = new DateTime(1970, 1, 1);

        /// <summary>
        /// Establishes that the supplied value equals <c>DateTime.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsMinDate(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value != DateTime.MinValue) {
                establisher.RaiseException("DateTime value must be equal to DateTime.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>DateTime.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsNotMinDate(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value == DateTime.MinValue) {
                establisher.RaiseException("DateTime value must not be equal to DateTime.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>DateTime.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsMaxDate(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value != DateTime.MaxValue) {
                establisher.RaiseException("DateTime value must be equal to DateTime.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>DateTime.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsNotMaxDate(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value == DateTime.MaxValue) {
                establisher.RaiseException("DateTime value must not be equal to DateTime.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsUnixEpoch(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value != UnixEpoch) {
                establisher.RaiseException("DateTime value must be equal to UnixEpoch");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsNotUnixEpoch(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value == UnixEpoch) {
                establisher.RaiseException("DateTime value must not be equal to UnixEpoch");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs before Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsBeforeUnixEpoch(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value >= UnixEpoch) {
                establisher.RaiseException("DateTime value must occur before UnixEpoch");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs after Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsAfterUnixEpoch(this BaseEstablisher<DateTime> establisher) {
            if (establisher.Value < UnixEpoch) {
                establisher.RaiseException("DateTime value must occur after UnixEpoch");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsGreaterThan(this BaseEstablisher<DateTime> establisher, DateTime threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("DateTime value must be greater than " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsGreaterThanOrEqualTo(this BaseEstablisher<DateTime> establisher, DateTime threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("DateTime value must be greater than or equal to " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsLessThan(this BaseEstablisher<DateTime> establisher, DateTime threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("DateTime value must be less than " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsLessThanOrEqualTo(this BaseEstablisher<DateTime> establisher, DateTime threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("DateTime value must be less than or equal to " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs after <c>DateTime.Now</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsInTheFuture(this BaseEstablisher<DateTime> establisher) {
            if (DateTime.Now >= establisher.Value) {
                establisher.RaiseException("DateTime value must be a date and time in the future");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs before <c>DateTime.Now</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsInThePast(this BaseEstablisher<DateTime> establisher) {
            if (DateTime.Now <= establisher.Value) {
                establisher.RaiseException("DateTime value must be a date and time in the past");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value's <c>DayOfWeek</c> does not equal Saturday or Sunday
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsWeekday(this BaseEstablisher<DateTime> establisher) {
            switch (establisher.Value.DayOfWeek) {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    establisher.RaiseException("DateTime value must fall on a weekday");
                    break;
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value's <c>DayOfWeek</c> equals Saturday or Sunday 
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static BaseEstablisher<DateTime> IsNotWeekday(this BaseEstablisher<DateTime> establisher) {
            switch (establisher.Value.DayOfWeek) {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    establisher.RaiseException("DateTime value must not fall on a weekday"); 
                    break;
            }

            return establisher;
        }

    }

}
