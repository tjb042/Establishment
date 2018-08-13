using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class ArrayTEstablisher {

        public static BaseEstablisher<T[]> HasElements<T>(this BaseEstablisher<T[]> establisher)  {
            if (establisher.Value.Length == 0) {
                establisher.RaiseException("Array must contain at least one element");
            }

            return establisher;
        }

        public static BaseEstablisher<T[]> HasNoElements<T>(this BaseEstablisher<T[]> establisher)  {
            if (establisher.Value.Length != 0) {
                establisher.RaiseException("Array must not contain any elements");
            }

            return establisher;
        }

        public static BaseEstablisher<T[]> HasMinimumLength<T>(this BaseEstablisher<T[]> establisher, int minimumElements) {
            if (establisher.Value.Length < minimumElements) {
                establisher.RaiseException(string.Concat("Array must have at least ", minimumElements, " elements"));
            }

            return establisher;
        }

        public static BaseEstablisher<T[]> HasMaximumLength<T>(this BaseEstablisher<T[]> establisher, int maximumElements) {
            if (establisher.Value.Length > maximumElements) {
                establisher.RaiseException(string.Concat("Array must not have more than ", maximumElements, " elements"));
            }

            return establisher;
        }

        public static BaseEstablisher<T[]> HasExactLength<T>(this BaseEstablisher<T[]> establisher, int totalElements) {
            if (establisher.Value.Length != totalElements) {
                establisher.RaiseException(string.Concat("Array must contain exactly ", totalElements, " elements"));
            }

            return establisher;
        }

    }

}
