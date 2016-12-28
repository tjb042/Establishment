using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class BooleanEstablisher : StructEstablisher<BooleanEstablisher, bool> {

        public BooleanEstablisher(bool value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value equals <c>true</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsTrue() {
            if (!Value) {
                HandleException("bool value must be true");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>false</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsFalse() {
            if (Value) {
                HandleException("bool value must be false");
            }

            return this;
        }

    }

}
