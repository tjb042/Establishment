using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentIntTypeTest {

        public EstablishmentIntTypeTest() {
            Establish.ThrowExceptionOnEstablishmentFailure = true;
        }

        [TestMethod]
        public void TestInt_IsDefault() {
            var establisher = new IntegerEstablisher();

            establisher.IsDefault(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInt_Negative_IsDefault() {
            var establisher = new IntegerEstablisher();
            
            establisher.IsDefault(1);
        }

        [TestMethod]
        public void TestInt_IsEqual() {
            var establisher = new IntegerEstablisher();

            establisher.IsEqual(15, 15);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInt_Negative_IsEqual() {
            var establisher = new IntegerEstablisher();

            establisher.IsEqual(15, 22);
        }

        [TestMethod]
        public void TestInt_IsGreaterThan() {
            var establisher = new IntegerEstablisher();

            establisher.IsGreaterThan(10, 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInt_Negative_IsGreaterThan() {
            var establisher = new IntegerEstablisher();

            establisher.IsGreaterThan(10, 15);
        }

        [TestMethod]
        public void TestInt_IsGreaterThanOrEqualTo() {
            var establisher = new IntegerEstablisher();

            establisher.IsGreaterThanOrEqualTo(10, 10);
            establisher.IsGreaterThanOrEqualTo(12, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInt_Negative_IsGreaterThanOrEqualTo() {
            var establisher = new IntegerEstablisher();

            establisher.IsGreaterThanOrEqualTo(10, 50);
        }

        [TestMethod]
        public void TestInt_IsLessThan() {
            var establisher = new IntegerEstablisher();

            establisher.IsLessThan(1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInt_Negative_IsLessThan() {
            var establisher = new IntegerEstablisher();

            establisher.IsLessThan(2, 1);
        }

        [TestMethod]
        public void TestInt_IsLessThanOrEqualTo() {
            var establisher = new IntegerEstablisher();

            establisher.IsLessThanOrEqualTo(2, 2);
            establisher.IsLessThanOrEqualTo(1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInt_Negative_IsLessThanOrEqualTo() {
            var establisher = new IntegerEstablisher();

            establisher.IsLessThanOrEqualTo(5, 2);
        }

        [TestMethod]
        public void TestInt_IsZero() {
            var establisher = new IntegerEstablisher();

            establisher.IsZero(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInt_Negative_IsZero() {
            var establisher = new IntegerEstablisher();

            establisher.IsZero(1);
        }

    }

}
