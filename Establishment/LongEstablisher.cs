﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class LongEstablisher
    {

        public static EstablisherBase<long> IsGreaterThan(this EstablisherBase<long> establisher, long threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsGreaterThanOrEqualTo(this EstablisherBase<long> establisher, long threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsLessThan(this EstablisherBase<long> establisher, long threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsLessThanOrEqualTo(this EstablisherBase<long> establisher, long threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsZero(this EstablisherBase<long> establisher)
        {
            if (establisher.Value != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsNotZero(this EstablisherBase<long> establisher)
        {
            if (establisher.Value == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsMinValue(this EstablisherBase<long> establisher)
        {
            if (establisher.Value != long.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal long.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsNotMinValue(this EstablisherBase<long> establisher)
        {
            if (establisher.Value == long.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal long.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsMaxValue(this EstablisherBase<long> establisher)
        {
            if (establisher.Value != long.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal long.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<long> IsNotMaxValue(this EstablisherBase<long> establisher)
        {
            if (establisher.Value == long.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal long.MaxValue.");
            }

            return establisher;
        }

    }

}
