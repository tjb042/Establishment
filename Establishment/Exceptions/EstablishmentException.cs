using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Exceptions {

    [Serializable]
    public class EstablishmentException : ArgumentException {

        public EstablishmentException() { }

        public EstablishmentException(string message) : base(message) { }

        public EstablishmentException(string message, Exception innerException) : base(message, innerException) { }

        public EstablishmentException(string message, string paramName) : base(message, paramName) { }

        public EstablishmentException(string message, string paramName, Exception innerException) : base(message, paramName, innerException) { }

    }

}
