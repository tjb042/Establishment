using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class ShortEstablisher
    {

        public static EstablisherBase<short> IsGreaterThan(this EstablisherBase<short> establisher, short threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsGreaterThanOrEqualTo(this EstablisherBase<short> establisher, short threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsLessThan(this EstablisherBase<short> establisher, short threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsLessThanOrEqualTo(this EstablisherBase<short> establisher, short threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsZero(this EstablisherBase<short> establisher)
        {
            if (establisher.Value != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsNotZero(this EstablisherBase<short> establisher)
        {
            if (establisher.Value == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsMinValue(this EstablisherBase<short> establisher)
        {
            if (establisher.Value != short.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal short.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsNotMinValue(this EstablisherBase<short> establisher)
        {
            if (establisher.Value == short.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal short.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsMaxValue(this EstablisherBase<short> establisher)
        {
            if (establisher.Value != short.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal short.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<short> IsNotMaxValue(this EstablisherBase<short> establisher)
        {
            if (establisher.Value == short.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal short.MaxValue.");
            }

            return establisher;
        }

    }

}
