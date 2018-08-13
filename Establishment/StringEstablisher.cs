using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Establishment {

    public static class StringEstablisher {

        /// <summary>
        /// Establishes that the supplied value is null or empty
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public static BaseEstablisher<string> IsNullOrEmpty(this BaseEstablisher<string> establisher) {
            if (!string.IsNullOrEmpty(establisher.Value)) {
                establisher.RaiseException("string value must be null or empty");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not null or empty
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public static BaseEstablisher<string> IsNotNullOrEmpty(this BaseEstablisher<string> establisher) {
            if (string.IsNullOrEmpty(establisher.Value)) {
                establisher.RaiseException("string value must not be null or empty");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is an empty string
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public static BaseEstablisher<string> IsEmpty(this BaseEstablisher<string> establisher) {
            if (establisher.Value.Length != 0) {
                establisher.RaiseException("string value must be empty");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not an empty string
        /// </summary>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public static BaseEstablisher<string> IsNotEmpty(this BaseEstablisher<string> establisher) {
            if (establisher.Value.Length == 0) {
                establisher.RaiseException("string value must not be empty");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value has exactly <paramref name="length"/> characters
        /// </summary>
        /// <param name="length"></param>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public static BaseEstablisher<string> HasExactLength(this BaseEstablisher<string> establisher, int length) {
            if (establisher.Value.Length != length) {
                establisher.RaiseException(string.Concat("string value is not exactly ", length, " characters"));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value has a minimum length of <paramref name="minimumLength"/>
        /// </summary>
        /// <param name="minimumLength"></param>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public static BaseEstablisher<string> HasMinimumLength(this BaseEstablisher<string> establisher, int minimumLength) {
            if (establisher.Value.Length < minimumLength) {
                establisher.RaiseException(string.Concat("string value is not at least ", minimumLength, " characters"));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value has a maximum length of <paramref name="maximumLength"/>
        /// </summary>
        /// <param name="maximumLength"></param>
        /// <returns>The current <see cref="StringEstablisher"/></returns>
        public static BaseEstablisher<string> HasMaximumLength(this BaseEstablisher<string> establisher, int maximumLength) {
            if (establisher.Value.Length > maximumLength) {
                establisher.RaiseException(string.Concat("string value is too long"));
            }

            return establisher;
        }

        public static BaseEstablisher<string> MatchesPattern(this BaseEstablisher<string> establisher, Regex regex) {
            Establish.For(regex).IsNotNull();

            if (!regex.IsMatch(establisher.Value)) {
                establisher.RaiseException("No regex matches were found in the current string");
            }

            return establisher;
        }

        public static BaseEstablisher<string> MatchesPattern(this BaseEstablisher<string> establisher, Regex regex, int startAt) {
            Establish.For(regex).IsNotNull();

            if (!regex.IsMatch(establisher.Value, startAt)) {
                establisher.RaiseException("No regex matches were found in the current string");
            }

            return establisher;
        }

        public static BaseEstablisher<string> DoesNotMatchPattern(this BaseEstablisher<string> establisher, Regex regex) {
            Establish.For(regex).IsNotNull();

            if (regex.IsMatch(establisher.Value)) {
                establisher.RaiseException("A regex match was found in the current string where none should exist");
            }

            return establisher;
        }

        public static BaseEstablisher<string> DoesNotMatchPattern(this BaseEstablisher<string> establisher, Regex regex, int startAt) {
            Establish.For(regex).IsNotNull();

            if (regex.IsMatch(establisher.Value, startAt)) {
                establisher.RaiseException("A regex match was found in the current string where none should exist");
            }

            return establisher;
        }

    }

}
