using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Establishment.Tests {

    [TestClass]
    public class StringEstablisherTests {
        
        [TestMethod]
        public void String_IsNullOrEmpty() {
            var establisher = Establish.For(null as string);

            establisher.IsNullOrEmpty();
        }

        [TestMethod]
        public void String_IsNotNullOrEmpty() {
            var establisher = Establish.For("hello dolly");

            establisher.IsNotNullOrEmpty();
        }

        [TestMethod]
        public void String_IsEmpty() {
            var establisher = Establish.For("");

            establisher.IsEmpty();
        }

        [TestMethod]
        public void String_IsNotEmpty() {
            var establisher = Establish.For("System");

            establisher.IsNotEmpty();
        }

        [TestMethod]
        public void String_HasExactLength() {
            var establisher = Establish.For("four");

            establisher.HasExactLength(4);
        }

        [TestMethod]
        public void String_HasMinimumLength() {
            var establisher = Establish.For("ten");

            establisher.HasMinimumLength(3);
        }

        [TestMethod]
        public void String_HasMaximumLength() {
            var establisher = Establish.For("en-US");

            establisher.HasMaximumLength(5);
        }

        [TestMethod]
        public void String_MatchesPattern() {
            var establisher = Establish.For("01235");
            var zipCodeRegex = new Regex(@"^\d{5}$");

            establisher.MatchesPattern(zipCodeRegex);
        }

        [TestMethod]
        public void String_DoesNotMatchPattern() {
            var establisher = Establish.For("12345");
            var whitespaceRegex = new Regex(@"^\w$");

            establisher.DoesNotMatchPattern(whitespaceRegex);
        }

    }

}
