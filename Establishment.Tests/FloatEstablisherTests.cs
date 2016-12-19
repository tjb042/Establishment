using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class FloatEstablisherTests {

        [TestMethod]
        public void Float_IsDefault() {
            FloatEstablisher establisher = Establish.For(default(float));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Float_IsEqualTo() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Float_IsGreaterThan() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Float_IsGreaterThanOrEqualTo() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Float_IsLessThan() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Float_IsLessThanOrEqualTo() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Float_IsMaxValue() {
            FloatEstablisher establisher = Establish.For(float.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Float_IsMinValue() {
            FloatEstablisher establisher = Establish.For(float.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Float_IsNotDefault() {
            var value = default(float);
            value++;
            FloatEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Float_IsNotEqualTo() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Float_IsNotMaxValue() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Float_IsNotMinValue() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Float_IsNotZero() {
            FloatEstablisher establisher = Establish.For((float)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Float_IsZero() {
            FloatEstablisher establisher = Establish.For((float)0);

            establisher.IsZero();
        }

    }

}
