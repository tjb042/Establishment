using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Establishment.Tests
{
    
    [TestClass]
    public class BaseEstablisher
    {

        [TestInitialize]
        public void Initialize()
        {
            Establish.ThrowExceptionOnFailure = false;
        }

        [TestMethod]
        public void Property_WithNoWork_Success()
        {
            var regex = new Regex("", RegexOptions.IgnoreCase);
            var establisher = Establish.For(regex);

            establisher.Property(x => x.RightToLeft, e => e.IsFalse());

            Assert.AreEqual(establisher.HasExceptions, false);
        }

        [TestMethod]
        public void Property_WithExceptions_Exception()
        {
            var cookie = new Cookie();
            var establisher = Establish.For(cookie);

            establisher.Property(x => x.Domain, e => e.HasExactLength(500));

            Assert.AreEqual(establisher.HasExceptions, true);
        }

    }

}
