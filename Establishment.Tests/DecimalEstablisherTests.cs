using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class DecimalEstablisherTests {

        [TestMethod]
        public void Decimal_IsDefault() {
            DecimalEstablisher establisher = Establish.For(default(decimal));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Decimal_IsEqualTo() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Decimal_IsGreaterThan() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Decimal_IsGreaterThanOrEqualTo() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Decimal_IsLessThan() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Decimal_IsLessThanOrEqualTo() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Decimal_IsMaxValue() {
            DecimalEstablisher establisher = Establish.For(decimal.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Decimal_IsMinValue() {
            DecimalEstablisher establisher = Establish.For(decimal.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Decimal_IsNotDefault() {
            var value = default(decimal);
            value++;
            DecimalEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Decimal_IsNotEqualTo() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Decimal_IsNotMaxValue() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Decimal_IsNotMinValue() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Decimal_IsNotZero() {
            DecimalEstablisher establisher = Establish.For((decimal)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Decimal_IsZero() {
            DecimalEstablisher establisher = Establish.For((decimal)0);

            establisher.IsZero();
        }

    }

}
