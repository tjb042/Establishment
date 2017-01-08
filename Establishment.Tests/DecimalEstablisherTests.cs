using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class DecimalEstablisherTests {

        [TestMethod]
        public void Decimal_IsDefault() {
            var establisher = Establish.ForStruct(default(decimal));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Decimal_IsEqualTo() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Decimal_IsGreaterThan() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Decimal_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Decimal_IsLessThan() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Decimal_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Decimal_IsMaxValue() {
            var establisher = Establish.ForStruct(decimal.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Decimal_IsMinValue() {
            var establisher = Establish.ForStruct(decimal.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Decimal_IsNotDefault() {
            var value = default(decimal);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Decimal_IsNotEqualTo() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Decimal_IsNotMaxValue() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Decimal_IsNotMinValue() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Decimal_IsNotZero() {
            var establisher = Establish.ForStruct((decimal)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Decimal_IsZero() {
            var establisher = Establish.ForStruct((decimal)0);

            establisher.IsZero();
        }

    }

}
