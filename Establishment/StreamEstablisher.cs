using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class StreamEstablisher {

        public static BaseEstablisher<TStream> CanRead<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanRead) {
                establisher.RaiseException("Stream must be able to be read");
            }

            return establisher;
        }

        public static BaseEstablisher<TStream> CanNotRead<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanRead) {
                establisher.RaiseException("Stream must not be able to be read");
            }

            return establisher;
        }

        public static BaseEstablisher<TStream> CanSeek<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanSeek) {
                establisher.RaiseException("Stream must be able to seek");
            }

            return establisher;
        }

        public static BaseEstablisher<TStream> CanNotSeek<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanSeek) {
                establisher.RaiseException("Stream must not be able to seek");
            }

            return establisher;
        }

        public static BaseEstablisher<TStream> CanTimeout<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanTimeout) {
                establisher.RaiseException("Stream must be able to timeout");
            }

            return establisher;
        }

        public static BaseEstablisher<TStream> CanNotTimeout<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanTimeout) {
                establisher.RaiseException("Stream must not be able to timeout");
            }

            return establisher;
        }

        public static BaseEstablisher<TStream> CanWrite<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanWrite) {
                establisher.RaiseException("Stream must be able to write");
            }

            return establisher;
        }

        public static BaseEstablisher<TStream> CanNotWrite<TStream>(this BaseEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanWrite) {
                establisher.RaiseException("Stream must not be able to write");
            }

            return establisher;
        }

    }

}
