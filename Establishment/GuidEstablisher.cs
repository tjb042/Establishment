using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class GuidEstablisher : BaseEstablisher<Guid>, IStructEstablisher<GuidEstablisher, Guid> {

        internal GuidEstablisher(Guid value) : base(value) { }

        public GuidEstablisher IsDefault() {
            return base.IsDefault<GuidEstablisher>();
        }

        public GuidEstablisher IsNotDefault() {
            return base.IsNotDefault<GuidEstablisher>();
        }

        public GuidEstablisher IsEqualTo(Guid constraint) {
            return base.IsEqualTo<GuidEstablisher>(constraint);
        }

        public GuidEstablisher IsNotEqualTo(Guid constraint) {
            return base.IsNotEqualTo<GuidEstablisher>(constraint);
        }

    }

}
