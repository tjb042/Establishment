using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StructEstablisher<TEstablisher, TType> : BaseEstablisher<TType> where TType : struct where TEstablisher : StructEstablisher<TEstablisher, TType> {

        public StructEstablisher(TType value) : base(value) {

        }

        public TEstablisher IsDefault() {
            if (!DefaultComparer.Equals(Value, DefaultTypeValue)) {
                HandleException(GenericType.Name + " must equal its default value");
            }

            return this as TEstablisher;
        }

        public TEstablisher IsNotDefault() {
            if (DefaultComparer.Equals(Value, DefaultTypeValue)) {
                HandleException(GenericType.Name + " must not equal its default value");
            }

            return this as TEstablisher;
        }

        public TEstablisher IsDBNull() {
            if (!Convert.IsDBNull(Value)) {
                HandleException(GenericType.Name + " must equal DBNull.Value");
            }

            return this as TEstablisher;
        }

        public TEstablisher IsNotDBNull() {
            if (Convert.IsDBNull(Value)) {
                HandleException(GenericType.Name + " must not equal DBNull.Value");
            }

            return this as TEstablisher;
        }

        public TEstablisher IsEqualTo(TType constraint) {
            if (!DefaultComparer.Equals(Value, constraint)) {
                HandleException(GenericType.Name + " is not equal to a required constraint");
            }

            return this as TEstablisher;
        }

        public TEstablisher IsNotEqualTo(TType constraint) {
            if (DefaultComparer.Equals(Value, constraint)) {
                HandleException(GenericType.Name + " must not equal a blacklist constraint");
            }

            return this as TEstablisher;
        }

        public TEstablisher Satisfies(Action<TType> action) {
            Establish.ForObject(action).IsNotNull();

            try {
                action(Value);
            }
            catch (Exception ex) {
                HandleException("bool value does not satisfy user action", ex);
            }

            return this as TEstablisher;
        }

        public TEstablisher Satisfies(Func<TType, bool> predicate) {
            Establish.ForObject(predicate).IsNotNull();

            try {
                if (!predicate(Value)) {
                    // failure
                    HandleException("bool value does not satisfy user action");
                }
            }
            catch (Exception ex) {
                // failure
                HandleException("bool value does not satisfy user action", ex);
            }

            return this as TEstablisher;
        }

    }

}
