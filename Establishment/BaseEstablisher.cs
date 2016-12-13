using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    /// <summary>
    /// Base establishment provider
    /// </summary>
    /// <remarks>
    /// Adds shared <c>protected</c> functionality for all Establishment objects
    /// </remarks>
    public abstract class BaseEstablisher {

        public BaseEstablisher() {
            ThrowExceptionOnEstablishmentFailure = true;
        }

        protected bool HandleFailure(Exception ex) {
            if (ThrowExceptionOnEstablishmentFailure) {
                throw ex;
            }

            return false;
        }

        public bool ThrowExceptionOnEstablishmentFailure {
            get;
            set;
        }

    }

}
