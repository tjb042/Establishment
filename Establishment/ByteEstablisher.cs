using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class ByteEstablisher
    {

        public static EstablisherBase<byte> IsGreaterThan(this EstablisherBase<byte> establisher, byte threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsGreaterThanOrEqualTo(this EstablisherBase<byte> establisher, byte threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsLessThan(this EstablisherBase<byte> establisher, byte threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsLessThanOrEqualTo(this EstablisherBase<byte> establisher, byte threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsZero(this EstablisherBase<byte> establisher)
        {
            if (establisher.Value != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsNotZero(this EstablisherBase<byte> establisher)
        {
            if (establisher.Value == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsMinValue(this EstablisherBase<byte> establisher)
        {
            if (establisher.Value != byte.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal byte.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsNotMinValue(this EstablisherBase<byte> establisher)
        {
            if (establisher.Value == byte.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal byte.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsMaxValue(this EstablisherBase<byte> establisher)
        {
            if (establisher.Value != byte.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal byte.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<byte> IsNotMaxValue(this EstablisherBase<byte> establisher)
        {
            if (establisher.Value == byte.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal byte.MaxValue.");
            }

            return establisher;
        }

    }

}
