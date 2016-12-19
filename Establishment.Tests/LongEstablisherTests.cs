using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class LongEstablisherTests {

        [TestMethod]
        public void Long_IsDefault() {
            LongEstablisher establisher = Establish.For(default(long));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Long_IsEqualTo() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Long_IsGreaterThan() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Long_IsGreaterThanOrEqualTo() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Long_IsLessThan() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Long_IsLessThanOrEqualTo() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Long_IsMaxValue() {
            LongEstablisher establisher = Establish.For(long.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Long_IsMinValue() {
            LongEstablisher establisher = Establish.For(long.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Long_IsNotDefault() {
            var value = default(long);
            value++;
            LongEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Long_IsNotEqualTo() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Long_IsNotMaxValue() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Long_IsNotMinValue() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Long_IsNotZero() {
            LongEstablisher establisher = Establish.For((long)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Long_IsZero() {
            LongEstablisher establisher = Establish.For((long)0);

            establisher.IsZero();
        }

    }

}
