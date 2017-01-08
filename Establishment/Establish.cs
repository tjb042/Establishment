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

        public static StructEstablisher<TType> ForStruct<TType>(TType value) where TType : struct {
            return new StructEstablisher<TType>(value);
        }

        public static StructEstablisher<TType> ForStruct<TType>(TType value, string parameterName) where TType : struct {
            Establish.ForObject(parameterName).IsNotNullOrEmpty();

            return new StructEstablisher<TType>(value) {
                Options = new EstablisherOptions() {
                    ParameterName = parameterName
                }
            };
        }

        public static StructEstablisher<TType> ForStruct<TType>(TType value, EstablisherOptions options) where TType : struct {
            Establish.ForObject(options).IsNotNull();

            return new StructEstablisher<TType>(value) {
                Options = options
            };
        }

        public static ClassEstablisher<TType> ForObject<TType>(TType value) where TType : class {
            return new ClassEstablisher<TType>(value);
        }

        public static ClassEstablisher<TType> ForObject<TType>(TType value, string parameterName) where TType : class {
            Establish.ForObject(parameterName).IsNotNullOrEmpty();

            return new ClassEstablisher<TType>(value) {
                Options = new EstablisherOptions() {
                    ParameterName = parameterName
                }
            };
        }

        public static ClassEstablisher<TType> ForObject<TType>(TType value, EstablisherOptions options) where TType : class {
            Establish.ForObject(options).IsNotNull();

            return new ClassEstablisher<TType>(value) {
                Options = options
            };
        }

        public static bool ThrowExceptionOnFailure {
            get;
            set;
        }

    }

}
