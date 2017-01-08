﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var establisher = Establish.ForStruct(c);

            establisher.IsControl();
        }

        [TestMethod]
        public void Char_IsNotControl() {
            char c = 'A';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotControl();
        }

        [TestMethod]
        public void Char_IsDigit() {
            char c = '8';
            var establisher = Establish.ForStruct(c);

            establisher.IsDigit();
        }

        [TestMethod]
        public void Char_IsNotDigit() {
            char c = 'A';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotDigit();
        }

        [TestMethod]
        public void Char_IsHighSurrogate() {
            char c = '\uD800';
            var establisher = Establish.ForStruct(c);

            establisher.IsHighSurrogate();
        }

        [TestMethod]
        public void Char_IsNotHighSurrogate() {
            char c = 'A';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotHighSurrogate();
        }

        [TestMethod]
        public void Char_IsLetter() {
            char c = 'A';
            var establisher = Establish.ForStruct(c);

            establisher.IsLetter();
        }

        [TestMethod]
        public void Char_IsNotLetter() {
            char c = '-';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotLetter();
        }

        [TestMethod]
        public void Char_IsLetterOrDigit() {
            char c = '0';
            var establisher = Establish.ForStruct(c);

            establisher.IsLetterOrDigit();
        }

        [TestMethod]
        public void Char_IsNotLetterOrDigit() {
            char c = '(';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotLetterOrDigit();
        }

        [TestMethod]
        public void Char_IsLower() {
            char c = 'c';
            var establisher = Establish.ForStruct(c);

            establisher.IsLower();
        }

        [TestMethod]
        public void Char_IsNotLower() {
            char c = 'A';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotLower();
        }

        [TestMethod]
        public void Char_IsLowSurrogate() {
            char c = '\uDC00';
            var establisher = Establish.ForStruct(c);

            establisher.IsLowSurrogate();
        }

        [TestMethod]
        public void Char_IsNotLowSurrogate() {
            char c = 'G';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotLowSurrogate();
        }

        [TestMethod]
        public void Char_IsNumber() {
            char c = '4';
            var establisher = Establish.ForStruct(c);

            establisher.IsNumber();
        }

        [TestMethod]
        public void Char_IsNotNumber() {
            char c = '#';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotNumber();
        }

        [TestMethod]
        public void Char_IsPunctuation() {
            char c = '!';
            var establisher = Establish.ForStruct(c);

            establisher.IsPunctuation();
        }

        [TestMethod]
        public void Char_IsNotPunctuation() {
            char c = 'H';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotPunctuation();
        }

        [TestMethod]
        public void Char_IsSeparator() {
            char c = ' ';
            var establisher = Establish.ForStruct(c);

            establisher.IsSeparator();
        }

        [TestMethod]
        public void Char_IsNotSeparator() {
            char c = 'z';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotSeparator();
        }

        [TestMethod]
        public void Char_IsSurrogate() {
            char c = '\uDC00';
            var establisher = Establish.ForStruct(c);

            establisher.IsLowSurrogate();
        }

        [TestMethod]
        public void Char_IsNotSurrogate() {
            char c = 'j';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotSurrogate();
        }

        [TestMethod]
        public void Char_IsSymbol() {
            char c = '^';
            var establisher = Establish.ForStruct(c);

            establisher.IsSymbol();
        }

        [TestMethod]
        public void Char_IsNotSymbol() {
            char c = 'z';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotSymbol();
        }

        [TestMethod]
        public void Char_IsUpper() {
            char c = 'Z';
            var establisher = Establish.ForStruct(c);

            establisher.IsUpper();
        }

        [TestMethod]
        public void Char_IsNotUpper() {
            char c = 'u';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotUpper();
        }

        [TestMethod]
        public void Char_IsWhiteSpace() {
            char c = ' ';
            var establisher = Establish.ForStruct(c);

            establisher.IsWhiteSpace();
        }

        [TestMethod]
        public void Char_IsNotWhiteSpace() {
            char c = '8';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotWhiteSpace();
        }

        [TestMethod]
        public void Char_IsMaxValue() {
            char c = char.MaxValue;
            var establisher = Establish.ForStruct(c);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Char_IsNotMaxValue() {
            char c = '0';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Char_IsMinValue() {
            char c = char.MinValue;
            var establisher = Establish.ForStruct(c);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Char_IsNotMinValue() {
            char c = '8';
            var establisher = Establish.ForStruct(c);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Char_IsGreaterThan() {
            var establisher = Establish.ForStruct('b');

            establisher.IsGreaterThan('a');
        }

        [TestMethod]
        public void Char_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct('d');

            establisher.IsGreaterThanOrEqualTo('b');
            establisher.IsGreaterThanOrEqualTo('d');
        }

        [TestMethod]
        public void Char_IsLessThan() {
            var establisher = Establish.ForStruct('d');

            establisher.IsLessThan('e');
        }

        [TestMethod]
        public void Char_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct('g');

            establisher.IsLessThanOrEqualTo('g');
            establisher.IsLessThanOrEqualTo('j');
        }

    }

}
