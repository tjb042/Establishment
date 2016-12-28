using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class FileSystemInfoEstablisher<TInfo> : ClassEstablisher<FileSystemInfoEstablisher<TInfo>, TInfo> where TInfo : FileSystemInfo {

        public FileSystemInfoEstablisher(TInfo value) : base(value) {

        }

        public FileSystemInfoEstablisher<TInfo> Exists() {
            if (!Value.Exists) {
                HandleException(GenericType.Name + " does not exist");
            }

            return this;
        }

        public FileSystemInfoEstablisher<TInfo> DoesNotExist() {
            if (Value.Exists) {
                HandleException(GenericType.Name + " must not exist");
            }

            return this;
        }

        public FileSystemInfoEstablisher<TInfo> HasExtension() {
            if (string.IsNullOrEmpty(Value.Extension)) {
                HandleException(GenericType.Name + " must have an extension");
            }

            return this;
        }

        public FileSystemInfoEstablisher<TInfo> HasNoExtension() {
            if (!string.IsNullOrEmpty(Value.Extension)) {
                HandleException(GenericType.Name + " must not have an extension");
            }

            return this;
        }

    }

}
