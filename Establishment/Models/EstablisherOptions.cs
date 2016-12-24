using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment.Models {

    public class EstablisherOptions {

        private string _parameterName = null;

        /// <summary>
        /// If provided, the name of the parameter wrapped by this instance.
        /// </summary>
        public string ParameterName {
            get {
                return _parameterName;
            }
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    this._parameterName = null;
                }
                else {
                    this._parameterName = value.Trim();
                }
            }
        }

        /// <summary>
        /// Indicates if a test should throw an exception is a value does not meet the supplied criteria, or fail silently
        /// </summary>
        public bool? ThrowExceptionOnFailure { get; set; }

    }

}
