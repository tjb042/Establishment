﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ShortEstablisher : BaseEstablisher<short>, IStructEstablisher<ShortEstablisher, short> {

        internal ShortEstablisher(short value) : base(value) { }

        public ShortEstablisher IsGreaterThan(short threshold) {
            if (Value <= threshold) {
                HandleFailure("short value must be greater than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ShortEstablisher IsGreaterThanOrEqualTo(short threshold) {
            if (Value < threshold) {
                HandleFailure("short value must be greater than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ShortEstablisher IsLessThan(short threshold) {
            if (Value >= threshold) {
                HandleFailure("short value must be less than " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ShortEstablisher IsLessThanOrEqualTo(short threshold) {
            if (Value > threshold) {
                HandleFailure("short value must be less than or equal to " + threshold.ToString(CultureInfo.CurrentCulture));
            }

            return this;
        }

        public ShortEstablisher IsZero() {
            if (Value != 0) {
                HandleFailure("value must be zero");
            }

            return this;
        }

        public ShortEstablisher IsNotZero() {
            if (Value == 0) {
                HandleFailure("value must not be zero");
            }

            return this;
        }

        public ShortEstablisher IsMinValue() {
            if (Value != short.MinValue) {
                HandleFailure("value must equal short.MinValue");
            }

            return this;
        }

        public ShortEstablisher IsNotMinValue() {
            if (Value == short.MinValue) {
                HandleFailure("value must not equal short.MinValue");
            }

            return this;
        }

        public ShortEstablisher IsMaxValue() {
            if (Value != short.MaxValue) {
                HandleFailure("value must equal short.MaxValue");
            }

            return this;
        }

        public ShortEstablisher IsNotMaxValue() {
            if (Value == short.MaxValue) {
                HandleFailure("value must not equal short.MaxValue");
            }

            return this;
        }

        public ShortEstablisher IsPositive() {
            if (Value < 0) {
                HandleFailure("value must be greater than zero");
            }

            return this;
        }

        public ShortEstablisher IsNegative() {
            if (Value > 0) {
                HandleFailure("value must be less than zero");
            }

            return this;
        }

        public ShortEstablisher IsDefault() {
            return base.IsDefault<ShortEstablisher>();
        }

        public ShortEstablisher IsNotDefault() {
            return base.IsNotDefault<ShortEstablisher>();
        }

        public ShortEstablisher IsEqualTo(short constraint) {
            return base.IsEqualTo<ShortEstablisher>(constraint);
        }

        public ShortEstablisher IsNotEqualTo(short constraint) {
            return base.IsNotEqualTo<ShortEstablisher>(constraint);
        }

    }

}
