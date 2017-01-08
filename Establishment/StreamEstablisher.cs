using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class StreamEstablisher {

        public static ClassEstablisher<TStream> CanRead<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanRead) {
                establisher.RaiseException("Stream must be able to be read");
            }

            return establisher;
        }

        public static ClassEstablisher<TStream> CanNotRead<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanRead) {
                establisher.RaiseException("Stream must not be able to be read");
            }

            return establisher;
        }

        public static ClassEstablisher<TStream> CanSeek<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanSeek) {
                establisher.RaiseException("Stream must be able to seek");
            }

            return establisher;
        }

        public static ClassEstablisher<TStream> CanNotSeek<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanSeek) {
                establisher.RaiseException("Stream must not be able to seek");
            }

            return establisher;
        }

        public static ClassEstablisher<TStream> CanTimeout<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanTimeout) {
                establisher.RaiseException("Stream must be able to timeout");
            }

            return establisher;
        }

        public static ClassEstablisher<TStream> CanNotTimeout<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanTimeout) {
                establisher.RaiseException("Stream must not be able to timeout");
            }

            return establisher;
        }

        public static ClassEstablisher<TStream> CanWrite<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (!establisher.Value.CanWrite) {
                establisher.RaiseException("Stream must be able to write");
            }

            return establisher;
        }

        public static ClassEstablisher<TStream> CanNotWrite<TStream>(this ClassEstablisher<TStream> establisher) where TStream : Stream {
            if (establisher.Value.CanWrite) {
                establisher.RaiseException("Stream must not be able to write");
            }

            return establisher;
        }

    }

}
