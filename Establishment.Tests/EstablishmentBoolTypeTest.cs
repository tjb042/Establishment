using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentBoolTypeTest {

        private BooleanEstablisher CreateEstablisher() {
            return new BooleanEstablisher() {
                ThrowExceptionOnEstablishmentFailure = true
            };
        }

        [TestMethod]
        public void TestBool_IsEqual() {
            var establisher = CreateEstablisher();

            var test = true;
            establisher.IsEqual(test, test);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_Negative_IsEqual() {
            var establisher = CreateEstablisher();

            var test = true;
            establisher.IsEqual(test, !test);
        }

        [TestMethod]
        public void TestBool_IsNotEqual() {
            var establisher = CreateEstablisher();

            var test = true;
            establisher.IsNotEqual(test, !test);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_Negative_IsNotEqual() {
            var establisher = CreateEstablisher();

            var test = true;
            establisher.IsNotEqual(test, test);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_IsTrue() {
            var establisher = CreateEstablisher();

            establisher.IsTrue(false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBool_IsFalse() {
            var establisher = CreateEstablisher();

            establisher.IsFalse(true);
        }

        [TestMethod]
        public void TestBool_IsDefault() {
            var establisher = CreateEstablisher();

            establisher.IsDefault(false);
        }

        [TestMethod]
        public void TestBool_IsNotDefault() {
            var establisher = CreateEstablisher();

            establisher.IsNotDefault(true);
        }

        [TestMethod]
        public void TestBool_Values() {
            var establisher = CreateEstablisher();

            establisher.IsTrue(true);
            establisher.IsFalse(false);
        }

    }

}
