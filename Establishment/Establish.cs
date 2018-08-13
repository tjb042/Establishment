using Establishment.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class Establish {

        static Establish() {
            ThrowExceptionOnFailure = true;
        }

        public static BaseEstablisher<TType> For<TType>(TType value) {
            return new BaseEstablisher<TType>(value);
        }

        public static BaseEstablisher<TType> For<TType>(TType value, string parameterName) {
            For(parameterName).IsNotNullOrEmpty();

            return new BaseEstablisher<TType>(value) {
                Options = new EstablisherOptions() {
                    ParameterName = parameterName
                }
            };
        }

        public static BaseEstablisher<TType> For<TType>(TType value, EstablisherOptions options) {
            For(options).IsNotNull();

            return new BaseEstablisher<TType>(value) {
                Options = options
            };
        }

        public static bool ThrowExceptionOnFailure {
            get;
            set;
        }

    }

}
