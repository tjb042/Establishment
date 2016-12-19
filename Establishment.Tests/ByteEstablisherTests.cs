﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {
    
    [TestClass]
    public class ByteEstablisherTests {

        [TestMethod]
        public void Byte_IsDefault() {
            var establisher = Establish.For(default(byte));

            establisher.IsDefault();
        }

        [TestMethod]
        public void Byte_IsEqualTo() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsEqualTo(10);
        }

        [TestMethod]
        public void Byte_IsGreaterThan() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsGreaterThan(0);
            establisher.IsGreaterThan(9);
        }

        [TestMethod]
        public void Byte_IsGreaterThanOrEqualTo() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsGreaterThanOrEqualTo(9);
            establisher.IsGreaterThanOrEqualTo(10);
        }

        [TestMethod]
        public void Byte_IsLessThan() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsLessThan(15);
            establisher.IsLessThan(11);
        }

        [TestMethod]
        public void Byte_IsLessThanOrEqualTo() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsLessThanOrEqualTo(15);
            establisher.IsLessThanOrEqualTo(10);
        }

        [TestMethod]
        public void Byte_IsMaxValue() {
            ByteEstablisher establisher = Establish.For(byte.MaxValue);

            establisher.IsMaxValue();
        }

        [TestMethod]
        public void Byte_IsMinValue() {
            ByteEstablisher establisher = Establish.For(byte.MinValue);

            establisher.IsMinValue();
        }

        [TestMethod]
        public void Byte_IsNotDefault() {
            byte value = default(byte);
            value++;
            ByteEstablisher establisher = Establish.For(value);

            establisher.IsNotDefault();
        }

        [TestMethod]
        public void Byte_IsNotEqualTo() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsNotEqualTo(50);
        }

        [TestMethod]
        public void Byte_IsNotMaxValue() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsNotMaxValue();
        }

        [TestMethod]
        public void Byte_IsNotMinValue() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsNotMinValue();
        }

        [TestMethod]
        public void Byte_IsNotZero() {
            ByteEstablisher establisher = Establish.For((byte)10);

            establisher.IsNotZero();
        }

        [TestMethod]
        public void Byte_IsZero() {
            ByteEstablisher establisher = Establish.For((byte)0);

            establisher.IsZero();
        }

    }

}