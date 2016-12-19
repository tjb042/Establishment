using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class NegativeBooleanEstablisherTests {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsDefault() {
            var establisher = Establish.For(!default(bool));

            establisher.IsDefault();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsEqual1() {
            var trueEstablisher = Establish.For(true);

            trueEstablisher.IsEqual(false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsEqual2() {
            var trueEstablisher = Establish.For(false);

            trueEstablisher.IsEqual(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsFalse() {
            var establisher = Establish.For(true);

            establisher.IsFalse();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsNotDefault() {
            var establisher = Establish.For(default(bool));

            establisher.IsNotDefault();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsNotEqual1() {
            var trueEstablisher = Establish.For(true);

            trueEstablisher.IsNotEqual(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsNotEqual2() {
            var trueEstablisher = Establish.For(false);

            trueEstablisher.IsNotEqual(false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsTrue() {
            var establisher = Establish.For(false);

            establisher.IsTrue();
        }

    }

}
