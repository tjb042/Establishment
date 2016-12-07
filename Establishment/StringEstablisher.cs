using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StringEstablisher : BaseClassEstablisher<string> {

        public bool IsNullOrEmpty(string value) {
            if (!string.IsNullOrEmpty(value)) {
                return HandleFailure(new ArgumentException("string value must be null or empty"));
            }

            return true;
        }

        public bool IsNotNullOrEmpty(string value) {
            if (string.IsNullOrEmpty(value)) {
                return HandleFailure(new ArgumentException("string value must not be null or empty"));
            }

            return true;
        }

    }

}
