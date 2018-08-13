using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class DoubleEstablisherTests {

        [TestMethod]
        public void Double_IsDefault() {
            var establisher = Establish.For(default(double));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Double_IsEqualTo() {
            var establisher = Establish.For((double)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Double_IsGreaterThan() {
            var establisher = Establish.For((double)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Double_IsGreaterThanOrEqualTo() {
            var establisher = Establish.For((double)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Double_IsLessThan() {
            var establisher = Establish.For((double)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Double_IsLessThanOrEqualTo() {
            var establisher = Establish.For((double)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Double_IsMaxValue() {
            var establisher = Establish.For(double.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Double_IsMinValue() {
            var establisher = Establish.For(double.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Double_IsNotDefault() {
            var value = default(double);
            value++;
            var establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Double_IsNotEqualTo() {
            var establisher = Establish.For((double)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Double_IsNotMaxValue() {
            var establisher = Establish.For((double)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Double_IsNotMinValue() {
            var establisher = Establish.For((double)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Double_IsNotZero() {
            var establisher = Establish.For((double)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Double_IsZero() {
            var establisher = Establish.For((double)0);

            establisher.IsZero();
        }

    }

}
