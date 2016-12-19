using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class DoubleEstablisherTests {

        [TestMethod]
        public void Double_IsDefault() {
            DoubleEstablisher establisher = Establish.For(default(double));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Double_IsEqualTo() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Double_IsGreaterThan() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Double_IsGreaterThanOrEqualTo() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Double_IsLessThan() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Double_IsLessThanOrEqualTo() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Double_IsMaxValue() {
            DoubleEstablisher establisher = Establish.For(double.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Double_IsMinValue() {
            DoubleEstablisher establisher = Establish.For(double.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Double_IsNotDefault() {
            var value = default(double);
            value++;
            DoubleEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Double_IsNotEqualTo() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Double_IsNotMaxValue() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Double_IsNotMinValue() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Double_IsNotZero() {
            DoubleEstablisher establisher = Establish.For((double)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Double_IsZero() {
            DoubleEstablisher establisher = Establish.For((double)0);

            establisher.IsZero();
        }

    }

}
