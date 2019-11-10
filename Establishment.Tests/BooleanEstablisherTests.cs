using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment.Tests
{

    [TestClass]
    public class BooleanEstablisherTests
    {

        [TestInitialize]
        public void Initialize()
        {
            Establish.ThrowExceptionOnFailure = false;
        }

        [TestMethod]
        public void IsTrue_WithTrue_Success()
        {
            // arrange
            var establisher = Establish.For(true);

            // act
            establisher.IsTrue();

            // assert
            var hasExceptions = establisher.HasExceptions;
            Assert.AreEqual(hasExceptions, false);
        }

        [TestMethod]
        public void IsTrue_WithFalse_Exception()
        {
            var establisher = Establish.For(true);

            establisher.IsFalse();

            Assert.AreEqual(establisher.HasExceptions, true);
        }

        [TestMethod]
        public void IsFalse_WithFalse_Success()
        {
            var establisher = Establish.For(false);

            establisher.IsFalse();

            Assert.AreEqual(establisher.HasExceptions, false);
        }

        [TestMethod]
        public void IsFalse_WithTrue_Exception()
        {
            var establisher = Establish.For(false);

            establisher.IsTrue();

            Assert.AreEqual(establisher.HasExceptions, true);
        }

    }

}
