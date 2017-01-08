using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class ULongEstablisherTests {

        [TestMethod]
        public void ULong_IsDefault() {
            var establisher = Establish.ForStruct(default(ulong));

            establisher.IsDefault();
        }

        [TestMethod]
        public void ULong_IsEqualTo() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void ULong_IsGreaterThan() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void ULong_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void ULong_IsLessThan() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void ULong_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void ULong_IsMaxValue() {
            var establisher = Establish.ForStruct(ulong.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void ULong_IsMinValue() {
            var establisher = Establish.ForStruct(ulong.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void ULong_IsNotDefault() {
            var value = default(ulong);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void ULong_IsNotEqualTo() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void ULong_IsNotMaxValue() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void ULong_IsNotMinValue() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void ULong_IsNotZero() {
            var establisher = Establish.ForStruct((ulong)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void ULong_IsZero() {
            var establisher = Establish.ForStruct((ulong)0);

            establisher.IsZero();
        }

    }

}
