using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Microsoft.VisualStudio.TestTools.Resources;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentReferenceTypeTester {

        private BaseClassEstablisher<object> CreateObjectEstablisher() {
            return new BaseClassEstablisher<object>() {
                ThrowExceptionOnEstablishmentFailure = true,
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBase_IsNull() {
            var establisher = CreateObjectEstablisher();

            establisher.IsNull("a string");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBase_IsNotNull() {
            var establisher = CreateObjectEstablisher();

            establisher.IsNotNull(null);
        }

        [TestMethod]
        public void TestBase_Nulls() {
            var establisher = CreateObjectEstablisher();

            establisher.IsNull(null);
            establisher.IsNotNull("David Bowie");
        }

    }

}
