using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class SByteEstablisherTests {

        [TestMethod]
        public void SByte_IsDefault() {
            var establisher = Establish.For(default(sbyte));

            establisher.IsDefault();
        }

        [TestMethod]
        public void SByte_IsEqualTo() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void SByte_IsGreaterThan() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void SByte_IsGreaterThanOrEqualTo() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void SByte_IsLessThan() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void SByte_IsLessThanOrEqualTo() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void SByte_IsMaxValue() {
            var establisher = Establish.For(sbyte.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void SByte_IsMinValue() {
            var establisher = Establish.For(sbyte.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void SByte_IsNotDefault() {
            var value = default(sbyte);
            value++;
            var establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void SByte_IsNotEqualTo() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void SByte_IsNotMaxValue() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void SByte_IsNotMinValue() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void SByte_IsNotZero() {
            var establisher = Establish.For((sbyte)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void SByte_IsZero() {
            var establisher = Establish.For((sbyte)0);

            establisher.IsZero();
        }

    }

}
