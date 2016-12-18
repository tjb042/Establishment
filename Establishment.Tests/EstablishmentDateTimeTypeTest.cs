using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Establishment.Tests {

    [TestClass]
    public class EstablishmentDateTimeTypeTest {

        private DateTime GetUnixEpoch() {
            return new DateTime(1970, 1, 1);
        }

        private DateTimeEstablisher CreateEstablisher() {
            return new DateTimeEstablisher() {
                ThrowExceptionOnEstablishmentFailure = true,
            };
        }

        [TestMethod]
        public void TestDateTime_IsAfterUnixEpoch() {
            var establisher = CreateEstablisher();

            establisher.IsAfterUnixEpoch(DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsAfterUnixEpoch() {
            var establisher = CreateEstablisher();

            establisher.IsAfterUnixEpoch(DateTime.MinValue);
        }

        [TestMethod]
        public void TestDateTime_IsDefault() {
            var establisher = CreateEstablisher();

            establisher.IsDefault(new DateTime());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsDefault() {
            var establisher = CreateEstablisher();

            establisher.IsDefault(DateTime.Now);
        }

        [TestMethod]
        public void TestDateTime_IsEqual() {
            var establisher = CreateEstablisher();

            establisher.IsEqual(new DateTime(1999, 1, 1), new DateTime(1999, 1, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsEqual() {
            var establisher = CreateEstablisher();

            establisher.IsEqual(DateTime.Now, DateTime.MinValue);
        }

        [TestMethod]
        public void TestDateTime_IsGreaterThan() {
            var establisher = CreateEstablisher();

            establisher.IsGreaterThan(DateTime.Now, DateTime.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsGreaterThan() {
            var establisher = CreateEstablisher();

            establisher.IsGreaterThan(DateTime.Now, DateTime.MaxValue);
        }

        [TestMethod]
        public void TestDateTime_IsGreaterThanOrEqualTo() {
            var establisher = CreateEstablisher();

            establisher.IsGreaterThanOrEqualTo(DateTime.Now, DateTime.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsGreaterThanOrEqualTo() {
            var establisher = CreateEstablisher();

            establisher.IsGreaterThanOrEqualTo(DateTime.Now, DateTime.MaxValue);
        }

        [TestMethod]
        public void TestDateTime_IsLessThan() {
            var establisher = CreateEstablisher();

            establisher.IsLessThan(DateTime.Now, DateTime.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsLessThan() {
            var establisher = CreateEstablisher();

            establisher.IsLessThan(DateTime.Now, DateTime.MinValue);
        }

        [TestMethod]
        public void TestDateTime_IsLessThanOrEqualTo() {
            var establisher = CreateEstablisher();

            establisher.IsLessThanOrEqualTo(DateTime.Now, DateTime.MaxValue);
        }
    
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsLessThanOrEqualTo() {
            var establisher = CreateEstablisher();

            establisher.IsLessThanOrEqualTo(DateTime.Now, DateTime.MinValue);
        }

        [TestMethod]
        public void TestDateTime_IsMaxDate() {
            var establisher = CreateEstablisher();

            establisher.IsMaxDate(DateTime.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsMaxDate() {
            var establisher = CreateEstablisher();

            establisher.IsMaxDate(DateTime.Now);
        }

        [TestMethod]
        public void TestDateTime_IsMinDate() {
            var establisher = CreateEstablisher();

            establisher.IsMinDate(DateTime.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsMinDate() {
            var establisher = CreateEstablisher();

            establisher.IsMinDate(DateTime.Now);
        }

        [TestMethod]
        public void TestDateTime_IsUnixEpoch() {
            var establisher = CreateEstablisher();

            establisher.IsUnixEpoch(GetUnixEpoch());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsUnixEpoch() {
            var establisher = CreateEstablisher();
            var value = GetUnixEpoch().AddSeconds(1000);

            establisher.IsUnixEpoch(value);
        }

        [TestMethod]
        public void TestDateTime_IsWeekDay() {
            var establisher = CreateEstablisher();

            establisher.IsWeekday(new DateTime(2016, 12, 20));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsWeekDay() {
            var establisher = CreateEstablisher();

            establisher.IsWeekday(new DateTime(2016, 12, 18));
        }

        [TestMethod]
        public void TestDateTime_IsInTheFuture() {
            var establisher = CreateEstablisher();
            var date = DateTime.Now.AddDays(1D);

            establisher.IsInTheFuture(date);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime_Negative_IsInTheFuture() {
            var establisher = CreateEstablisher();
            var date = DateTime.Now.AddDays(-1D);

            establisher.IsInTheFuture(date);
        }

        [TestMethod]
        public void TestDateTime_IsInThePast() {
            var establisher = CreateEstablisher();
            var date = DateTime.Now.AddDays(-1D);

            establisher.IsInThePast(date);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateTime__Negative_IsInThePast() {
            var establisher = CreateEstablisher();
            var date = DateTime.Now.AddDays(1D);

            establisher.IsInThePast(date);
        }

    }

}
