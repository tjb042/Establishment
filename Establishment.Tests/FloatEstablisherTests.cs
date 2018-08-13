using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class FloatEstablisherTests {

        [TestMethod]
        public void Float_IsDefault() {
            var establisher = Establish.For(default(float));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Float_IsEqualTo() {
            var establisher = Establish.For((float)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Float_IsGreaterThan() {
            var establisher = Establish.For((float)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Float_IsGreaterThanOrEqualTo() {
            var establisher = Establish.For((float)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Float_IsLessThan() {
            var establisher = Establish.For((float)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Float_IsLessThanOrEqualTo() {
            var establisher = Establish.For((float)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Float_IsMaxValue() {
            var establisher = Establish.For(float.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Float_IsMinValue() {
            var establisher = Establish.For(float.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Float_IsNotDefault() {
            var value = default(float);
            value++;
            var establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Float_IsNotEqualTo() {
            var establisher = Establish.For((float)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Float_IsNotMaxValue() {
            var establisher = Establish.For((float)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Float_IsNotMinValue() {
            var establisher = Establish.For((float)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Float_IsNotZero() {
            var establisher = Establish.For((float)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Float_IsZero() {
            var establisher = Establish.For((float)0);

            establisher.IsZero();
        }

    }

}
