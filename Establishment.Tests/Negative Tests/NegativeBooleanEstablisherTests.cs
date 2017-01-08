using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Establishment.Exceptions;

namespace Establishment.Tests.Negative_Tests {

    [TestClass]
    public class NegativeBooleanEstablisherTests {

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsDefault() {
            var establisher = Establish.ForStruct(!default(bool));

            establisher.IsDefault();
        }

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsEqual1() {
            var trueEstablisher = Establish.ForStruct(true);

            trueEstablisher.IsEqualTo(false);
        }

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsEqual2() {
            var trueEstablisher = Establish.ForStruct(false);

            trueEstablisher.IsEqualTo(true);
        }

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsFalse() {
            var establisher = Establish.ForStruct(true);

            establisher.IsFalse();
        }

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsNotDefault() {
            var establisher = Establish.ForStruct(default(bool));

            establisher.IsNotDefault();
        }

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsNotEqual1() {
            var trueEstablisher = Establish.ForStruct(true);

            trueEstablisher.IsNotEqualTo(true);
        }

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsNotEqual2() {
            var trueEstablisher = Establish.ForStruct(false);

            trueEstablisher.IsNotEqualTo(false);
        }

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Negative_Bool_IsTrue() {
            var establisher = Establish.ForStruct(false);

            establisher.IsTrue();
        }

    }

}
