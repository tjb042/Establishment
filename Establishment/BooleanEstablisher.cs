using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class BooleanEstablisher : BaseEstablisher<bool>, IStructEstablisher<BooleanEstablisher, bool> {

        internal BooleanEstablisher(bool value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value equals <c>true</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsTrue() {
            if (!Value) {
                HandleFailure("bool value must be true");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>false</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsFalse() {
            if (Value) {
                HandleFailure("bool value must be false");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(bool)</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsDefault() {
            return base.IsDefault<BooleanEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(bool)</c>
        /// </summary>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsNotDefault() {
            return base.IsNotDefault<BooleanEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The value to compare against</param>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsEqualTo(bool constraint) {
            return base.IsEqualTo<BooleanEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The value to compare against</param>
        /// <returns>The current <see cref="BooleanEstablisher"/></returns>
        public BooleanEstablisher IsNotEqualTo(bool constraint) {
            return base.IsNotEqualTo<BooleanEstablisher>(constraint);
        }

    }

}
