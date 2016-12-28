using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ValueTypeEstablisher<TType> : StructEstablisher<ValueTypeEstablisher<TType>, TType> where TType : struct {

        public ValueTypeEstablisher(TType value) : base(value) {

        }

    }

}
