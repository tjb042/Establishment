using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StreamEstablisher<TStream> : ClassEstablisher<StreamEstablisher<TStream>, TStream> where TStream : Stream {

        public StreamEstablisher(TStream value) : base(value) {

        }

        public StreamEstablisher<TStream> CanRead() {
            if (!Value.CanRead) {
                HandleException("Stream must be able to be read");
            }

            return this;
        }

        public StreamEstablisher<TStream> CanNotRead() {
            if (Value.CanRead) {
                HandleException("Stream must not be able to be read");
            }

            return this;
        }

        public StreamEstablisher<TStream> CanSeek() {
            if (!Value.CanSeek) {
                HandleException("Stream must be able to seek");
            }

            return this;
        }

        public StreamEstablisher<TStream> CanNotSeek() {
            if (Value.CanSeek) {
                HandleException("Stream must not be able to seek");
            }

            return this;
        }

        public StreamEstablisher<TStream> CanTimeout() {
            if (!Value.CanTimeout) {
                HandleException("Stream must be able to timeout");
            }

            return this;
        }

        public StreamEstablisher<TStream> CanNotTimeout() {
            if (Value.CanTimeout) {
                HandleException("Stream must not be able to timeout");
            }

            return this;
        }

        public StreamEstablisher<TStream> CanWrite() {
            if (!Value.CanWrite) {
                HandleException("Stream must be able to write");
            }

            return this;
        }

        public StreamEstablisher<TStream> CanNotWrite() {
            if (Value.CanWrite) {
                HandleException("Stream must not be able to write");
            }

            return this;
        }

    }

}
