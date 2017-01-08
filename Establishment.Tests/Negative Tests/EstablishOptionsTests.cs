using Establishment.Exceptions;
using Establishment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Tests.Negative_Tests {

    [TestClass]
    public class EstablishOptionsTests {

        [TestMethod]
        [ExpectedException(typeof(EstablishmentException))]
        public void Establish_NullOptions() {
            var establisher = Establish.ForStruct(true, null as EstablisherOptions);
        }

    }

}
