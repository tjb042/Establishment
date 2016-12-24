using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class GuidEstablisher : BaseEstablisher<Guid>, IStructEstablisher<GuidEstablisher, Guid> {

        internal GuidEstablisher(Guid value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value equals <c>default(Guid)</c>
        /// </summary>
        /// <returns>The current <see cref="GuidEstablisher"/></returns>
        public GuidEstablisher IsDefault() {
            return base.IsDefault<GuidEstablisher>();
        }
        
        /// <summary>
        /// Establishes that the supplied value does not equal <c>default(Guid)</c>
        /// </summary>
        /// <returns>The current <see cref="GuidEstablisher"/></returns>
        public GuidEstablisher IsNotDefault() {
            return base.IsNotDefault<GuidEstablisher>();
        }

        /// <summary>
        /// Establishes that the supplied value equals <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="GuidEstablisher"/></returns>
        public GuidEstablisher IsEqualTo(Guid constraint) {
            return base.IsEqualTo<GuidEstablisher>(constraint);
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns>The current <see cref="GuidEstablisher"/></returns>
        public GuidEstablisher IsNotEqualTo(Guid constraint) {
            return base.IsNotEqualTo<GuidEstablisher>(constraint);
        }

        public GuidEstablisher Satisfies(Action<Guid> action) {
            return base.Satisfies<GuidEstablisher>(action);
        }

        public GuidEstablisher Satisfies(Func<Guid, bool> predicate) {
            return base.Satisfies<GuidEstablisher>(predicate);
        }

    }

}
