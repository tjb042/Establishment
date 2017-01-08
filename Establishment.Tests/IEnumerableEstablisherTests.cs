using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Establishment.Tests {

    [TestClass]
    public class IEnumerableEstablisherTests {

        [TestMethod]
        public void IEnumerableEstablisher_HasElements() {
            var establisher = Establish.ForObject(new string[] { "hello world" });

            establisher.HasElements();
        }

        [TestMethod]
        public void IEnumerableEstablisher_HasNoElements() {
            var establisher = Establish.ForObject(new List<int>());

            establisher.HasNoElements();
        }

        [TestMethod]
        public void IEnumerableEstablisher_HasExactLength() {
            var establisher = Establish.ForObject(new int[] { 1, 2, 3 });

            establisher.HasExactLength(3);
        }

        [TestMethod]
        public void IEnumerableEstablisher_HasMaximumLength() {
            var establisher = Establish.ForObject(new Dictionary<string, string>() { { "key", "value" } });
            
            establisher.HasMaximumLength(2);
            establisher.HasMaximumLength(1);
        }

        [TestMethod]
        public void IEnumerableEstablisher_HasMinimumLength() {
            var establisher = Establish.ForObject(new long[] { 1L, 5L, 1000L });

            establisher.HasMinimumLength(0);
            establisher.HasMinimumLength(3);
        }

    }

}
