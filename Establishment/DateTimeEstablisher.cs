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
        public static StructEstablisher<DateTime> IsMinDate(this StructEstablisher<DateTime> establisher) {
            if (establisher.Value != DateTime.MinValue) {
                establisher.RaiseException("DateTime value must be equal to DateTime.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>DateTime.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsNotMinDate(this StructEstablisher<DateTime> establisher) {
            if (establisher.Value == DateTime.MinValue) {
                establisher.RaiseException("DateTime value must not be equal to DateTime.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>DateTime.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsMaxDate(this StructEstablisher<DateTime> establisher) {
            if (establisher.Value != DateTime.MaxValue) {
                establisher.RaiseException("DateTime value must be equal to DateTime.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>DateTime.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsNotMaxDate(this StructEstablisher<DateTime> establisher) {
            if (establisher.Value == DateTime.MaxValue) {
                establisher.RaiseException("DateTime value must not be equal to DateTime.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsUnixEpoch(this StructEstablisher<DateTime> establisher) {
            if (establisher.Value != UnixEpoch) {
                establisher.RaiseException("DateTime value must be equal to UnixEpoch");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsNotUnixEpoch(this StructEstablisher<DateTime> establisher) {
            if (establisher.Value == UnixEpoch) {
                establisher.RaiseException("DateTime value must not be equal to UnixEpoch");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs before Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsBeforeUnixEpoch(this StructEstablisher<DateTime> establisher) {
            if (establisher.Value >= UnixEpoch) {
                establisher.RaiseException("DateTime value must occur before UnixEpoch");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs after Unix epoch
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsAfterUnixEpoch(this StructEstablisher<DateTime> establisher) {
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
        public static StructEstablisher<DateTime> IsGreaterThan(this StructEstablisher<DateTime> establisher, DateTime threshold) {
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
        public static StructEstablisher<DateTime> IsGreaterThanOrEqualTo(this StructEstablisher<DateTime> establisher, DateTime threshold) {
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
        public static StructEstablisher<DateTime> IsLessThan(this StructEstablisher<DateTime> establisher, DateTime threshold) {
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
        public static StructEstablisher<DateTime> IsLessThanOrEqualTo(this StructEstablisher<DateTime> establisher, DateTime threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("DateTime value must be less than or equal to " + threshold.ToString());
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs after <c>DateTime.Now</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsInTheFuture(this StructEstablisher<DateTime> establisher) {
            if (DateTime.Now >= establisher.Value) {
                establisher.RaiseException("DateTime value must be a date and time in the future");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value occurs before <c>DateTime.Now</c>
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsInThePast(this StructEstablisher<DateTime> establisher) {
            if (DateTime.Now <= establisher.Value) {
                establisher.RaiseException("DateTime value must be a date and time in the past");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value's <c>DayOfWeek</c> does not equal Saturday or Sunday
        /// </summary>
        /// <returns>The current <see cref="DateTimeEstablisher"/></returns>
        public static StructEstablisher<DateTime> IsWeekday(this StructEstablisher<DateTime> establisher) {
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
        public static StructEstablisher<DateTime> IsNotWeekday(this StructEstablisher<DateTime> establisher) {
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
