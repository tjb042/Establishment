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
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static ByteEstablisher For(byte input) {
            return new ByteEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static DateTimeEstablisher For(DateTime input) {
            return new DateTimeEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static DecimalEstablisher For(decimal input) {
            return new DecimalEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static DoubleEstablisher For(double input) {
            return new DoubleEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static FloatEstablisher For(float input) {
            return new FloatEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static GuidEstablisher For(Guid input) {
            return new GuidEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static IntegerEstablisher For(int input) {
            return new IntegerEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static LongEstablisher For(long input) {
            return new LongEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static SByteEstablisher For(sbyte input) {
            return new SByteEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static ShortEstablisher For(short input) {
            return new ShortEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static StringEstablisher For(string input) {
            return new StringEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static TimeSpanEstablisher For(TimeSpan input) {
            return new TimeSpanEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static UIntegerEstablisher For(uint input) {
            return new UIntegerEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static ULongEstablisher For(ulong input) {
            return new ULongEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        [CLSCompliant(false)]
        public static UShortEstablisher For(ushort input) {
            return new UShortEstablisher(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static BaseClassEstablisher<TType> ForObject<TType>(TType input) where TType : class {
            return new BaseClassEstablisher<TType>(input) {
                ThrowExceptionOnFailure = Establish.ThrowExceptionOnFailure
            };
        }

        public static bool ThrowExceptionOnFailure {
            get;
            set;
        }

    }

}
