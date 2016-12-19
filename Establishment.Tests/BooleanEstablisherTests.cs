using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class BooleanEstablisherTests {
    
        [TestMethod]
        public void Bool_IsTrue() {
            var establisher = Establish.For(true);

            establisher.IsTrue();
        }

        [TestMethod]
        public void Bool_IsFalse() {
            var establisher = Establish.For(false);

            establisher.IsFalse();
        }

    }

}
