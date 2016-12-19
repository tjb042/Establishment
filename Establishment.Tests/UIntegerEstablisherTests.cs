using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class UIntegerEstablisherTests {

        [TestMethod]
        public void UInt_IsDefault() {
            UIntegerEstablisher establisher = Establish.For(default(uint));
            
            establisher.IsDefault();
        }

        [TestMethod]
        public void UInt_IsEqualTo() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void UInt_IsGreaterThan() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void UInt_IsGreaterThanOrEqualTo() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void UInt_IsLessThan() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void UInt_IsLessThanOrEqualTo() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void UInt_IsMaxValue() {
            UIntegerEstablisher establisher = Establish.For(uint.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void UInt_IsMinValue() {
            UIntegerEstablisher establisher = Establish.For(uint.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void UInt_IsNotDefault() {
            var value = default(uint);
            value++;
            UIntegerEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void UInt_IsNotEqualTo() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void UInt_IsNotMaxValue() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void UInt_IsNotMinValue() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void UInt_IsNotZero() {
            UIntegerEstablisher establisher = Establish.For((uint)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void UInt_IsZero() {
            UIntegerEstablisher establisher = Establish.For((uint)0);

            establisher.IsZero();
        }

    }

}
