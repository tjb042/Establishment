using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StructEstablisher<TType> : BaseEstablisher<TType> where TType : struct {

        public StructEstablisher(TType value) : base(value) {

        }

        public StructEstablisher<TType> IsDefault() {
            if (!DefaultComparer.Equals(Value, DefaultTypeValue)) {
                RaiseException(GenericType.Name + " must equal its default value");
            }

            return this;
        }

        public StructEstablisher<TType> IsNotDefault() {
            if (DefaultComparer.Equals(Value, DefaultTypeValue)) {
                RaiseException(GenericType.Name + " must not equal its default value");
            }

            return this;
        }

        public StructEstablisher<TType> IsDBNull() {
            if (!Convert.IsDBNull(Value)) {
                RaiseException(GenericType.Name + " must equal DBNull.Value");
            }

            return this;
        }

        public StructEstablisher<TType> IsNotDBNull() {
            if (Convert.IsDBNull(Value)) {
                RaiseException(GenericType.Name + " must not equal DBNull.Value");
            }

            return this;
        }

        public StructEstablisher<TType> IsEqualTo(TType constraint) {
            if (!DefaultComparer.Equals(Value, constraint)) {
                RaiseException(GenericType.Name + " is not equal to a required constraint");
            }

            return this;
        }

        public StructEstablisher<TType> IsNotEqualTo(TType constraint) {
            if (DefaultComparer.Equals(Value, constraint)) {
                RaiseException(GenericType.Name + " must not equal a blacklist constraint");
            }

            return this;
        }

        public StructEstablisher<TType> Satisfies(Action<TType> action) {
            Establish.ForObject(action).IsNotNull();

            try {
                action(Value);
            }
            catch (Exception ex) {
                RaiseException("bool value does not satisfy user action", ex);
            }

            return this;
        }

        public StructEstablisher<TType> Satisfies(Func<TType, bool> predicate) {
            Establish.ForObject(predicate).IsNotNull();

            try {
                if (!predicate(Value)) {
                    // failure
                    RaiseException("bool value does not satisfy user action");
                }
            }
            catch (Exception ex) {
                // failure
                RaiseException("bool value does not satisfy user action", ex);
            }

            return this;
        }

        public StructEstablisher<TType> ThrowExceptionOnFailure(bool throwException) {
            Options.ThrowExceptionOnFailure = throwException;

            return this;
        }

    }

}
