using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public abstract class BaseEstablisher<TType> {

        protected BaseEstablisher(TType value) {
            Value = value;
            ThrowExceptionOnFailure = true;
            GenericType = typeof(TType);
            DefaultComparer = EqualityComparer<TType>.Default;
        }

        public TType Value {
            get;
            protected set;
        }

        protected Type GenericType {
            get;
            private set;
        }

        protected IEqualityComparer<TType> DefaultComparer {
            get;
            private set;
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
