using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class ListTEstablisher {

        public static BaseEstablisher<List<TSource>> HasElements<TSource>(this BaseEstablisher<List<TSource>> establisher) {
            if (!establisher.Value.Any()) {
                establisher.RaiseException("List must contain at least one element");
            }

            return establisher;
        }

        public static BaseEstablisher<List<TSource>> HasNoElements<TSource>(this BaseEstablisher<List<TSource>> establisher) {
            if (establisher.Value.Any()) {
                establisher.RaiseException("List must not contain any elements");
            }

            return establisher;
        }

        public static BaseEstablisher<List<TSource>> HasMinimumLength<TSource>(this BaseEstablisher<List<TSource>> establisher, int minimumElements) {
            if (establisher.Value.Count() < minimumElements) {
                establisher.RaiseException(string.Concat("List must have at least ", minimumElements, " elements"));
            }

            return establisher;
        }

        public static BaseEstablisher<List<TSource>> HasMaximumLength<TSource>(this BaseEstablisher<List<TSource>> establisher, int maximumElements) {
            if (establisher.Value.Count() > maximumElements) {
                establisher.RaiseException(string.Concat("List must not have more than ", maximumElements, " elements"));
            }

            return establisher;
        }

        public static BaseEstablisher<List<TSource>> HasExactLength<TSource>(this BaseEstablisher<List<TSource>> establisher, int totalElements) {
            if (establisher.Value.Count() != totalElements) {
                establisher.RaiseException(string.Concat("List must contain exactly ", totalElements, " elements"));
            }

            return establisher;
        }

    }

}
