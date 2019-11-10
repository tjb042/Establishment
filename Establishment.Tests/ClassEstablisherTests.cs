using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment.Tests
{

    [TestClass]
    public class ClassEstablisherTests
    {

        [TestInitialize]
        public void Initialize()
        {
            Establish.ThrowExceptionOnFailure = false;
        }

        [TestMethod]
        public void IsNull_WithNull_Success()
        {
            string input = null;
            var establisher = Establish.For(input);

            establisher.IsNull();

            Assert.AreEqual(establisher.HasExceptions, false);
        }

        [TestMethod]
        public void IsNull_WithObject_Exception()
        {
            string input = string.Empty;
            var establisher = Establish.For(input);

            establisher.IsNull();

            Assert.AreEqual(establisher.HasExceptions, true);
        }

        [TestMethod]
        public void IsNotNull_WithObject_Success()
        {
            string input = string.Empty;
            var establisher = Establish.For(input);

            establisher.IsNotNull();

            Assert.AreEqual(establisher.HasExceptions, false);
        }

        [TestMethod]
        public void IsNotNull_WithNull_Exception()
        {
            string input = null;
            var establisher = Establish.For(input);

            establisher.IsNotNull();

            Assert.AreEqual(establisher.HasExceptions, true);
        }

    }

}
