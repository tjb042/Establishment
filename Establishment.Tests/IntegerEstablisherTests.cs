using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {
    
    [TestClass]
    public class IntegerEstablisherTests {

        [TestMethod]
        public void Int_IsDefault() {
            IntegerEstablisher establisher = Establish.For(default(int));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Int_IsEqualTo() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Int_IsGreaterThan() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Int_IsGreaterThanOrEqualTo() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Int_IsLessThan() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Int_IsLessThanOrEqualTo() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Int_IsMaxValue() {
            IntegerEstablisher establisher = Establish.For(int.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Int_IsMinValue() {
            IntegerEstablisher establisher = Establish.For(int.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Int_IsNotDefault() {
            var value = default(int);
            value++;
            IntegerEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Int_IsNotEqualTo() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Int_IsNotMaxValue() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Int_IsNotMinValue() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Int_IsNotZero() {
            IntegerEstablisher establisher = Establish.For((int)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Int_IsZero() {
            IntegerEstablisher establisher = Establish.For((int)0);

            establisher.IsZero();
        }

    }

}
