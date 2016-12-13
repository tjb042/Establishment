﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentBoolTypeTest {

        public EstablishmentBoolTypeTest() {
            Establish.ThrowExceptionOnEstablishmentFailure = true;
        }

        [TestMethod]
        public void TestBool_IsEqual() {
            var establisher = new BooleanEstablisher();

            var test = true;
            establisher.IsEqual(test, test);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_Negative_IsEqual() {
            var establisher = new BooleanEstablisher();

            var test = true;
            establisher.IsEqual(test, !test);
        }

        [TestMethod]
        public void TestBool_IsNotEqual() {
            var establisher = new BooleanEstablisher();

            var test = true;
            establisher.IsNotEqual(test, !test);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_Negative_IsNotEqual() {
            var establisher = new BooleanEstablisher();

            var test = true;
            establisher.IsNotEqual(test, test);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_IsTrue() {
            var establisher = new BooleanEstablisher();

            establisher.IsTrue(false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_IsFalse() {
            var establisher = new BooleanEstablisher();

            establisher.IsFalse(true);
        }

        [TestMethod]
        public void TestBool_IsDefault() {
            var establisher = new BooleanEstablisher();

            establisher.IsDefault(false);
        }

        [TestMethod]
        public void TestBool_IsNotDefault() {
            var establisher = new BooleanEstablisher();

            establisher.IsNotDefault(true);
        }

        [TestMethod]
        public void TestBool_Values() {
            var establisher = new BooleanEstablisher();

            establisher.IsTrue(true);
            establisher.IsFalse(false);
        }

    }

}