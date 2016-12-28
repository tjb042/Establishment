using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class ClassEstablisher<TEstablisher, TType> : BaseEstablisher<TType> where TType : class where TEstablisher : ClassEstablisher<TEstablisher, TType> {

        public ClassEstablisher(TType value) : base(value) {

        }

            if (!DefaultComparer.Equals(Value, DefaultTypeValue)) {
                HandleException(GenericType.Name + " must equal its default value");
            }

            return this as TEstablisher;
        }

            if (DefaultComparer.Equals(Value, DefaultTypeValue)) {
                HandleException(GenericType.Name + " must not equal its default value");
            }

            return this as TEstablisher;
        }

            if (!Convert.IsDBNull(Value)) {
                HandleException(GenericType.Name + " must equal DBNull.Value");
            }

            return this as TEstablisher;
        }

            if (Convert.IsDBNull(Value)) {
                HandleException(GenericType.Name + " must not equal DBNull.Value");
            }

            return this as TEstablisher;
        }

            if (!DefaultComparer.Equals(Value, constraint)) {
                HandleException(GenericType.Name + " is not equal to a required constraint");
            }

            return this as TEstablisher;
        }

            if (DefaultComparer.Equals(Value, constraint)) {
                HandleException(GenericType.Name + " must not equal a blacklist constraint");
            }

            return this as TEstablisher;
        }


            try {
                action(Value);
            }
            catch (Exception ex) {
                HandleException("bool value does not satisfy user action", ex);
            }

            return this as TEstablisher;
        }


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
