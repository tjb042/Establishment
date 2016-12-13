using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentGuidTypeTester {

        private GuidEstablisher CreateEstablisher() {
            return new GuidEstablisher() {
                ThrowExceptionOnEstablishmentFailure = true,
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGuid_IsDefault() {
            var establisher = CreateEstablisher();

            establisher.IsDefault(Guid.Parse("1759DD80-5737-4552-8F46-943D134D2D35"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGuid_IsNotDefault() {
            var establisher = CreateEstablisher();

            establisher.IsNotDefault(Guid.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGuid_IsNotDefaultNew() {
            var establisher = CreateEstablisher();

            establisher.IsNotDefault(new Guid());
        }

        [TestMethod]
        public void TestGuid_Defaults() {
            var establisher = CreateEstablisher();

            establisher.IsDefault(Guid.Empty);
            establisher.IsNotDefault(Guid.Parse("1759DD80-5737-4552-8F46-943D134D2D35"));
        }

    }

}
