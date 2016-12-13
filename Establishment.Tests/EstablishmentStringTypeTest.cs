using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentStringTypeTest {

        public EstablishmentStringTypeTest() {
            Establish.ThrowExceptionOnEstablishmentFailure = true;
        }

        [TestMethod]
        public void TestString_IsEqual() {
            var establisher = new StringEstablisher();

            establisher.IsEqual("hot dog", "hot dog");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsEqual() {
            var establisher = new StringEstablisher();

            establisher.IsEqual("hot dog", "hotdog");
        }

        [TestMethod]
        public void TestString_IsEmpty() {
            var establisher = new StringEstablisher();

            establisher.IsEmpty("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsEmpty() {
            var establisher = new StringEstablisher();

            establisher.IsEmpty("hotdog");
        }

        [TestMethod]
        public void TestString_IsNull() {
            var establisher = new StringEstablisher();

            establisher.IsNull(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsNull() {
            var establisher = new StringEstablisher();

            establisher.IsNull("starbuck");
        }

        [TestMethod]
        public void TestString_IsNullOrEmpty() {
            var establisher = new StringEstablisher();

            establisher.IsNullOrEmpty(null);
            establisher.IsNullOrEmpty("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestString_Negative_IsNullOrEmpty() {
            var establisher = new StringEstablisher();

            establisher.IsNullOrEmpty("lee");
        }

    }

}
