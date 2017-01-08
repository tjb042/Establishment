using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {
    
    [TestClass]
    public class ByteEstablisherTests {

        [TestMethod]
        public void Byte_IsDefault() {
            var establisher = Establish.ForStruct(default(byte));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Byte_IsEqualTo() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Byte_IsGreaterThan() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Byte_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Byte_IsLessThan() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Byte_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Byte_IsMaxValue() {
            var establisher = Establish.ForStruct(byte.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Byte_IsMinValue() {
            var establisher = Establish.ForStruct(byte.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Byte_IsNotDefault() {
            byte value = default(byte);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Byte_IsNotEqualTo() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Byte_IsNotMaxValue() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Byte_IsNotMinValue() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Byte_IsNotZero() {
            var establisher = Establish.ForStruct((byte)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Byte_IsZero() {
            var establisher = Establish.ForStruct((byte)0);

            establisher.IsZero();
        }

    }

}
