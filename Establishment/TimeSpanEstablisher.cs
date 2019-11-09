using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class TimeSpanEstablisher
    {

        public static EstablisherBase<TimeSpan> IsZero(this EstablisherBase<TimeSpan> establisher)
        {
            if (establisher.Value.Ticks != TimeSpan.Zero.Ticks)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsNotZero(this EstablisherBase<TimeSpan> establisher)
        {
            if (establisher.Value.Ticks == TimeSpan.Zero.Ticks)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsMaxSpan(this EstablisherBase<TimeSpan> establisher)
        {
            if (establisher.Value.Ticks != TimeSpan.MaxValue.Ticks)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal TimeSpan.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsNotMaxSpan(this EstablisherBase<TimeSpan> establisher)
        {
            if (establisher.Value.Ticks == TimeSpan.MaxValue.Ticks)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal TimeSpan.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsMinSpan(this EstablisherBase<TimeSpan> establisher)
        {
            if (establisher.Value.Ticks != TimeSpan.MinValue.Ticks)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal TimeSpan.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsNotMinSpan(this EstablisherBase<TimeSpan> establisher)
        {
            if (establisher.Value.Ticks == TimeSpan.MinValue.Ticks)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal TimeSpan.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsGreaterThan(this EstablisherBase<TimeSpan> establisher, TimeSpan threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsGreaterThanOrEqualTo(this EstablisherBase<TimeSpan> establisher, TimeSpan threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsLessThan(this EstablisherBase<TimeSpan> establisher, TimeSpan threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<TimeSpan> IsLessThanOrEqualTo(this EstablisherBase<TimeSpan> establisher, TimeSpan threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

    }

}
