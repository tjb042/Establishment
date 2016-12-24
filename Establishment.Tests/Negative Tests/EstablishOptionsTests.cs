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
        [ExpectedException(typeof(ArgumentException))]
        public void Establish_NullOptions() {
            var establisher = Establish.For(true, null);
        }

    }

}
