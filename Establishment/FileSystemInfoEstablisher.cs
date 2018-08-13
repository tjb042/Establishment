using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class FileSystemInfoEstablisher {

        public static BaseEstablisher<TInfo> Exists<TInfo>(this BaseEstablisher<TInfo> establisher) where TInfo : FileSystemInfo {
            if (!establisher.Value.Exists) {
                establisher.RaiseException(establisher.GenericType.Name + " does not exist");
            }

            return establisher;
        }

        public static BaseEstablisher<TInfo> DoesNotExist<TInfo>(this BaseEstablisher<TInfo> establisher) where TInfo : FileSystemInfo {
            if (establisher.Value.Exists) {
                establisher.RaiseException(establisher.GenericType.Name + " must not exist");
            }

            return establisher;
        }

        public static BaseEstablisher<TInfo> HasExtension<TInfo>(this BaseEstablisher<TInfo> establisher) where TInfo : FileSystemInfo {
            if (string.IsNullOrEmpty(establisher.Value.Extension)) {
                establisher.RaiseException(establisher.GenericType.Name + " must have an extension");
            }

            return establisher;
        }

        public static BaseEstablisher<TInfo> HasNoExtension<TInfo>(this BaseEstablisher<TInfo> establisher) where TInfo : FileSystemInfo {
            if (!string.IsNullOrEmpty(establisher.Value.Extension)) {
                establisher.RaiseException(establisher.GenericType.Name + " must not have an extension");
            }

            return establisher;
        }

    }

}
