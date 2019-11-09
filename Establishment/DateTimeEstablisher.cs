using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class DateTimeEstablisher
    {

        private static DateTime UnixEpoch = new DateTime(1970, 1, 1);

        public static EstablisherBase<DateTime> IsMinDate(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value != DateTime.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal DateTime.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsNotMinDate(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value == DateTime.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal DateTime.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsMaxDate(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value != DateTime.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal DateTime.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsNotMaxDate(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value == DateTime.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal DateTime.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsUnixEpoch(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value != UnixEpoch)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal UnixEpoch.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsNotUnixEpoch(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value == UnixEpoch)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal UnixEpoch.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsBeforeUnixEpoch(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value >= UnixEpoch)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must occur before UnixEpoch.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsAfterUnixEpoch(this EstablisherBase<DateTime> establisher)
        {
            if (establisher.Value < UnixEpoch)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must occur after UnixEpoch.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsGreaterThan(this EstablisherBase<DateTime> establisher, DateTime threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than " + threshold.ToString());
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsGreaterThanOrEqualTo(this EstablisherBase<DateTime> establisher, DateTime threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to " + threshold.ToString());
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsLessThan(this EstablisherBase<DateTime> establisher, DateTime threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than " + threshold.ToString());
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsLessThanOrEqualTo(this EstablisherBase<DateTime> establisher, DateTime threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to " + threshold.ToString());
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsInTheFuture(this EstablisherBase<DateTime> establisher)
        {
            if (DateTime.Now >= establisher.Value)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be a date and time in the future.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsInThePast(this EstablisherBase<DateTime> establisher)
        {
            if (DateTime.Now <= establisher.Value)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be a date and time in the past.");
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsWeekday(this EstablisherBase<DateTime> establisher)
        {
            switch (establisher.Value.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    establisher.RaiseArgumentException($"{establisher.ParameterName} must fall on a weekday.");
                    break;
            }

            return establisher;
        }

        public static EstablisherBase<DateTime> IsNotWeekday(this EstablisherBase<DateTime> establisher)
        {
            switch (establisher.Value.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    establisher.RaiseArgumentException($"{establisher.ParameterName} must not fall on a weekday.");
                    break;
            }

            return establisher;
        }

    }

}
