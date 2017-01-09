using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ClassEstablisher<TType> : BaseEstablisher<TType> where TType : class {

        public ClassEstablisher(TType value) : base(value) {

        }

        public ClassEstablisher<TType> IsNull() {
            if (!DefaultComparer.Equals(Value, DefaultTypeValue)) {
                RaiseException(GenericType.Name + " must equal its default value");
            }

            return this;
        }

        public ClassEstablisher<TType> IsNotNull() {
            if (DefaultComparer.Equals(Value, DefaultTypeValue)) {
                RaiseException(GenericType.Name + " must not equal its default value");
            }

            return this;
        }

        public ClassEstablisher<TType> IsDBNull() {
            if (!Convert.IsDBNull(Value)) {
                RaiseException(GenericType.Name + " must equal DBNull.Value");
            }

            return this;
        }

        public ClassEstablisher<TType> IsNotDBNull() {
            if (Convert.IsDBNull(Value)) {
                RaiseException(GenericType.Name + " must not equal DBNull.Value");
            }

            return this;
        }

        public ClassEstablisher<TType> IsEqualTo(TType constraint) {
            if (!DefaultComparer.Equals(Value, constraint)) {
                RaiseException(GenericType.Name + " is not equal to a required constraint");
            }

            return this;
        }

        public ClassEstablisher<TType> IsNotEqualTo(TType constraint) {
            if (DefaultComparer.Equals(Value, constraint)) {
                RaiseException(GenericType.Name + " must not equal a blacklist constraint");
            }

            return this;
        }

        public ClassEstablisher<TType> Satisfies(Action<TType> action) {
            Establish.ForObject(action).IsNotNull();

            try {
                action(Value);
            }
            catch (Exception ex) {
                RaiseException("bool value does not satisfy user action", ex);
            }

            return this;
        }

        public ClassEstablisher<TType> Satisfies(Func<TType, bool> predicate) {
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

        public ClassEstablisher<TType> ThrowExceptionOnFailure(bool throwException) {
            Options.ThrowExceptionOnFailure = throwException;

            return this;
        }

    }

}
