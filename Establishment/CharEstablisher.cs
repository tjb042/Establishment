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
        public static StructEstablisher<char> IsControl(this StructEstablisher<char> establisher){
            if (!char.IsControl(establisher.Value)) {
                establisher.RaiseException("char must be a control character");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a control character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotControl(this StructEstablisher<char> establisher){
            if (char.IsControl(establisher.Value)) {
                establisher.RaiseException("char must not be a control character");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsDigit(this StructEstablisher<char> establisher){
            if (!char.IsDigit(establisher.Value)) {
                establisher.RaiseException("char must be a digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotDigit(this StructEstablisher<char> establisher){
            if (char.IsDigit(establisher.Value)) {
                establisher.RaiseException("char must not be a digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a high surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsHighSurrogate(this StructEstablisher<char> establisher){
            if (!char.IsHighSurrogate(establisher.Value)) {
                establisher.RaiseException("char must be a high surrogage");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a high surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotHighSurrogate(this StructEstablisher<char> establisher){
            if (char.IsHighSurrogate(establisher.Value)) {
                establisher.RaiseException("char must not be a high surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a letter
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsLetter(this StructEstablisher<char> establisher){
            if (!char.IsLetter(establisher.Value)) {
                establisher.RaiseException("char must be a letter");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a letter
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotLetter(this StructEstablisher<char> establisher){
            if (char.IsLetter(establisher.Value)) {
                establisher.RaiseException("char must not be a letter");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a letter or digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsLetterOrDigit(this StructEstablisher<char> establisher){
            if (!char.IsLetterOrDigit(establisher.Value)) {
                establisher.RaiseException("char must be a letter or digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a letter or digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotLetterOrDigit(this StructEstablisher<char> establisher){
            if (char.IsLetterOrDigit(establisher.Value)) {
                establisher.RaiseException("char must not be a letter or digit");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is lowercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsLower(this StructEstablisher<char> establisher){
            if (!char.IsLower(establisher.Value)) {
                establisher.RaiseException("char must be lowercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not lowercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotLower(this StructEstablisher<char> establisher){
            if (char.IsLower(establisher.Value)) {
                establisher.RaiseException("char must not be lowercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a low surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsLowSurrogate(this StructEstablisher<char> establisher){
            if (!char.IsLowSurrogate(establisher.Value)) {
                establisher.RaiseException("char must be low surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a low surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotLowSurrogate(this StructEstablisher<char> establisher){
            if (char.IsLowSurrogate(establisher.Value)) {
                establisher.RaiseException("char must not be low surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a number
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNumber(this StructEstablisher<char> establisher){
            if (!char.IsNumber(establisher.Value)) {
                establisher.RaiseException("char must be a number");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a number
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotNumber(this StructEstablisher<char> establisher){
            if (char.IsNumber(establisher.Value)) {
                establisher.RaiseException("char must not be a number");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a punctuation mark
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsPunctuation(this StructEstablisher<char> establisher){
            if (!char.IsPunctuation(establisher.Value)) {
                establisher.RaiseException("char must be punctuation");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a punctuation mark
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotPunctuation(this StructEstablisher<char> establisher){
            if (char.IsPunctuation(establisher.Value)) {
                establisher.RaiseException("char must not be punctuation");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a unicode separator character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsSeparator(this StructEstablisher<char> establisher){
            if (!char.IsSeparator(establisher.Value)) {
                establisher.RaiseException("char must be a separator");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a unicode separator character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotSeparator(this StructEstablisher<char> establisher){
            if (char.IsSeparator(establisher.Value)) {
                establisher.RaiseException("char must not be a separator");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a unicode surrogate character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsSurrogate(this StructEstablisher<char> establisher){
            if (!char.IsSurrogate(establisher.Value)) {
                establisher.RaiseException("char must be a surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a unicode surrogate character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotSurrogate(this StructEstablisher<char> establisher){
            if (char.IsSurrogate(establisher.Value)) {
                establisher.RaiseException("char must not be a surrogate");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is a symbol
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsSymbol(this StructEstablisher<char> establisher){
            if (!char.IsSymbol(establisher.Value)) {
                establisher.RaiseException("char must be a symbol");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not a symbol
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotSymbol(this StructEstablisher<char> establisher){
            if (char.IsSymbol(establisher.Value)) {
                establisher.RaiseException("char must not be a symbol");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is uppercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsUpper(this StructEstablisher<char> establisher){
            if (!char.IsUpper(establisher.Value)) {
                establisher.RaiseException("char must be uppercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not uppercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotUpper(this StructEstablisher<char> establisher){
            if (char.IsUpper(establisher.Value)) {
                establisher.RaiseException("char must not be uppercase");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is white space
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsWhiteSpace(this StructEstablisher<char> establisher){
            if (!char.IsWhiteSpace(establisher.Value)) {
                establisher.RaiseException("char must be white space");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value is not white space
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotWhiteSpace(this StructEstablisher<char> establisher){
            if (char.IsWhiteSpace(establisher.Value)) {
                establisher.RaiseException("char must not be white space");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>char.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsMaxValue(this StructEstablisher<char> establisher){
            if (char.MaxValue != establisher.Value) {
                establisher.RaiseException("char must equal char.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>char.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotMaxValue(this StructEstablisher<char> establisher){
            if (char.MaxValue == establisher.Value) {
                establisher.RaiseException("char must not equal char.MaxValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>char.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsMinValue(this StructEstablisher<char> establisher){
            if (char.MinValue != establisher.Value) {
                establisher.RaiseException("char must equal char.MinValue");
            }

            return establisher;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>char.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public static StructEstablisher<char> IsNotMinValue(this StructEstablisher<char> establisher){
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
        public static StructEstablisher<char> IsGreaterThan(this StructEstablisher<char> establisher, char threshold) {
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
        public static StructEstablisher<char> IsGreaterThanOrEqualTo(this StructEstablisher<char> establisher, char threshold) {
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
        public static StructEstablisher<char> IsLessThan(this StructEstablisher<char> establisher, char threshold) {
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
        public static StructEstablisher<char> IsLessThanOrEqualTo(this StructEstablisher<char> establisher, char threshold) {
            if (establisher.Value > threshold) {
                establisher.RaiseException("char value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }
            
            return establisher;
        }

    }

}
