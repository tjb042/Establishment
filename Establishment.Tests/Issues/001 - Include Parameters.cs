using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests.Issues {

    [TestClass]
    public class Issue001 {
        
        [TestMethod]
        public void IncludeParameterName() {
            var parameterName = "isEnabled";
            var establish = Establish.For(true, parameterName);

            try {
                establish.IsFalse();
                Assert.Fail();
            }
            catch (ArgumentException ae) {
                Assert.AreEqual(ae.ParamName, parameterName);
            }
        }

        [TestMethod]
        public void DoNotIncludeParameterName() {
            var establish = Establish.For(true);

            try {
                establish.IsFalse();
                Assert.Fail();
            }
            catch (ArgumentException ae) {
                Assert.IsTrue(string.IsNullOrEmpty(ae.ParamName));
            }
        }

    }

}
