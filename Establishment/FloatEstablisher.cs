using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class FloatEstablisher
    {

        public static EstablisherBase<float> IsGreaterThan(this EstablisherBase<float> establisher, float threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsGreaterThanOrEqualTo(this EstablisherBase<float> establisher, float threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsLessThan(this EstablisherBase<float> establisher, float threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsLessThanOrEqualTo(this EstablisherBase<float> establisher, float threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsZero(this EstablisherBase<float> establisher)
        {
            if (establisher.Value != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsNotZero(this EstablisherBase<float> establisher)
        {
            if (establisher.Value == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsMinValue(this EstablisherBase<float> establisher)
        {
            if (establisher.Value != float.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal float.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsNotMinValue(this EstablisherBase<float> establisher)
        {
            if (establisher.Value == float.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal float.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsMaxValue(this EstablisherBase<float> establisher)
        {
            if (establisher.Value != float.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal float.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<float> IsNotMaxValue(this EstablisherBase<float> establisher)
        {
            if (establisher.Value == float.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal float.MaxValue.");
            }

            return establisher;
        }

    }

}
