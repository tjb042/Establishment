using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public abstract class BaseEstablisher<TType> {

        public BaseEstablisher(TType value) {
            Value = value;
            ThrowExceptionOnFailure = true;
        }

        public TType Value {
            get;
            protected set;
        }

        public bool HasExceptions {
            get;
            protected set;
        }

        public Exception LastException {
            get;
            protected set;
        }

        public bool ThrowExceptionOnFailure { 
            get; 
            set; 
        }

        protected virtual void HandleFailure(Exception ex) {
            HasExceptions = true;
            LastException = ex;

            if (ThrowExceptionOnFailure) {
                throw ex;
            }
        }

    }

}
