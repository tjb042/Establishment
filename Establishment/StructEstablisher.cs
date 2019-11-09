using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class StructEstablisher
    {

        public static EstablisherBase<T> IsDefault<T>(this EstablisherBase<T> establisher) where T : struct
        {
            if (!establisher.DefaultComparer.Equals(establisher.Value, establisher.TDefault))
            {
                // does not equal null
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal default(T).");
            }

            return establisher;
        }

        public static EstablisherBase<T> IsNotDefault<T>(this EstablisherBase<T> establisher) where T : struct
        {
            if (establisher.DefaultComparer.Equals(establisher.Value, establisher.TDefault))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal default(T).");
            }

            return establisher;

        }

    }

}
