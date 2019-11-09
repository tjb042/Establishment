using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class EnumEstablisher
    {

        public static EstablisherBase<TEnum> HasFlag<TEnum>(this EstablisherBase<TEnum> establisher, TEnum flag) where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            if (!(establisher.Value as Enum).HasFlag(flag as Enum))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must contain flag {flag}.");
            }

            return establisher;
        }

        public static EstablisherBase<TEnum> DoesNotHaveFlag<TEnum>(this EstablisherBase<TEnum> establisher, TEnum flag) where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            if ((establisher.Value as Enum).HasFlag(flag as Enum))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not contain flag {flag}.");
            }

            return establisher;
        }

        public static EstablisherBase<TEnum> IsDefined<TEnum>(this EstablisherBase<TEnum> establisher) where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            if (!Enum.IsDefined(establisher.TType, establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be defined in current enum.");
            }

            return establisher;
        }

        public static EstablisherBase<TEnum> IsNotDefined<TEnum>(this EstablisherBase<TEnum> establisher) where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            if (Enum.IsDefined(establisher.TType, establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be defined in the current enum.");
            }

            return establisher;
        }

    }

}
