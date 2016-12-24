using Establishment.Models;
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
            return new BooleanEstablisher(input);
        }

        public static BooleanEstablisher For(bool input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new BooleanEstablisher(input) {
                Options = options
            };
        }

        public static ByteEstablisher For(byte input) {
            return new ByteEstablisher(input);
        }

        public static ByteEstablisher For(byte input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new ByteEstablisher(input) {
                Options = options,
            };
        }

        public static CharEstablisher For(char input) {
            return new CharEstablisher(input);
        }

        public static CharEstablisher For(char input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new CharEstablisher(input) {
                Options = options,
            };
        }

        public static DateTimeEstablisher For(DateTime input) {
            return new DateTimeEstablisher(input);
        }

        public static DateTimeEstablisher For(DateTime input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new DateTimeEstablisher(input) {
                Options = options,
            };
        }

        public static DecimalEstablisher For(decimal input) {
            return new DecimalEstablisher(input);
        }

        public static DecimalEstablisher For(decimal input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new DecimalEstablisher(input) {
                Options = options,
            };
        }

        public static DoubleEstablisher For(double input) {
            return new DoubleEstablisher(input);
        }

        public static DoubleEstablisher For(double input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new DoubleEstablisher(input) {
                Options = options,
            };
        }

        public static FloatEstablisher For(float input) {
            return new FloatEstablisher(input);
        }

        public static FloatEstablisher For(float input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new FloatEstablisher(input) {
                Options = options,
            };
        }

        public static GuidEstablisher For(Guid input) {
            return new GuidEstablisher(input);
        }

        public static GuidEstablisher For(Guid input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new GuidEstablisher(input) {
                Options = options,
            };
        }

        public static IntegerEstablisher For(int input) {
            return new IntegerEstablisher(input);
        }

        public static IntegerEstablisher For(int input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new IntegerEstablisher(input) {
                Options = options,
            };
        }

        public static LongEstablisher For(long input) {
            return new LongEstablisher(input);
        }

        public static LongEstablisher For(long input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new LongEstablisher(input) {
                Options = options,
            };
        }

        [CLSCompliant(false)]
        public static SByteEstablisher For(sbyte input) {
            return new SByteEstablisher(input);
        }

        [CLSCompliant(false)]
        public static SByteEstablisher For(sbyte input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new SByteEstablisher(input) {
                Options = options,
            };
        }

        public static ShortEstablisher For(short input) {
            return new ShortEstablisher(input);
        }

        public static ShortEstablisher For(short input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new ShortEstablisher(input) {
                Options = options,
            };
        }

        public static StringEstablisher For(string input) {
            return new StringEstablisher(input);
        }

        public static StringEstablisher For(string input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new StringEstablisher(input) {
                Options = options,
            };
        }

        public static TimeSpanEstablisher For(TimeSpan input) {
            return new TimeSpanEstablisher(input);
        }

        public static TimeSpanEstablisher For(TimeSpan input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new TimeSpanEstablisher(input) {
                Options = options,
            };
        }

        public static TypeEstablisher For(Type input) {
            return new TypeEstablisher(input);
        }

        public static TypeEstablisher For(Type input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new TypeEstablisher(input) {
                Options = options
            };
        }

        [CLSCompliant(false)]
        public static UIntegerEstablisher For(uint input) {
            return new UIntegerEstablisher(input);
        }

        [CLSCompliant(false)]
        public static UIntegerEstablisher For(uint input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new UIntegerEstablisher(input) {
                Options = options,
            };
        }

        [CLSCompliant(false)]
        public static ULongEstablisher For(ulong input) {
            return new ULongEstablisher(input);
        }

        [CLSCompliant(false)]
        public static ULongEstablisher For(ulong input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new ULongEstablisher(input) {
                Options = options,
            };
        }

        [CLSCompliant(false)]
        public static UShortEstablisher For(ushort input) {
            return new UShortEstablisher(input);
        }

        [CLSCompliant(false)]
        public static UShortEstablisher For(ushort input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new UShortEstablisher(input) {
                Options = options,
            };
        }

        public static IEnumerableEstablisher<TSource> For<TSource>(IEnumerable<TSource> input) {
            return new IEnumerableEstablisher<TSource>(input);
        }

        public static IEnumerableEstablisher<TSource> For<TSource>(IEnumerable<TSource> input, EstablisherOptions options) {
            Establish.ForObject(options).IsNotDefault();

            return new IEnumerableEstablisher<TSource>(input) {
                Options = options,
            };
        }

        public static ObjectEstablisher ForObject<TType>(TType input) where TType : class {
            return new ObjectEstablisher(input);
        }

        public static ObjectEstablisher ForObject<TType>(TType input, EstablisherOptions options) where TType : class {
            Establish.ForObject(options).IsNotDefault();

            return new ObjectEstablisher(input) {
                Options = options,
            };
        }

        public static BaseEstablisher<TType> ForStruct<TType>(TType input) where TType : struct {
            return new BaseEstablisher<TType>(input);
        }

        public static BaseEstablisher<TType> ForStruct<TType>(TType input, EstablisherOptions options) where TType : struct {
            Establish.ForObject(options).IsNotDefault();

            return new BaseEstablisher<TType>(input) {
                Options = options,
            };
        }

        public static bool ThrowExceptionOnFailure {
            get;
            set;
        }

    }

}
