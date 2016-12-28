using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class CharEstablisher : StructEstablisher<CharEstablisher, char> {

        public CharEstablisher(char value) : base(value) { }

        /// <summary>
        /// Establishes that the supplied value is a control character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsControl() {
            if (!char.IsControl(Value)) {
                HandleException("char must be a control character");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a control character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotControl() {
            if (char.IsControl(Value)) {
                HandleException("char must not be a control character");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsDigit() {
            if (!char.IsDigit(Value)) {
                HandleException("char must be a digit");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotDigit() {
            if (char.IsDigit(Value)) {
                HandleException("char must not be a digit");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a high surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsHighSurrogate() {
            if (!char.IsHighSurrogate(Value)) {
                HandleException("char must be a high surrogage");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a high surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotHighSurrogate() {
            if (char.IsHighSurrogate(Value)) {
                HandleException("char must not be a high surrogate");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a letter
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsLetter() {
            if (!char.IsLetter(Value)) {
                HandleException("char must be a letter");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a letter
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotLetter() {
            if (char.IsLetter(Value)) {
                HandleException("char must not be a letter");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a letter or digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsLetterOrDigit() {
            if (!char.IsLetterOrDigit(Value)) {
                HandleException("char must be a letter or digit");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a letter or digit
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotLetterOrDigit() {
            if (char.IsLetterOrDigit(Value)) {
                HandleException("char must not be a letter or digit");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is lowercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsLower() {
            if (!char.IsLower(Value)) {
                HandleException("char must be lowercase");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not lowercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotLower() {
            if (char.IsLower(Value)) {
                HandleException("char must not be lowercase");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a low surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsLowSurrogate() {
            if (!char.IsLowSurrogate(Value)) {
                HandleException("char must be low surrogate");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a low surrogate unicode character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotLowSurrogate() {
            if (char.IsLowSurrogate(Value)) {
                HandleException("char must not be low surrogate");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a number
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNumber() {
            if (!char.IsNumber(Value)) {
                HandleException("char must be a number");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a number
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotNumber() {
            if (char.IsNumber(Value)) {
                HandleException("char must not be a number");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a punctuation mark
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsPunctuation() {
            if (!char.IsPunctuation(Value)) {
                HandleException("char must be punctuation");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a punctuation mark
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotPunctuation() {
            if (char.IsPunctuation(Value)) {
                HandleException("char must not be punctuation");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a unicode separator character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsSeparator() {
            if (!char.IsSeparator(Value)) {
                HandleException("char must be a separator");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a unicode separator character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotSeparator() {
            if (char.IsSeparator(Value)) {
                HandleException("char must not be a separator");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a unicode surrogate character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsSurrogate() {
            if (!char.IsSurrogate(Value)) {
                HandleException("char must be a surrogate");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a unicode surrogate character
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotSurrogate() {
            if (char.IsSurrogate(Value)) {
                HandleException("char must not be a surrogate");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is a symbol
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsSymbol() {
            if (!char.IsSymbol(Value)) {
                HandleException("char must be a symbol");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not a symbol
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotSymbol() {
            if (char.IsSymbol(Value)) {
                HandleException("char must not be a symbol");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is uppercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsUpper() {
            if (!char.IsUpper(Value)) {
                HandleException("char must be uppercase");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not uppercase
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotUpper() {
            if (char.IsUpper(Value)) {
                HandleException("char must not be uppercase");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is white space
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsWhiteSpace() {
            if (!char.IsWhiteSpace(Value)) {
                HandleException("char must be white space");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is not white space
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotWhiteSpace() {
            if (char.IsWhiteSpace(Value)) {
                HandleException("char must not be white space");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>char.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsMaxValue() {
            if (char.MaxValue != Value) {
                HandleException("char must equal char.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>char.MaxValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotMaxValue() {
            if (char.MaxValue == Value) {
                HandleException("char must not equal char.MaxValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value equals <c>char.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsMinValue() {
            if (char.MinValue != Value) {
                HandleException("char must equal char.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value does not equal <c>char.MinValue</c>
        /// </summary>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsNotMinValue() {
            if (char.MinValue == Value) {
                HandleException("char must not equal char.MinValue");
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsGreaterThan(char threshold) {
            if (Value <= threshold) {
                HandleException("char value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is greater than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsGreaterThanOrEqualTo(char threshold) {
            if (Value < threshold) {
                HandleException("char value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsLessThan(char threshold) {
            if (Value >= threshold) {
                HandleException("char value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        /// <summary>
        /// Establishes that the supplied value is less than or equal to <paramref name="threshold"/>
        /// </summary>
        /// <param name="threshold">The value to compare against</param>
        /// <returns>The current <see cref="CharEstablisher"/></returns>
        public CharEstablisher IsLessThanOrEqualTo(char threshold) {
            if (Value > threshold) {
                HandleException("char value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }
            
            return this;
        }

    }

}
