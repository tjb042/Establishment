using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class BooleanEstablisher {

        /// <summary>
        /// Establishes that the supplied value equals <c>true</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public static BaseEstablisher<bool> IsTrue(this BaseEstablisher<bool> establisher) {
            if (!establisher.Value) {
                establisher.RaiseException("bool value must be true");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>false</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public static BaseEstablisher<bool> IsFalse(this BaseEstablisher<bool> establisher) {
            if (establisher.Value) {
                establisher.RaiseException("bool value must be false");
            }

            return establisher;
        }

    }

}
