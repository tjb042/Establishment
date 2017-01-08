using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Establishment {

    public static class EnumEstablisher // StructEstablisher<TEnum> where TEnum : struct, IComparable, IFormattable 
    {
        public static StructEstablisher<TEnum> HasFlag<TEnum>(this StructEstablisher<TEnum> establisher, TEnum flag) where TEnum : struct, IComparable, IFormattable  {
            if (!(establisher.Value as Enum).HasFlag(flag as Enum)) {
                establisher.RaiseException("enum must contain flag value " + flag.ToString());
            }

            return establisher;
        }

        public static StructEstablisher<TEnum> DoesNotHaveFlag<TEnum>(this StructEstablisher<TEnum> establisher, TEnum flag) where TEnum : struct, IComparable, IFormattable {
            if ((establisher.Value as Enum).HasFlag(flag as Enum)) {
                establisher.RaiseException("enum must not contain flag value " + flag.ToString());
            }

            return establisher;
        }

        public static StructEstablisher<TEnum> IsDefined<TEnum>(this StructEstablisher<TEnum> establisher) where TEnum : struct, IComparable, IFormattable {
            if (!Enum.IsDefined(establisher.GenericType, establisher.Value)) {
                establisher.RaiseException("enum value is not defined in current enum");
            }

            return establisher;
        }

        public static StructEstablisher<TEnum> IsNotDefined<TEnum>(this StructEstablisher<TEnum> establisher) where TEnum : struct, IComparable, IFormattable {
            if (Enum.IsDefined(establisher.GenericType, establisher.Value)) {
                establisher.RaiseException("enum value is defined in the current enum and should not be");
            }

            return establisher;
        }

    }

}
