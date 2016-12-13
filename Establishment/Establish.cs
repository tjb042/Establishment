using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class Establish {

        private static bool _throwExceptionOnFailure;
        private static readonly IEnumerable<BaseEstablisher> _establishers;

        static Establish() {
            _throwExceptionOnFailure = true;

            // use reflection to set them all
            var establishers = new List<BaseEstablisher>(16);
            foreach (var property in typeof(Establish).GetProperties()) {
                if (!property.CanWrite) {
                    continue;
                }

                var establisher = Activator.CreateInstance(property.PropertyType);
                property.SetValue(null, establisher);

                if (establisher is BaseEstablisher) {
                    establishers.Add(establisher as BaseEstablisher);
                }
            }

            _establishers = establishers;
        }

        public static BaseClassEstablisher<object> ReferenceType { get; private set; }

        public static StringEstablisher String { get; private set; }

        public static GuidEstablisher Guid { get; private set; }

        public static BooleanEstablisher Bool { get; private set; }

        public static ByteEstablisher Byte { get; private set; }

        public static ShortEstablisher Short { get; private set; }

        public static IntegerEstablisher Int { get; private set; }

        public static LongEstablisher Long { get; private set; }

        public static DecimalEstablisher Decimal { get; private set; }

        public static FloatEstablisher Float { get; private set; }

        public static DoubleEstablisher Double { get; private set; }

        public static DateTimeEstablisher DateTime { get; private set; }

        public static TimeSpanEstablisher TimeSpan { get; private set; }

        public static bool ThrowExceptionOnEstablishmentFailure {
            get {
                return _throwExceptionOnFailure;
            }
            set {
                if (value == _throwExceptionOnFailure) {
                    return;
                }

                foreach (var establisher in _establishers) {
                    establisher.ThrowExceptionOnEstablishmentFailure = value;
                }
            }
        }

    }

}
