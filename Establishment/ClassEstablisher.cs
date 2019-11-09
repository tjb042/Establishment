using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class ClassEstablisher
    {

        public static EstablisherBase<T> IsNull<T>(this EstablisherBase<T> establisher) where T : class
        {
            if (!establisher.DefaultComparer.Equals(establisher.Value, establisher.TDefault))
            {
                // does not equal null
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal null.");
            }

            return establisher;
        }

        public static EstablisherBase<T> IsNotNull<T>(this EstablisherBase<T> establisher) where T : class
        {
            if (establisher.DefaultComparer.Equals(establisher.Value, establisher.TDefault))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal null.");
            }

            return establisher;

        }

    }

}
