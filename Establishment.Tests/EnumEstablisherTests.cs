using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class EnumEstablisherTests {

        [TestMethod]
        public void Enum_HasFlag() {
            var establisher = Establish.ForStruct(AttributeTargets.All);

            establisher.HasFlag(AttributeTargets.Class);
            establisher.HasFlag(AttributeTargets.All);
        }

        [TestMethod]
        public void Enum_DoesNotHaveFlag() {
            var establisher = Establish.ForStruct(AttributeTargets.Class);

            establisher.DoesNotHaveFlag(AttributeTargets.Enum);
        }

        [TestMethod]
        public void Enum_IsDefined() {
            var establisher = Establish.ForStruct((StringComparison)1);

            establisher.IsDefined();
        }

        [TestMethod]
        public void Enum_IsNotDefined() {
            var establisher = Establish.ForStruct((StringComparison)50);

            establisher.IsNotDefined();
        }

    }

}
