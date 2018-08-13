using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class DictionaryEstablisher {

        public static BaseEstablisher<Dictionary<TKey, TValue>> HasElements<TKey, TValue>(this BaseEstablisher<Dictionary<TKey, TValue>> establisher) {
            if (!establisher.Value.Any()) {
                establisher.RaiseException("Dictionary must contain at least one element");
            }

            return establisher;
        }

        public static BaseEstablisher<Dictionary<TKey, TValue>> HasNoElements<TKey, TValue>(this BaseEstablisher<Dictionary<TKey, TValue>> establisher) {
            if (establisher.Value.Any()) {
                establisher.RaiseException("Dictionary must not contain any elements");
            }

            return establisher;
        }

        public static BaseEstablisher<Dictionary<TKey, TValue>> HasMinimumLength<TKey, TValue>(this BaseEstablisher<Dictionary<TKey, TValue>> establisher, int minimumElements) {
            if (establisher.Value.Count() < minimumElements) {
                establisher.RaiseException(string.Concat("Dictionary must have at least ", minimumElements, " elements"));
            }

            return establisher;
        }

        public static BaseEstablisher<Dictionary<TKey, TValue>> HasMaximumLength<TKey, TValue>(this BaseEstablisher<Dictionary<TKey, TValue>> establisher, int maximumElements) {
            if (establisher.Value.Count() > maximumElements) {
                establisher.RaiseException(string.Concat("Dictionary must not have more than ", maximumElements, " elements"));
            }

            return establisher;
        }

        public static BaseEstablisher<Dictionary<TKey, TValue>> HasExactLength<TKey, TValue>(this BaseEstablisher<Dictionary<TKey, TValue>> establisher, int totalElements) {
            if (establisher.Value.Count() != totalElements) {
                establisher.RaiseException(string.Concat("Dictionary must contain exactly ", totalElements, " elements"));
            }

            return establisher;
        }

    }

}
