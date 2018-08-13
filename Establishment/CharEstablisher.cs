using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class CharEstablisher {

        /// <summary>
        /// Establishes that the supplied value is a control character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsControl(this BaseEstablisher<char> establisher){
            if (!char.IsControl(establisher.Value)) {
                establisher.RaiseException("char must be a control character");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a control character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotControl(this BaseEstablisher<char> establisher){
            if (char.IsControl(establisher.Value)) {
                establisher.RaiseException("char must not be a control character");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsDigit(this BaseEstablisher<char> establisher){
            if (!char.IsDigit(establisher.Value)) {
                establisher.RaiseException("char must be a digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotDigit(this BaseEstablisher<char> establisher){
            if (char.IsDigit(establisher.Value)) {
                establisher.RaiseException("char must not be a digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a high surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsHighSurrogate(this BaseEstablisher<char> establisher){
            if (!char.IsHighSurrogate(establisher.Value)) {
                establisher.RaiseException("char must be a high surrogage");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a high surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotHighSurrogate(this BaseEstablisher<char> establisher){
            if (char.IsHighSurrogate(establisher.Value)) {
                establisher.RaiseException("char must not be a high surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a letter
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsLetter(this BaseEstablisher<char> establisher){
            if (!char.IsLetter(establisher.Value)) {
                establisher.RaiseException("char must be a letter");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a letter
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotLetter(this BaseEstablisher<char> establisher){
            if (char.IsLetter(establisher.Value)) {
                establisher.RaiseException("char must not be a letter");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a letter or digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsLetterOrDigit(this BaseEstablisher<char> establisher){
            if (!char.IsLetterOrDigit(establisher.Value)) {
                establisher.RaiseException("char must be a letter or digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a letter or digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotLetterOrDigit(this BaseEstablisher<char> establisher){
            if (char.IsLetterOrDigit(establisher.Value)) {
                establisher.RaiseException("char must not be a letter or digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is lowercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsLower(this BaseEstablisher<char> establisher){
            if (!char.IsLower(establisher.Value)) {
                establisher.RaiseException("char must be lowercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not lowercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotLower(this BaseEstablisher<char> establisher){
            if (char.IsLower(establisher.Value)) {
                establisher.RaiseException("char must not be lowercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a low surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsLowSurrogate(this BaseEstablisher<char> establisher){
            if (!char.IsLowSurrogate(establisher.Value)) {
                establisher.RaiseException("char must be low surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a low surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotLowSurrogate(this BaseEstablisher<char> establisher){
            if (char.IsLowSurrogate(establisher.Value)) {
                establisher.RaiseException("char must not be low surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a number
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNumber(this BaseEstablisher<char> establisher){
            if (!char.IsNumber(establisher.Value)) {
                establisher.RaiseException("char must be a number");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a number
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotNumber(this BaseEstablisher<char> establisher){
            if (char.IsNumber(establisher.Value)) {
                establisher.RaiseException("char must not be a number");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a punctuation mark
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsPunctuation(this BaseEstablisher<char> establisher){
            if (!char.IsPunctuation(establisher.Value)) {
                establisher.RaiseException("char must be punctuation");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a punctuation mark
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotPunctuation(this BaseEstablisher<char> establisher){
            if (char.IsPunctuation(establisher.Value)) {
                establisher.RaiseException("char must not be punctuation");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a unicode separator character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsSeparator(this BaseEstablisher<char> establisher){
            if (!char.IsSeparator(establisher.Value)) {
                establisher.RaiseException("char must be a separator");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a unicode separator character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotSeparator(this BaseEstablisher<char> establisher){
            if (char.IsSeparator(establisher.Value)) {
                establisher.RaiseException("char must not be a separator");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a unicode surrogate character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsSurrogate(this BaseEstablisher<char> establisher){
            if (!char.IsSurrogate(establisher.Value)) {
                establisher.RaiseException("char must be a surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a unicode surrogate character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotSurrogate(this BaseEstablisher<char> establisher){
            if (char.IsSurrogate(establisher.Value)) {
                establisher.RaiseException("char must not be a surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a symbol
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsSymbol(this BaseEstablisher<char> establisher){
            if (!char.IsSymbol(establisher.Value)) {
                establisher.RaiseException("char must be a symbol");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a symbol
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotSymbol(this BaseEstablisher<char> establisher){
            if (char.IsSymbol(establisher.Value)) {
                establisher.RaiseException("char must not be a symbol");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is uppercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsUpper(this BaseEstablisher<char> establisher){
            if (!char.IsUpper(establisher.Value)) {
                establisher.RaiseException("char must be uppercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not uppercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotUpper(this BaseEstablisher<char> establisher){
            if (char.IsUpper(establisher.Value)) {
                establisher.RaiseException("char must not be uppercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is white space
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsWhiteSpace(this BaseEstablisher<char> establisher){
            if (!char.IsWhiteSpace(establisher.Value)) {
                establisher.RaiseException("char must be white space");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not white space
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotWhiteSpace(this BaseEstablisher<char> establisher){
            if (char.IsWhiteSpace(establisher.Value)) {
                establisher.RaiseException("char must not be white space");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>char.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsMaxValue(this BaseEstablisher<char> establisher){
            if (char.MaxValue != establisher.Value) {
                establisher.RaiseException("char must equal char.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>char.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotMaxValue(this BaseEstablisher<char> establisher){
            if (char.MaxValue == establisher.Value) {
                establisher.RaiseException("char must not equal char.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>char.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsMinValue(this BaseEstablisher<char> establisher){
            if (char.MinValue != establisher.Value) {
                establisher.RaiseException("char must equal char.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>char.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsNotMinValue(this BaseEstablisher<char> establisher){
            if (char.MinValue == establisher.Value) {
                establisher.RaiseException("char must not equal char.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsGreaterThan(this BaseEstablisher<char> establisher, char threshold) {
            if (establisher.Value <= threshold) {
                establisher.RaiseException("char value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsGreaterThanOrEqualTo(this BaseEstablisher<char> establisher, char threshold) {
            if (establisher.Value < threshold) {
                establisher.RaiseException("char value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsLessThan(this BaseEstablisher<char> establisher, char threshold) {
            if (establisher.Value >= threshold) {
                establisher.RaiseException("char value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static BaseEstablisher<char> IsLessThanOrEqualTo(this BaseEstablisher<char> establisher, char threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("char value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }
            
            return establisher;
        }

    }

}
