using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class IntEstablisher
    {

        public static EstablisherBase<int> IsGreaterThan(this EstablisherBase<int> establisher, int threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsGreaterThanOrEqualTo(this EstablisherBase<int> establisher, int threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsLessThan(this EstablisherBase<int> establisher, int threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsLessThanOrEqualTo(this EstablisherBase<int> establisher, int threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsZero(this EstablisherBase<int> establisher)
        {
            if (establisher.Value != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsNotZero(this EstablisherBase<int> establisher)
        {
            if (establisher.Value == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsMinValue(this EstablisherBase<int> establisher)
        {
            if (establisher.Value != int.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal int.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsNotMinValue(this EstablisherBase<int> establisher)
        {
            if (establisher.Value == int.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal int.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsMaxValue(this EstablisherBase<int> establisher)
        {
            if (establisher.Value != int.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal int.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<int> IsNotMaxValue(this EstablisherBase<int> establisher)
        {
            if (establisher.Value == int.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal int.MaxValue.");
            }

            return establisher;
        }

    }

}
