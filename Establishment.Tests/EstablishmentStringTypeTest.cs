using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentStringTypeTest {

        private StringEstablisher CreateEstablisher() {
            return new StringEstablisher() {
                ThrowExceptionOnEstablishmentFailure = true,
            };
        }

        [TestMethod]
        public void TestString_IsEqual() {
            var establisher = CreateEstablisher();

            establisher.IsEqual("hot dog", "hot dog");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsEqual() {
            var establisher = CreateEstablisher();

            establisher.IsEqual("hot dog", "hotdog");
        }

        [TestMethod]
        public void TestString_IsEmpty() {
            var establisher = CreateEstablisher();

            establisher.IsEmpty("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsEmpty() {
            var establisher = CreateEstablisher();

            establisher.IsEmpty("hotdog");
        }

        [TestMethod]
        public void TestString_IsNull() {
            var establisher = CreateEstablisher();

            establisher.IsNull(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsNull() {
            var establisher = CreateEstablisher();

            establisher.IsNull("starbuck");
        }

        [TestMethod]
        public void TestString_IsNullOrEmpty() {
            var establisher = CreateEstablisher();

            establisher.IsNullOrEmpty(null);
            establisher.IsNullOrEmpty("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsNullOrEmpty() {
            var establisher = CreateEstablisher();

            establisher.IsNullOrEmpty("lee");
        }

    }

}
