using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class Establish {

        static Establish() {
            ThrowExceptionOnEstablishmentFailure = true;

            // use reflection to set them all
            foreach (var property in typeof(Establish).GetProperties()) {
                if (!property.CanWrite) {
                    continue;
                }

                property.SetValue(null, Activator.CreateInstance(property.PropertyType));
            }
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

        public static bool ThrowExceptionOnEstablishmentFailure { get; set; }

    }

}
