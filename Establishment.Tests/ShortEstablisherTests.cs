using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class ShortEstablisherTests {

        [TestMethod]
        public void Short_IsDefault() {
            var establisher = Establish.ForStruct(default(short));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Short_IsEqualTo() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Short_IsGreaterThan() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Short_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Short_IsLessThan() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Short_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Short_IsMaxValue() {
            var establisher = Establish.ForStruct(short.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Short_IsMinValue() {
            var establisher = Establish.ForStruct(short.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Short_IsNotDefault() {
            var value = default(short);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Short_IsNotEqualTo() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Short_IsNotMaxValue() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Short_IsNotMinValue() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Short_IsNotZero() {
            var establisher = Establish.ForStruct((short)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Short_IsZero() {
            var establisher = Establish.ForStruct((short)0);

            establisher.IsZero();
        }

    }

}
