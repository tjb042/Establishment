using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Establishment.Tests {

    [TestClass]
    public class StringEstablisherTests {
        
        [TestMethod]
        public void String_IsNullOrEmpty() {
            var establisher = Establish.ForObject(null as string);

            establisher.IsNullOrEmpty();
        }

        [TestMethod]
        public void String_IsNotNullOrEmpty() {
            var establisher = Establish.ForObject("hello dolly");

            establisher.IsNotNullOrEmpty();
        }

        [TestMethod]
        public void String_IsEmpty() {
            var establisher = Establish.ForObject("");

            establisher.IsEmpty();
        }

        [TestMethod]
        public void String_IsNotEmpty() {
            var establisher = Establish.ForObject("System");

            establisher.IsNotEmpty();
        }

        [TestMethod]
        public void String_HasExactLength() {
            var establisher = Establish.ForObject("four");

            establisher.HasExactLength(4);
        }

        [TestMethod]
        public void String_HasMinimumLength() {
            var establisher = Establish.ForObject("ten");

            establisher.HasMinimumLength(3);
        }

        [TestMethod]
        public void String_HasMaximumLength() {
            var establisher = Establish.ForObject("en-US");

            establisher.HasMaximumLength(5);
        }

        [TestMethod]
        public void String_MatchesPattern() {
            var establisher = Establish.ForObject("01235");
            var zipCodeRegex = new Regex(@"^\d{5}$");

            establisher.MatchesPattern(zipCodeRegex);
        }

        [TestMethod]
        public void String_DoesNotMatchPattern() {
            var establisher = Establish.ForObject("12345");
            var whitespaceRegex = new Regex(@"^\w$");

            establisher.DoesNotMatchPattern(whitespaceRegex);
        }

    }

}
