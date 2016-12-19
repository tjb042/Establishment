using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StringEstablisher : BaseClassEstablisher<string> {

        internal StringEstablisher(string value) : base(value) { }

        public StringEstablisher IsNullOrEmpty() {
            if (!string.IsNullOrEmpty(Value)) {
                HandleFailure(new ArgumentException("string value must be null or empty"));
            }

            return this;
        }

        public StringEstablisher IsNotNullOrEmpty() {
            if (string.IsNullOrEmpty(Value)) {
                HandleFailure(new ArgumentException("string value must not be null or empty"));
            }

            return this;
        }

        public StringEstablisher IsEmpty() {
            if (Value != string.Empty) {
                HandleFailure(new ArgumentException("string value must be empty"));
            }

            return this;
        }

        public StringEstablisher IsNotEmpty() {
            if (Value == string.Empty) {
                HandleFailure(new ArgumentException("string value must not be empty"));
            }

            return this;
        }

        public StringEstablisher HasExactLength(int length) {
            if (Value.Length != length) {
                HandleFailure(new ArgumentException(string.Concat("string value is not exactly ", length, " characters")));
            }

            return this;
        }

        public StringEstablisher HasMinimumLength(int minimumLength) {
            if (Value.Length < minimumLength) {
                HandleFailure(new ArgumentException(string.Concat("string value is not at least ", minimumLength, " characters")));
            }

            return this;
        }

        public StringEstablisher HasMaximumLength(int maximumLength) {
            if (Value.Length > maximumLength) {
                HandleFailure(new ArgumentException(string.Concat("string value is too long")));
            }

            return this;
        }

    }

}
