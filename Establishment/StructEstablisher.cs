using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment
{

    public static class StructEstablisher
    {

        public static BaseEstablisher<TType> IsDefault<TType>(this BaseEstablisher<TType> establisher) where TType : struct
        {
            if (!establisher.DefaultComparer.Equals(establisher.Value, establisher.DefaultTypeValue))
            {
                establisher.RaiseException(establisher.GenericType.Name + " must equal its default value (null)");
            }

            return establisher;
        }

        public static BaseEstablisher<TType> IsNotDefault<TType>(this BaseEstablisher<TType> establisher) where TType : struct
        {
            if (establisher.DefaultComparer.Equals(establisher.Value, establisher.DefaultTypeValue))
            {
                establisher.RaiseException(establisher.GenericType.Name + " must not equal its default value (null)");
            }

            return establisher;
        }

    }

}
