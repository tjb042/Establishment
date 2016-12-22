using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Tests {

    [TestClass]
    public class CharEstablisherTests {

        [TestMethod]
        public void Char_IsControl() {
            char c = (char)6; // ACK
            CharEstablisher establisher = Establish.For(c);

            establisher.IsControl();
        }

        [TestMethod]
        public void Char_IsNotControl() {
            char c = 'A';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotControl();
        }

        [TestMethod]
        public void Char_IsDigit() {
            char c = '8';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsDigit();
        }

        [TestMethod]
        public void Char_IsNotDigit() {
            char c = 'A';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotDigit();
        }

        [TestMethod]
        public void Char_IsHighSurrogate() {
            char c = '\uD800';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsHighSurrogate();
        }

        [TestMethod]
        public void Char_IsNotHighSurrogate() {
            char c = 'A';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotHighSurrogate();
        }

        [TestMethod]
        public void Char_IsLetter() {
            char c = 'A';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsLetter();
        }

        [TestMethod]
        public void Char_IsNotLetter() {
            char c = '-';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotLetter();
        }

        [TestMethod]
        public void Char_IsLetterOrDigit() {
            char c = '0';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsLetterOrDigit();
        }

        [TestMethod]
        public void Char_IsNotLetterOrDigit() {
            char c = '(';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotLetterOrDigit();
        }

        [TestMethod]
        public void Char_IsLower() {
            char c = 'c';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsLower();
        }

        [TestMethod]
        public void Char_IsNotLower() {
            char c = 'A';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotLower();
        }

        [TestMethod]
        public void Char_IsLowSurrogate() {
            char c = '\uDC00';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsLowSurrogate();
        }

        [TestMethod]
        public void Char_IsNotLowSurrogate() {
            char c = 'G';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotLowSurrogate();
        }

        [TestMethod]
        public void Char_IsNumber() {
            char c = '4';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNumber();
        }

        [TestMethod]
        public void Char_IsNotNumber() {
            char c = '#';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotNumber();
        }

        [TestMethod]
        public void Char_IsPunctuation() {
            char c = '!';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsPunctuation();
        }

        [TestMethod]
        public void Char_IsNotPunctuation() {
            char c = 'H';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotPunctuation();
        }

        [TestMethod]
        public void Char_IsSeparator() {
            char c = ' ';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsSeparator();
        }

        [TestMethod]
        public void Char_IsNotSeparator() {
            char c = 'z';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotSeparator();
        }

        [TestMethod]
        public void Char_IsSurrogate() {
            char c = '\uDC00';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsLowSurrogate();
        }

        [TestMethod]
        public void Char_IsNotSurrogate() {
            char c = 'j';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotSurrogate();
        }

        [TestMethod]
        public void Char_IsSymbol() {
            char c = '^';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsSymbol();
        }

        [TestMethod]
        public void Char_IsNotSymbol() {
            char c = 'z';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotSymbol();
        }

        [TestMethod]
        public void Char_IsUpper() {
            char c = 'Z';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsUpper();
        }

        [TestMethod]
        public void Char_IsNotUpper() {
            char c = 'u';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotUpper();
        }

        [TestMethod]
        public void Char_IsWhiteSpace() {
            char c = ' ';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsWhiteSpace();
        }

        [TestMethod]
        public void Char_IsNotWhiteSpace() {
            char c = '8';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotWhiteSpace();
        }

        [TestMethod]
        public void Char_IsMaxValue() {
            char c = char.MaxValue;
            CharEstablisher establisher = Establish.For(c);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Char_IsNotMaxValue() {
            char c = '0';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Char_IsMinValue() {
            char c = char.MinValue;
            CharEstablisher establisher = Establish.For(c);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Char_IsNotMinValue() {
            char c = '8';
            CharEstablisher establisher = Establish.For(c);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Char_IsGreaterThan() {
            CharEstablisher establisher = Establish.For('b');

            establisher.IsGreaterThan('a');
        }

        [TestMethod]
        public void Char_IsGreaterThanOrEqualTo() {
            CharEstablisher establisher = Establish.For('d');

            establisher.IsGreaterThanOrEqualTo('b');
            establisher.IsGreaterThanOrEqualTo('d');
        }

        [TestMethod]
        public void Char_IsLessThan() {
            CharEstablisher establisher = Establish.For('d');

            establisher.IsLessThan('e');
        }

        [TestMethod]
        public void Char_IsLessThanOrEqualTo() {
            CharEstablisher establisher = Establish.For('g');

            establisher.IsLessThanOrEqualTo('g');
            establisher.IsLessThanOrEqualTo('j');
        }

    }

}
