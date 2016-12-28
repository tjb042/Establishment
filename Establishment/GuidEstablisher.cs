using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class GuidEstablisher : StructEstablisher<GuidEstablisher, Guid> {

        public GuidEstablisher(Guid value) : base(value) { }

    }

}
