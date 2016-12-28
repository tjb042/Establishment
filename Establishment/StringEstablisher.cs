﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Establishment {

    public class StringEstablisher : ClassEstablisher<StringEstablisher, string> {

        public StringEstablisher(string value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is null or empty
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public StringEstablisher IsNullOrEmpty() {
            if (!string.IsNullOrEmpty(Value)) {
                HandleException("string value must be null or empty");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not null or empty
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public StringEstablisher IsNotNullOrEmpty() {
            if (string.IsNullOrEmpty(Value)) {
                HandleException("string value must not be null or empty");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is an empty string
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public StringEstablisher IsEmpty() {
            if (Value.Length != 0) {
                HandleException("string value must be empty");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not an empty string
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public StringEstablisher IsNotEmpty() {
            if (Value.Length == 0) {
                HandleException("string value must not be empty");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value has exactly <paramref name="length"/> characters
        /// </summary>
        /// <param name="length"></param>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public StringEstablisher HasExactLength(int length) {
            if (Value.Length != length) {
                HandleException(string.Concat("string value is not exactly ", length, " characters"));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value has a minimum length of <paramref name="minimumLength"/>
        /// </summary>
        /// <param name="minimumLength"></param>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public StringEstablisher HasMinimumLength(int minimumLength) {
            if (Value.Length < minimumLength) {
                HandleException(string.Concat("string value is not at least ", minimumLength, " characters"));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value has a maximum length of <paramref name="maximumLength"/>
        /// </summary>
        /// <param name="maximumLength"></param>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public StringEstablisher HasMaximumLength(int maximumLength) {
            if (Value.Length > maximumLength) {
                HandleException(string.Concat("string value is too long"));
            }

            return this;
        }

        public StringEstablisher MatchesPattern(Regex regex) {
            Establish.ForObject(regex).IsNotNull();

            if (!regex.IsMatch(Value)) {
                HandleException("No regex matches were found in the current string");
            }

            return this;
        }

        public StringEstablisher MatchesPattern(Regex regex, int startAt) {
            Establish.ForObject(regex).IsNotNull();

            if (!regex.IsMatch(Value, startAt)) {
                HandleException("No regex matches were found in the current string");
            }

            return this;
        }

        public StringEstablisher DoesNotMatchPattern(Regex regex) {
            Establish.ForObject(regex).IsNotNull();

            if (regex.IsMatch(Value)) {
                HandleException("A regex match was found in the current string where none should exist");
            }

            return this;
        }

        public StringEstablisher DoesNotMatchPattern(Regex regex, int startAt) {
            Establish.ForObject(regex).IsNotNull();

            if (regex.IsMatch(Value, startAt)) {
                HandleException("A regex match was found in the current string where none should exist");
            }

            return this;
        }

    }

}
