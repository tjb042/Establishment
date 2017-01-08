using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {
    
    [TestClass]
    public class IntegerEstablisherTests {

        [TestMethod]
        public void Int_IsDefault() {
            var establisher = Establish.ForStruct(default(int));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Int_IsEqualTo() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Int_IsGreaterThan() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Int_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Int_IsLessThan() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Int_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Int_IsMaxValue() {
            var establisher = Establish.ForStruct(int.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Int_IsMinValue() {
            var establisher = Establish.ForStruct(int.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Int_IsNotDefault() {
            var value = default(int);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Int_IsNotEqualTo() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Int_IsNotMaxValue() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Int_IsNotMinValue() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Int_IsNotZero() {
            var establisher = Establish.ForStruct((int)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Int_IsZero() {
            var establisher = Establish.ForStruct((int)0);

            establisher.IsZero();
        }

    }

}
