using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class BooleanEstablisher
    {

        public static EstablisherBase<bool> IsTrue(this EstablisherBase<bool> establisher)
        {
            if (!establisher.Value)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal True.");
            }

            return establisher;
        }

        public static EstablisherBase<bool> IsFalse(this EstablisherBase<bool> establisher)
        {
            if (establisher.Value)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal False.");
            }

            return establisher;
        }

    }

}
