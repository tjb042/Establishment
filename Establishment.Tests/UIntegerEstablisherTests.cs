using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class UIntegerEstablisherTests {

        [TestMethod]
        public void UInt_IsDefault() {
            var establisher = Establish.ForStruct(default(uint));
            
            establisher.IsDefault();
        }

        [TestMethod]
        public void UInt_IsEqualTo() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void UInt_IsGreaterThan() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void UInt_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void UInt_IsLessThan() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void UInt_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void UInt_IsMaxValue() {
            var establisher = Establish.ForStruct(uint.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void UInt_IsMinValue() {
            var establisher = Establish.ForStruct(uint.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void UInt_IsNotDefault() {
            var value = default(uint);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void UInt_IsNotEqualTo() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void UInt_IsNotMaxValue() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void UInt_IsNotMinValue() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void UInt_IsNotZero() {
            var establisher = Establish.ForStruct((uint)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void UInt_IsZero() {
            var establisher = Establish.ForStruct((uint)0);

            establisher.IsZero();
        }

    }

}
