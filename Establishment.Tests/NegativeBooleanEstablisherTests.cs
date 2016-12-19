using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class NegativeBooleanEstablisherTests {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsTrue() {
            var establisher = Establish.For(false);

            establisher.IsTrue();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Bool_IsFalse() {
            var establisher = Establish.For(true);

            establisher.IsFalse();
        }

    }

}
