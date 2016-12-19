using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class ShortEstablisherTests {

        [TestMethod]
        public void Short_IsDefault() {
            ShortEstablisher establisher = Establish.For(default(short));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Short_IsEqualTo() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Short_IsGreaterThan() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Short_IsGreaterThanOrEqualTo() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Short_IsLessThan() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Short_IsLessThanOrEqualTo() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Short_IsMaxValue() {
            ShortEstablisher establisher = Establish.For(short.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Short_IsMinValue() {
            ShortEstablisher establisher = Establish.For(short.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Short_IsNotDefault() {
            var value = default(short);
            value++;
            ShortEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Short_IsNotEqualTo() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Short_IsNotMaxValue() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Short_IsNotMinValue() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Short_IsNotZero() {
            ShortEstablisher establisher = Establish.For((short)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Short_IsZero() {
            ShortEstablisher establisher = Establish.For((short)0);

            establisher.IsZero();
        }

    }

}
