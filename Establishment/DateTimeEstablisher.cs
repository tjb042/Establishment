﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class DateTimeEstablisher : BaseStructEstablisher<DateTime> {

        private static DateTime UnixEpoch = new DateTime(1970, 1, 1);

        public bool IsMinDate(DateTime baseline) {
            if (baseline != DateTime.MinValue) {
                return HandleFailure(new ArgumentException("DateTime value must be equal to DateTime.MinValue"));
            }

            return true;
        }

        public bool IsNotMinDate(DateTime baseline) {
            if (baseline == DateTime.MinValue) {
                return HandleFailure(new ArgumentException("DateTime value must not be equal to DateTime.MinValue"));
            }

            return true;
        }

        public bool IsMaxDate(DateTime baseline) {
            if (baseline != DateTime.MaxValue) {
                return HandleFailure(new ArgumentException("DateTime value must be equal to DateTime.MaxValue"));
            }

            return true;
        }

        public bool IsNotMaxDate(DateTime baseline) {
            if (baseline == DateTime.MaxValue) {
                return HandleFailure(new ArgumentException("DateTime value must not be equal to DateTime.MaxValue"));
            }

            return true;
        }

        public bool IsUnixEpoch(DateTime baseline) {
            if (baseline != UnixEpoch) {
                return HandleFailure(new ArgumentException("DateTime value must be equal to UnixEpoch"));
            }

            return true;
        }

        public bool IsNotUnixEpoch(DateTime baseline) {
            if (baseline == UnixEpoch) {
                return HandleFailure(new ArgumentException("DateTime value must not be equal to UnixEpoch"));
            }

            return true;
        }

        public bool IsAfterUnixEpoch(DateTime baseline) {
            if (baseline < UnixEpoch) {
                return HandleFailure(new ArgumentException("DateTime value must occur after UnixEpoch"));
            }

            return true;
        }

        public bool IsGreaterThan(DateTime baseline, DateTime threshold) {
            if (baseline <= threshold) {
                return HandleFailure(new ArgumentException("DateTime value must be greater than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsGreaterThanOrEqualTo(DateTime baseline, DateTime threshold) {
            if (baseline < threshold) {
                return HandleFailure(new ArgumentException("DateTime value must be greater than or equal to " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThan(DateTime baseline, DateTime threshold) {
            if (baseline >= threshold) {
                return HandleFailure(new ArgumentException("DateTime value must be less than " + threshold.ToString()));
            }

            return true;
        }

        public bool IsLessThanOrEqualTo(DateTime baseline, DateTime threshold) {
            if (baseline > threshold) {
                return HandleFailure(new ArgumentException("DateTime value must be less than or equal to " + threshold.ToString()));
            }

            return true;
        }

    }

}