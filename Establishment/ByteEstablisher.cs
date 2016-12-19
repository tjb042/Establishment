﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ByteEstablisher : BaseStructEstablisher<byte> {

        internal ByteEstablisher(byte value) : base(value) { }

        public ByteEstablisher IsGreaterThan(byte threshold) {
            if (Value <= threshold) {
                HandleFailure(new ArgumentException("byte value must be greater than " + threshold.ToString()));
            }

            return this;
        }

        public ByteEstablisher IsGreaterThanOrEqualTo(byte threshold) {
            if (Value < threshold) {
                HandleFailure(new ArgumentException("byte value must be greater than or equal to " + threshold.ToString()));
            }

            return this;
        }

        public ByteEstablisher IsLessThan(byte threshold) {
            if (Value >= threshold) {
                HandleFailure(new ArgumentException("byte value must be less than " + threshold.ToString()));
            }

            return this;
        }

        public ByteEstablisher IsLessThanOrEqualTo(byte threshold) {
            if (Value > threshold) {
                HandleFailure(new ArgumentException("byte value must be less than or equal to " + threshold.ToString()));
            }

            return this;
        }

        public ByteEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure(new ArgumentException("value must be zero"));
            }

            return this;
        }

        public ByteEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure(new ArgumentException("value must not be zero"));
            }

            return this;
        }

        public ByteEstablisher IsMinValue() {
            if (Value != byte.MinValue) {
                HandleFailure(new ArgumentException("value must equal byte.MinValue"));
            }

            return this;
        }

        public ByteEstablisher IsNotMinValue() {
            if (Value == byte.MinValue) {
                HandleFailure(new ArgumentException("value must not equal byte.MinValue"));
            }

            return this;
        }

        public ByteEstablisher IsMaxValue() {
            if (Value != byte.MaxValue) {
                HandleFailure(new ArgumentException("value must equal byte.MaxValue"));
            }

            return this;
        }

        public ByteEstablisher IsNotMaxValue() {
            if (Value == byte.MaxValue) {
                HandleFailure(new ArgumentException("value must not equal byte.MaxValue"));
            }

            return this;
        }

    }

}
