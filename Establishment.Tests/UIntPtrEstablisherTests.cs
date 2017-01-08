using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Tests {

    [TestClass]
    public class UIntPtrEstablisherTests {

        [TestMethod]
        public void UIntPtr_IsZero() {
            var establisher = Establish.ForStruct(UIntPtr.Zero);

            establisher.IsZero();
        }

        [TestMethod]
        public void UIntPtr_IsNotZero() {
            var establisher = Establish.ForStruct(UIntPtr.Add(UIntPtr.Zero, 10));

            establisher.IsNotZero();
        }

    }

}
