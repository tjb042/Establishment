using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    /// <summary>
    /// Base establishment provider for value types
    /// </summary>
    /// <typeparam name="TType">A value type</typeparam>
    public interface IStructEstablisher<TEstablisher, TType>
        where TType : struct
        where TEstablisher : BaseEstablisher<TType> {

        TEstablisher IsDefault();

        TEstablisher IsNotDefault();

        TEstablisher IsEqualTo(TType constraint);

        TEstablisher IsNotEqualTo(TType constraint);

    }

}
