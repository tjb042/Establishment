using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class Establish {

        static Establish() {
            ThrowExceptionOnFailure = true;
        }

        public static BooleanEstablisher For(bool input) {
            return new BooleanEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static BooleanEstablisher For(bool input, string parameterName) {
            return new BooleanEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static ByteEstablisher For(byte input) {
            return new ByteEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static ByteEstablisher For(byte input, string parameterName) {
            return new ByteEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static CharEstablisher For(char input) {
            return new CharEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static CharEstablisher For(char input, string parameterName) {
            return new CharEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static DateTimeEstablisher For(DateTime input) {
            return new DateTimeEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static DateTimeEstablisher For(DateTime input, string parameterName) {
            return new DateTimeEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static DecimalEstablisher For(decimal input) {
            return new DecimalEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static DecimalEstablisher For(decimal input, string parameterName) {
            return new DecimalEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static DoubleEstablisher For(double input) {
            return new DoubleEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static DoubleEstablisher For(double input, string parameterName) {
            return new DoubleEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static FloatEstablisher For(float input) {
            return new FloatEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static FloatEstablisher For(float input, string parameterName) {
            return new FloatEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static GuidEstablisher For(Guid input) {
            return new GuidEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static GuidEstablisher For(Guid input, string parameterName) {
            return new GuidEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static IntegerEstablisher For(int input) {
            return new IntegerEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static IntegerEstablisher For(int input, string parameterName) {
            return new IntegerEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static LongEstablisher For(long input) {
            return new LongEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
            };
        }

        public static LongEstablisher For(long input, string parameterName) {
            return new LongEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        [CLSCompliant(false)]
        public static SByteEstablisher For(sbyte input) {
            return new SByteEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static SByteEstablisher For(sbyte input, string parameterName) {
            return new SByteEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static ShortEstablisher For(short input) {
            return new ShortEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static ShortEstablisher For(short input, string parameterName) {
            return new ShortEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static StringEstablisher For(string input) {
            return new StringEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static StringEstablisher For(string input, string parameterName) {
            return new StringEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static TimeSpanEstablisher For(TimeSpan input) {
            return new TimeSpanEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static TimeSpanEstablisher For(TimeSpan input, string parameterName) {
            return new TimeSpanEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        [CLSCompliant(false)]
        public static UIntegerEstablisher For(uint input) {
            return new UIntegerEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static UIntegerEstablisher For(uint input, string parameterName) {
            return new UIntegerEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        [CLSCompliant(false)]
        public static ULongEstablisher For(ulong input) {
            return new ULongEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static ULongEstablisher For(ulong input, string parameterName) {
            return new ULongEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        [CLSCompliant(false)]
        public static UShortEstablisher For(ushort input) {
            return new UShortEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static UShortEstablisher For(ushort input, string parameterName) {
            return new UShortEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static BaseEstablisher<TType> ForObject<TType>(TType input) where TType : class {
            return new BaseEstablisher<TType>(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static BaseEstablisher<TType> ForObject<TType>(TType input, string parameterName) where TType : class {
            return new BaseEstablisher<TType>(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static BaseEstablisher<TType> ForStruct<TType>(TType input) where TType : struct {
            return new BaseEstablisher<TType>(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static BaseEstablisher<TType> ForStruct<TType>(TType input, string parameterName) where TType : struct {
            return new BaseEstablisher<TType>(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure,
                ParameterName = parameterName
            };
        }

        public static bool ThrowExceptionOnFailure {
            get;
            set;
        }

    }

}
