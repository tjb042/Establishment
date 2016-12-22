using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class CharEstablisher : BaseEstablisher<char>, IStructEstablisher<CharEstablisher, char> {

        internal CharEstablisher(char value) : base(value) { }

        public CharEstablisher IsDefault() {
            return base.IsDefault<CharEstablisher>();
        }

        public CharEstablisher IsNotDefault() {
            return base.IsNotDefault<CharEstablisher>();
        }

        public CharEstablisher IsEqualTo(char constraint) {
            return base.IsEqualTo<CharEstablisher>(constraint);
        }

        public CharEstablisher IsNotEqualTo(char constraint) {
            return base.IsNotEqualTo<CharEstablisher>(constraint);
        }

        public CharEstablisher IsControl() {
            if (!char.IsControl(Value)) {
                HandleFailure("char must be a control character");
            }

            return this;
        }

        public CharEstablisher IsNotControl() {
            if (char.IsControl(Value)) {
                HandleFailure("char must not be a control character");
            }

            return this;
        }

        public CharEstablisher IsDigit() {
            if (!char.IsDigit(Value)) {
                HandleFailure("char must be a digit");
            }

            return this;
        }

        public CharEstablisher IsNotDigit() {
            if (char.IsDigit(Value)) {
                HandleFailure("char must not be a digit");
            }

            return this;
        }

        public CharEstablisher IsHighSurrogate() {
            if (!char.IsHighSurrogate(Value)) {
                HandleFailure("char must be a high surrogage");
            }

            return this;
        }

        public CharEstablisher IsNotHighSurrogate() {
            if (char.IsHighSurrogate(Value)) {
                HandleFailure("char must not be a high surrogate");
            }

            return this;
        }

        public CharEstablisher IsLetter() {
            if (!char.IsLetter(Value)) {
                HandleFailure("char must be a letter");
            }

            return this;
        }

        public CharEstablisher IsNotLetter() {
            if (char.IsLetter(Value)) {
                HandleFailure("char must not be a letter");
            }

            return this;
        }

        public CharEstablisher IsLetterOrDigit() {
            if (!char.IsLetterOrDigit(Value)) {
                HandleFailure("char must be a letter or digit");
            }

            return this;
        }

        public CharEstablisher IsNotLetterOrDigit() {
            if (char.IsLetterOrDigit(Value)) {
                HandleFailure("char must not be a letter or digit");
            }

            return this;
        }

        public CharEstablisher IsLower() {
            if (!char.IsLower(Value)) {
                HandleFailure("char must be lowercase");
            }

            return this;
        }

        public CharEstablisher IsNotLower() {
            if (char.IsLower(Value)) {
                HandleFailure("char must not be lowercase");
            }

            return this;
        }

        public CharEstablisher IsLowSurrogate() {
            if (!char.IsLowSurrogate(Value)) {
                HandleFailure("char must be low surrogate");
            }

            return this;
        }

        public CharEstablisher IsNotLowSurrogate() {
            if (char.IsLowSurrogate(Value)) {
                HandleFailure("char must not be low surrogate");
            }

            return this;
        }

        public CharEstablisher IsNumber() {
            if (!char.IsNumber(Value)) {
                HandleFailure("char must be a number");
            }

            return this;
        }

        public CharEstablisher IsNotNumber() {
            if (char.IsNumber(Value)) {
                HandleFailure("char must not be a number");
            }

            return this;
        }

        public CharEstablisher IsPunctuation() {
            if (!char.IsPunctuation(Value)) {
                HandleFailure("char must be punctuation");
            }

            return this;
        }

        public CharEstablisher IsNotPunctuation() {
            if (char.IsPunctuation(Value)) {
                HandleFailure("char must not be punctuation");
            }

            return this;
        }

        public CharEstablisher IsSeparator() {
            if (!char.IsSeparator(Value)) {
                HandleFailure("char must be a separator");
            }

            return this;
        }

        public CharEstablisher IsNotSeparator() {
            if (char.IsSeparator(Value)) {
                HandleFailure("char must not be a separator");
            }

            return this;
        }

        public CharEstablisher IsSurrogate() {
            if (!char.IsSurrogate(Value)) {
                HandleFailure("char must be a surrogate");
            }

            return this;
        }

        public CharEstablisher IsNotSurrogate() {
            if (char.IsSurrogate(Value)) {
                HandleFailure("char must not be a surrogate");
            }

            return this;
        }

        public CharEstablisher IsSymbol() {
            if (!char.IsSymbol(Value)) {
                HandleFailure("char must be a symbol");
            }

            return this;
        }

        public CharEstablisher IsNotSymbol() {
            if (char.IsSymbol(Value)) {
                HandleFailure("char must not be a symbol");
            }

            return this;
        }

        public CharEstablisher IsUpper() {
            if (!char.IsUpper(Value)) {
                HandleFailure("char must be uppercase");
            }

            return this;
        }

        public CharEstablisher IsNotUpper() {
            if (char.IsUpper(Value)) {
                HandleFailure("char must not be uppercase");
            }

            return this;
        }

        public CharEstablisher IsWhiteSpace() {
            if (!char.IsWhiteSpace(Value)) {
                HandleFailure("char must be white space");
            }

            return this;
        }

        public CharEstablisher IsNotWhiteSpace() {
            if (char.IsWhiteSpace(Value)) {
                HandleFailure("char must not be white space");
            }

            return this;
        }

        public CharEstablisher IsMaxValue() {
            if (char.MaxValue != Value) {
                HandleFailure("char must equal char.MaxValue");
            }

            return this;
        }

        public CharEstablisher IsNotMaxValue() {
            if (char.MaxValue == Value) {
                HandleFailure("char must not equal char.MaxValue");
            }

            return this;
        }

        public CharEstablisher IsMinValue() {
            if (char.MinValue != Value) {
                HandleFailure("char must equal char.MinValue");
            }

            return this;
        }

        public CharEstablisher IsNotMinValue() {
            if (char.MinValue == Value) {
                HandleFailure("char must not equal char.MinValue");
            }

            return this;
        }

        public CharEstablisher IsGreaterThan(char threshold) {
            if (Value <= threshold) {
                HandleFailure("char value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public CharEstablisher IsGreaterThanOrEqualTo(char threshold) {
            if (Value < threshold) {
                HandleFailure("char value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public CharEstablisher IsLessThan(char threshold) {
            if (Value >= threshold) {
                HandleFailure("char value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public CharEstablisher IsLessThanOrEqualTo(char threshold) {
            if (Value > threshold) {
                HandleFailure("char value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

    }

}
