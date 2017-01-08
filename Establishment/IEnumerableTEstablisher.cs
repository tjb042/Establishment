using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class IEnumerableTEstablisher {

        public static ClassEstablisher<IEnumerable<TSource>> HasElements<TSource>(this ClassEstablisher<IEnumerable<TSource>> establisher) {
            if (!establisher.Value.Any()) {
                establisher.RaiseException("IEnumerable must contain at least one element");
            }

            return establisher;
        }

        public static ClassEstablisher<IEnumerable<TSource>> HasNoElements<TSource>(this ClassEstablisher<IEnumerable<TSource>> establisher) {
            if (establisher.Value.Any()) {
                establisher.RaiseException("IEnumerable must not contain any elements");
            }

            return establisher;
        }

        public static ClassEstablisher<IEnumerable<TSource>> HasMinimumLength<TSource>(this ClassEstablisher<IEnumerable<TSource>> establisher, int minimumElements) {
            if (establisher.Value.Count() < minimumElements) {
                establisher.RaiseException(string.Concat("IEnumerable must have at least ", minimumElements, " elements"));
            }

            return establisher;
        }

        public static ClassEstablisher<IEnumerable<TSource>> HasMaximumLength<TSource>(this ClassEstablisher<IEnumerable<TSource>> establisher, int maximumElements) {
            if (establisher.Value.Count() > maximumElements) {
                establisher.RaiseException(string.Concat("IEnumerable must not have more than ", maximumElements, " elements"));
            }

            return establisher;
        }

        public static ClassEstablisher<IEnumerable<TSource>> HasExactLength<TSource>(this ClassEstablisher<IEnumerable<TSource>> establisher, int totalElements) {
            if (establisher.Value.Count() != totalElements) {
                establisher.RaiseException(string.Concat("IEnumerable must contain exactly ", totalElements, " elements"));
            }

            return establisher;
        }

    }

}
