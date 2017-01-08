using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class UUShortEstablisherTests {

        [TestMethod]
        public void UShort_IsDefault() {
            var establisher = Establish.ForStruct(default(ushort));

            establisher.IsDefault();
        }

        [TestMethod]
        public void UShort_IsEqualTo() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void UShort_IsGreaterThan() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void UShort_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void UShort_IsLessThan() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void UShort_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void UShort_IsMaxValue() {
            var establisher = Establish.ForStruct(ushort.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void UShort_IsMinValue() {
            var establisher = Establish.ForStruct(ushort.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void UShort_IsNotDefault() {
            var value = default(ushort);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void UShort_IsNotEqualTo() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void UShort_IsNotMaxValue() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void UShort_IsNotMinValue() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void UShort_IsNotZero() {
            var establisher = Establish.ForStruct((ushort)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void UShort_IsZero() {
            var establisher = Establish.ForStruct((ushort)0);

            establisher.IsZero();
        }

    }

}
