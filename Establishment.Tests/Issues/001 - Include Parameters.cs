using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Establishment.Models;
using Establishment.Exceptions;

namespace Establishment.Tests.Issues {

    [TestClass]
    public class Issue001 {
        
        [TestMethod]
        public void IncludeParameterName() {
            var parameterName = "isEnabled";
            var establish = Establish.ForStruct(true, new EstablisherOptions() { ParameterName = parameterName });

            try {
                establish.IsFalse();
                Assert.Fail();
            }
            catch (EstablishmentException ae) {
                Assert.AreEqual(ae.ParamName, parameterName);
            }
        }

        [TestMethod]
        public void DoNotIncludeParameterName() {
            var establish = Establish.ForStruct(true);

            try {
                establish.IsFalse();
                Assert.Fail();
            }
            catch (EstablishmentException ae) {
                Assert.IsTrue(string.IsNullOrEmpty(ae.ParamName));
            }
        }

    }

}
