using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Establishment {

    public class EnumEstablisher<TEnum> : BaseEstablisher<TEnum>, IStructEstablisher<EnumEstablisher<TEnum>, TEnum> where TEnum : struct, IComparable, IFormattable, IConvertible {

        internal EnumEstablisher(TEnum value) : base(value) {
            if (!GenericType.IsEnum) {
                throw new InvalidOperationException("Cannot construct this EnumEstablisher because TEnum is not an enum");
            }
        }

        protected Enum ValueEnum {
            get {
                return Value as Enum;
            }
        }

        public EnumEstablisher<TEnum> HasFlag(TEnum flag) {
            if (!ValueEnum.HasFlag(flag as Enum)) {
                HandleException("enum must contain flag value " + flag.ToString());
            }

            return this;
        }

        public EnumEstablisher<TEnum> DoesNotHaveFlag(TEnum flag) {
            if (ValueEnum.HasFlag(flag as Enum)) {
                HandleException("enum must not contain flag value " + flag.ToString());
            }

            return this;
        }

        public EnumEstablisher<TEnum> IsDefined() {
            if (!Enum.IsDefined(GenericType, Value)) {
                HandleException("enum value is not defined in current enum");
            }

            return this;
        }

        public EnumEstablisher<TEnum> IsNotDefined() {
            if (Enum.IsDefined(GenericType, Value)) {
                HandleException("enum value is defined in the current enum and should not be");
            }

            return this;
        }

        public EnumEstablisher<TEnum> IsDefault() {
            return base.IsDefault<EnumEstablisher<TEnum>>();
        }

        public EnumEstablisher<TEnum> IsNotDefault() {
            return base.IsNotDefault<EnumEstablisher<TEnum>>();
        }

        public EnumEstablisher<TEnum> IsEqualTo(TEnum constraint) {
            return base.IsEqualTo<EnumEstablisher<TEnum>>(constraint);
        }

        public EnumEstablisher<TEnum> IsNotEqualTo(TEnum constraint) {
            return base.IsNotEqualTo<EnumEstablisher<TEnum>>(constraint);
        }

        public EnumEstablisher<TEnum> Satisfies(Action<TEnum> action) {
            return base.Satisfies<EnumEstablisher<TEnum>>(action);
        }

        public EnumEstablisher<TEnum> Satisfies(Func<TEnum, bool> predicate) {
            return base.Satisfies<EnumEstablisher<TEnum>>(predicate);
        }

    }

}
