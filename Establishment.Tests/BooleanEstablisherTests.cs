using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class BooleanEstablisherTests {
    
        [TestMethod]
        public void Bool_IsDefault() {
            var establisher = Establish.ForStruct(default(bool));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Bool_IsEqual() {
            var trueEstablisher = Establish.ForStruct(true);
            var falseEstablisher = Establish.ForStruct(false);

            trueEstablisher.IsEqualTo(true);
            falseEstablisher.IsEqualTo(false);
        }

        [TestMethod]
        public void Bool_IsFalse() {
            var establisher = Establish.ForStruct(false);

            establisher.IsFalse();
        }

        [TestMethod]
        public void Bool_IsNotDefault() {
            var establisher = Establish.ForStruct(!default(bool));

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Bool_IsNotEqual() {
            var trueEstablisher = Establish.ForStruct(true);
            var falseEstablisher = Establish.ForStruct(false);

            trueEstablisher.IsNotEqualTo(false);
            falseEstablisher.IsNotEqualTo(true);
        }

        [TestMethod]
        public void Bool_IsTrue() {
            var establisher = Establish.ForStruct(true);

            establisher.IsTrue();
        }

    }

}
