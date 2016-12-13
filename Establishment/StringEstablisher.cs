using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StringEstablisher : BaseClassEstablisher<string> {

        public bool IsNullOrEmpty(string value) {
            if (!string.IsNullOrEmpty(value)) {
                return HandleFailure(new ArgumentException("string value must be null or empty"));
            }

            return true;
        }

        public bool IsNotNullOrEmpty(string value) {
            if (string.IsNullOrEmpty(value)) {
                return HandleFailure(new ArgumentException("string value must not be null or empty"));
            }

            return true;
        }

        public bool IsEmpty(string value) {
            if (value != string.Empty) {
                return HandleFailure(new ArgumentException("string value must be empty"));
            }

            return true;
        }

        public bool IsNotEmpty(string value) {
            if (value == string.Empty) {
                return HandleFailure(new ArgumentException("string value must not be empty"));
            }

            return true;
        }

        public bool HasExactLength(string value, int length) {
            if (value.Length != length) {
                return HandleFailure(new ArgumentException(string.Concat("string value is not exactly ", length, " characters")));
            }

            return true;
        }

        public bool HasMinimumLength(string value, int minimumLength) {
            if (value.Length < minimumLength) {
                return HandleFailure(new ArgumentException(string.Concat("string value is not at least ", minimumLength, " characters")));
            }

            return true;
        }

        public bool HasMaximumLength(string value, int maximumLength) {
            if (value.Length > maximumLength) {
                return HandleFailure(new ArgumentException(string.Concat("string value is too long")));
            }

            return true;
        }

    }

}
