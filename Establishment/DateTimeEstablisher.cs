using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DateTimeEstablisher : BaseEstablisher<DateTime>, IStructEstablisher<DateTimeEstablisher, DateTime> {

        private static DateTime UnixEpoch = new DateTime(1970, 1, 1);

        internal DateTimeEstablisher(DateTime value) : base(value) { }

        public DateTimeEstablisher IsMinDate() {
            if (Value != DateTime.MinValue) {
                HandleFailure("DateTime value must be equal to DateTime.MinValue");
            }

            return this;
        }

        public DateTimeEstablisher IsNotMinDate() {
            if (Value == DateTime.MinValue) {
                HandleFailure("DateTime value must not be equal to DateTime.MinValue");
            }

            return this;
        }

        public DateTimeEstablisher IsMaxDate() {
            if (Value != DateTime.MaxValue) {
                HandleFailure("DateTime value must be equal to DateTime.MaxValue");
            }

            return this;
        }

        public DateTimeEstablisher IsNotMaxDate() {
            if (Value == DateTime.MaxValue) {
                HandleFailure("DateTime value must not be equal to DateTime.MaxValue");
            }

            return this;
        }

        public DateTimeEstablisher IsUnixEpoch() {
            if (Value != UnixEpoch) {
                HandleFailure("DateTime value must be equal to UnixEpoch");
            }

            return this;
        }

        public DateTimeEstablisher IsNotUnixEpoch() {
            if (Value == UnixEpoch) {
                HandleFailure("DateTime value must not be equal to UnixEpoch");
            }

            return this;
        }

        public DateTimeEstablisher IsBeforeUnixEpoch() {
            if (Value >= UnixEpoch) {
                HandleFailure("DateTime value must occur before UnixEpoch");
            }

            return this;
        }

        public DateTimeEstablisher IsAfterUnixEpoch() {
            if (Value < UnixEpoch) {
                HandleFailure("DateTime value must occur after UnixEpoch");
            }

            return this;
        }

        public DateTimeEstablisher IsGreaterThan(DateTime threshold) {
            if (Value <= threshold) {
                HandleFailure("DateTime value must be greater than " + threshold.ToString());
            }

            return this;
        }

        public DateTimeEstablisher IsGreaterThanOrEqualTo(DateTime threshold) {
            if (Value < threshold) {
                HandleFailure("DateTime value must be greater than or equal to " + threshold.ToString());
            }

            return this;
        }

        public DateTimeEstablisher IsLessThan(DateTime threshold) {
            if (Value >= threshold) {
                HandleFailure("DateTime value must be less than " + threshold.ToString());
            }

            return this;
        }

        public DateTimeEstablisher IsLessThanOrEqualTo(DateTime threshold) {
            if (Value > threshold) {
                HandleFailure("DateTime value must be less than or equal to " + threshold.ToString());
            }

            return this;
        }

        public DateTimeEstablisher IsInTheFuture() {
            if (DateTime.Now >= Value) {
                HandleFailure("DateTime value must be a date and time in the future");
            }

            return this;
        }

        public DateTimeEstablisher IsInThePast() {
            if (DateTime.Now <= Value) {
                HandleFailure("DateTime value must be a date and time in the past");
            }

            return this;
        }

        public DateTimeEstablisher IsWeekday() {
            switch (Value.DayOfWeek) {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    HandleFailure("DateTime value must fall on a weekday");
                    break;
            }

            return this;
        }

        public DateTimeEstablisher IsNotWeekday() {
            switch (Value.DayOfWeek) {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    HandleFailure("DateTime value must not fall on a weekday"); 
                    break;
            }

            return this;
        }

        public DateTimeEstablisher IsDefault() {
            return base.IsDefault<DateTimeEstablisher>();
        }

        public DateTimeEstablisher IsNotDefault() {
            return base.IsNotDefault<DateTimeEstablisher>();
        }

        public DateTimeEstablisher IsEqualTo(DateTime constraint) {
            return base.IsEqualTo<DateTimeEstablisher>(constraint);
        }

        public DateTimeEstablisher IsNotEqualTo(DateTime constraint) {
            return base.IsNotEqualTo<DateTimeEstablisher>(constraint);
        }

    }

}
