using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class EnumEstablisherTests {

        [TestMethod]
        public void Enum_HasFlag() {
            var establisher = Establish.ForEnum(AttributeTargets.All);

            establisher.HasFlag(AttributeTargets.Class);
            establisher.HasFlag(AttributeTargets.All);
        }

        [TestMethod]
        public void Enum_DoesNotHaveFlag() {
            var establisher = Establish.ForEnum(AttributeTargets.Class);

            establisher.DoesNotHaveFlag(AttributeTargets.Enum);
        }

        [TestMethod]
        public void Enum_IsDefined() {
            var establisher = Establish.ForEnum((StringComparison)1);

            establisher.IsDefined();
        }

        [TestMethod]
        public void Enum_IsNotDefined() {
            var establisher = Establish.ForEnum((StringComparison)50);

            establisher.IsNotDefined();
        }

    }

}
