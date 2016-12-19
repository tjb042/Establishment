using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class BooleanEstablisherTests {
    
        [TestMethod]
        public void Bool_IsDefault() {
            var establisher = Establish.For(default(bool));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Bool_IsEqual() {
            var trueEstablisher = Establish.For(true);
            var falseEstablisher = Establish.For(false);

            trueEstablisher.IsEqualTo(true);
            falseEstablisher.IsEqualTo(false);
        }

        [TestMethod]
        public void Bool_IsFalse() {
            var establisher = Establish.For(false);

            establisher.IsFalse();
        }

        [TestMethod]
        public void Bool_IsNotDefault() {
            var establisher = Establish.For(!default(bool));

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Bool_IsNotEqual() {
            var trueEstablisher = Establish.For(true);
            var falseEstablisher = Establish.For(false);

            trueEstablisher.IsNotEqualTo(false);
            falseEstablisher.IsNotEqualTo(true);
        }

        [TestMethod]
        public void Bool_IsTrue() {
            var establisher = Establish.For(true);

            establisher.IsTrue();
        }

    }

}
