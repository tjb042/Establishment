using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class UUShortEstablisherTests {

        [TestMethod]
        public void UShort_IsDefault() {
            UShortEstablisher establisher = Establish.For(default(ushort));

            establisher.IsDefault();
        }

        [TestMethod]
        public void UShort_IsEqualTo() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void UShort_IsGreaterThan() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void UShort_IsGreaterThanOrEqualTo() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void UShort_IsLessThan() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void UShort_IsLessThanOrEqualTo() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void UShort_IsMaxValue() {
            UShortEstablisher establisher = Establish.For(ushort.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void UShort_IsMinValue() {
            UShortEstablisher establisher = Establish.For(ushort.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void UShort_IsNotDefault() {
            var value = default(ushort);
            value++;
            UShortEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void UShort_IsNotEqualTo() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void UShort_IsNotMaxValue() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void UShort_IsNotMinValue() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void UShort_IsNotZero() {
            UShortEstablisher establisher = Establish.For((ushort)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void UShort_IsZero() {
            UShortEstablisher establisher = Establish.For((ushort)0);

            establisher.IsZero();
        }

    }

}
