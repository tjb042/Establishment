using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class IntPtrEstablisherTests {
    
        [TestMethod]
        public void IntPtr_IsZero() {
            var establisher = Establish.For(IntPtr.Zero);

            establisher.IsZero();
        }

        [TestMethod]
        public void IntPtr_IsNotZero() {
            var establisher = Establish.For(IntPtr.Add(IntPtr.Zero, 10));

            establisher.IsNotZero();
        }

    }

}
