using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class LongEstablisherTests {

        [TestMethod]
        public void Long_IsDefault() {
            var establisher = Establish.ForStruct(default(long));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Long_IsEqualTo() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Long_IsGreaterThan() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Long_IsGreaterThanOrEqualTo() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Long_IsLessThan() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Long_IsLessThanOrEqualTo() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Long_IsMaxValue() {
            var establisher = Establish.ForStruct(long.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Long_IsMinValue() {
            var establisher = Establish.ForStruct(long.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Long_IsNotDefault() {
            var value = default(long);
            value++;
            var establisher = Establish.ForStruct(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Long_IsNotEqualTo() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Long_IsNotMaxValue() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Long_IsNotMinValue() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Long_IsNotZero() {
            var establisher = Establish.ForStruct((long)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Long_IsZero() {
            var establisher = Establish.ForStruct((long)0);

            establisher.IsZero();
        }

    }

}
