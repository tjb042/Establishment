using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    /// <summary>
    /// Base establishment provider for reference types
    /// </summary>
    /// <typeparam name="TType">A reference type</typeparam>
    public interface IClassEstablisher<TEstablisher, TType> 
        where TType : class
        where TEstablisher : BaseEstablisher<TType> {

        
        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is <c>null</c>
        /// </summary>
        /// <returns><c>true</c> if <paramref name="value"/> is null; otherwise, <c>false</c></returns>
        TEstablisher IsNull();

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not <c>null</c>
        /// </summary>
        /// <returns><c>true</c> if <paramref name="value"/> is not null; otherwise, <c>false</c></returns>
        TEstablisher IsNotNull();

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> equals <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        TEstablisher IsEqualTo(TType constraint);

        /// <summary>
        /// Establishes whether or not <paramref name="value"/> is not equal to <paramref name="constraint"/>
        /// </summary>
        /// <param name="constraint">The target value for comparison</param>
        /// <returns><c>true</c> if <paramref name="value"/> does not equal <paramref name="constraint"/>; otherwise, <c>false</c></returns>
        TEstablisher IsNotEqualTo(TType constraint);

        TEstablisher Satisfies(Action<TType> action);

        TEstablisher Satisfies(Func<TType, bool> predicate);

    }

}
