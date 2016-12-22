﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StringEstablisher : BaseEstablisher<string>, IClassEstablisher<StringEstablisher, string> {

        internal StringEstablisher(string value) : base(value) { }

        public StringEstablisher IsNullOrEmpty() {
            if (!string.IsNullOrEmpty(Value)) {
                HandleFailure("string value must be null or empty");
            }

            return this;
        }

        public StringEstablisher IsNotNullOrEmpty() {
            if (string.IsNullOrEmpty(Value)) {
                HandleFailure("string value must not be null or empty");
            }

            return this;
        }

        public StringEstablisher IsEmpty() {
            if (Value.Length != 0) {
                HandleFailure("string value must be empty");
            }

            return this;
        }

        public StringEstablisher IsNotEmpty() {
            if (Value.Length == 0) {
                HandleFailure("string value must not be empty");
            }

            return this;
        }

        public StringEstablisher HasExactLength(int length) {
            if (Value.Length != length) {
                HandleFailure(string.Concat("string value is not exactly ", length, " characters"));
            }

            return this;
        }

        public StringEstablisher HasMinimumLength(int minimumLength) {
            if (Value.Length < minimumLength) {
                HandleFailure(string.Concat("string value is not at least ", minimumLength, " characters"));
            }

            return this;
        }

        public StringEstablisher HasMaximumLength(int maximumLength) {
            if (Value.Length > maximumLength) {
                HandleFailure(string.Concat("string value is too long"));
            }

            return this;
        }

        public StringEstablisher IsNull() {
            return base.IsDefault<StringEstablisher>();
        }

        public StringEstablisher IsNotNull() {
            return base.IsNotDefault<StringEstablisher>();
        }

        public StringEstablisher IsEqualTo(string constraint) {
            return base.IsEqualTo<StringEstablisher>(constraint);
        }

        public StringEstablisher IsNotEqualTo(string constraint) {
            return base.IsNotEqualTo<StringEstablisher>(constraint);
        }
    }

}
