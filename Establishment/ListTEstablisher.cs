using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class ListTEstablisher {

        public static ClassEstablisher<List<TSource>> HasElements<TSource>(this ClassEstablisher<List<TSource>> establisher) {
            if (!establisher.Value.Any()) {
                establisher.RaiseException("List must contain at least one element");
            }

            return establisher;
        }

        public static ClassEstablisher<List<TSource>> HasNoElements<TSource>(this ClassEstablisher<List<TSource>> establisher) {
            if (establisher.Value.Any()) {
                establisher.RaiseException("List must not contain any elements");
            }

            return establisher;
        }

        public static ClassEstablisher<List<TSource>> HasMinimumLength<TSource>(this ClassEstablisher<List<TSource>> establisher, int minimumElements) {
            if (establisher.Value.Count() < minimumElements) {
                establisher.RaiseException(string.Concat("List must have at least ", minimumElements, " elements"));
            }

            return establisher;
        }

        public static ClassEstablisher<List<TSource>> HasMaximumLength<TSource>(this ClassEstablisher<List<TSource>> establisher, int maximumElements) {
            if (establisher.Value.Count() > maximumElements) {
                establisher.RaiseException(string.Concat("List must not have more than ", maximumElements, " elements"));
            }

            return establisher;
        }

        public static ClassEstablisher<List<TSource>> HasExactLength<TSource>(this ClassEstablisher<List<TSource>> establisher, int totalElements) {
            if (establisher.Value.Count() != totalElements) {
                establisher.RaiseException(string.Concat("List must contain exactly ", totalElements, " elements"));
            }

            return establisher;
        }

    }

}
