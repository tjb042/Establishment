using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment.Tests
{

    [TestClass]
    public class StructEstablisherTests
    {

        [TestInitialize]
        public void Initialize()
        {
            Establish.ThrowExceptionOnFailure = false;
        }

        [TestMethod]
        public void IsDefault_WithDefault_Success()
        {
            int zero = default(int);
            var establisher = Establish.For(zero);

            establisher.IsDefault();

            Assert.AreEqual(establisher.HasExceptions, false);
        }

        [TestMethod]
        public void IsDefault_WithValue_Exception()
        {
            int one = 1;
            var establisher = Establish.For(one);

            establisher.IsDefault();

            Assert.AreEqual(establisher.HasExceptions, true);
        }

        [TestMethod]
        public void IsNotDefault_WithValue_Success()
        {
            int one = 1;
            var establisher = Establish.For(one);

            establisher.IsNotDefault();

            Assert.AreEqual(establisher.HasExceptions, false);
        }

        [TestMethod]
        public void IsNotDefault_WithDefault_Exception()
        {
            int zero = default(int);
            var establisher = Establish.For(zero);

            establisher.IsNotDefault();

            Assert.AreEqual(establisher.HasExceptions, true);
        }

    }

}
