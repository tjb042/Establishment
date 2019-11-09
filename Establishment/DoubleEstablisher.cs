using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class DoubleEstablisher
    {

        public static EstablisherBase<double> IsGreaterThan(this EstablisherBase<double> establisher, double threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsGreaterThanOrEqualTo(this EstablisherBase<double> establisher, double threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsLessThan(this EstablisherBase<double> establisher, double threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsLessThanOrEqualTo(this EstablisherBase<double> establisher, double threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsZero(this EstablisherBase<double> establisher)
        {
            if (establisher.Value != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsNotZero(this EstablisherBase<double> establisher)
        {
            if (establisher.Value == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsMinValue(this EstablisherBase<double> establisher)
        {
            if (establisher.Value != double.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal double.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsNotMinValue(this EstablisherBase<double> establisher)
        {
            if (establisher.Value == double.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal double.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsMaxValue(this EstablisherBase<double> establisher)
        {
            if (establisher.Value != double.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal double.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<double> IsNotMaxValue(this EstablisherBase<double> establisher)
        {
            if (establisher.Value == double.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal double.MaxValue.");
            }

            return establisher;
        }

    }

}
