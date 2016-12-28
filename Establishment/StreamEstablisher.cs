using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class StreamEstablisher<TStream> : BaseEstablisher<TStream>, IClassEstablisher<StreamEstablisher<TStream>, TStream> where TStream : Stream {

        internal StreamEstablisher(TStream value) : base(value) {

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

        public StreamEstablisher<TStream> IsNull() {
            return base.IsDefault<StreamEstablisher<TStream>>();
        }

        public StreamEstablisher<TStream> IsNotNull() {
            return base.IsNotDefault<StreamEstablisher<TStream>>();
        }

        public StreamEstablisher<TStream> IsEqualTo(TStream constraint) {
            return base.IsEqualTo<StreamEstablisher<TStream>>(constraint);
        }

        public StreamEstablisher<TStream> IsNotEqualTo(TStream constraint) {
            return base.IsNotEqualTo<StreamEstablisher<TStream>>(constraint);
        }

        public StreamEstablisher<TStream> Satisfies(Action<TStream> action) {
            return base.Satisfies<StreamEstablisher<TStream>>(action);
        }

        public StreamEstablisher<TStream> Satisfies(Func<TStream, bool> predicate) {
            return base.Satisfies<StreamEstablisher<TStream>>(predicate);
        }

    }

}
