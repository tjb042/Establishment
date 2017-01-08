using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class TypeEstablisher {

        public static ClassEstablisher<Type> IsClass(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsClass) {
                establisher.RaiseException("Type must represent a class");
            }

            return establisher;
        }

        public static ClassEstablisher<Type> IsNotClass(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsClass) {
                establisher.RaiseException("Type must not represent a class");
            }

            return establisher;
        }

        public static ClassEstablisher<Type> IsEnum(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsEnum) {
                establisher.RaiseException("Type must reprsent an enum");
            }

            return establisher;
        }

        public static ClassEstablisher<Type> IsNotEnum(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsEnum) {
                establisher.RaiseException("Type must not reprsent an enum");
            }

            return establisher;
        }

        public static ClassEstablisher<Type> HasGenericParameters(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.ContainsGenericParameters) {
                establisher.RaiseException("Type must contain generic parameters");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> HasNoGenericParameters(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.ContainsGenericParameters) {
                establisher.RaiseException("Type must not contain generic parameters");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsAbstract(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsAbstract) {
                establisher.RaiseException("Type must be abstract");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotAbstract(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsAbstract) {
                establisher.RaiseException("Type must not be abstract");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsArray(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsArray) {
                establisher.RaiseException("Type must be an array");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotArray(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsArray) {
                establisher.RaiseException("Type must not be an array");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsByRef(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsByRef) {
                establisher.RaiseException("Type must be passed by ref");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotByRef(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsByRef) {
                establisher.RaiseException("Type must not be passed by ref");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsCOMObject(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsCOMObject) {
                establisher.RaiseException("Type must be a COM object");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotCOMObject(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsCOMObject) {
                establisher.RaiseException("Type must not be a COM object");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsConstructedGenericType(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsConstructedGenericType) {
                establisher.RaiseException("Type must be a constructed generic type");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotConstructedGenericType(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsConstructedGenericType) {
                establisher.RaiseException("Type must not be a constructed generic type");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsContextful(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsContextful) {
                establisher.RaiseException("Type must be contextful");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotContextful(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsContextful) {
                establisher.RaiseException("Type must not be contextful");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsGenericParameter(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsGenericParameter) {
                establisher.RaiseException("Type must be a generic parameter");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotGenericParameter(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsGenericParameter) {
                establisher.RaiseException("Type must not be a generic parameter");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsGenericTypeDefinition(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsGenericTypeDefinition) {
                establisher.RaiseException("Type must be a generic type definition");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotGenericTypeDefinition(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsGenericTypeDefinition) {
                establisher.RaiseException("Type must not be a generic type definition");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsImport(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsImport) {
                establisher.RaiseException("Type must be an import");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotImport(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsImport) {
                establisher.RaiseException("Type must not be an import");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsInterface(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsInterface) {
                establisher.RaiseException("Type must be an interface");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotInterface(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsInterface) {
                establisher.RaiseException("Type must not be an interface");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsMarshalByRef(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsMarshalByRef) {
                establisher.RaiseException("Type must be marshal by ref");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotMarshalByRef(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsMarshalByRef) {
                establisher.RaiseException("Type must not be marshal by ref");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNested(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsNested) {
                establisher.RaiseException("Type must be nested");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotNested(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsNested) {
                establisher.RaiseException("Type must not be nested");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsPublic(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsPublic) {
                establisher.RaiseException("Type must be public");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotPublic(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsPublic) {
                establisher.RaiseException("Type must not be public");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsPointer(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsPointer) {
                establisher.RaiseException("Type must be a pointer");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotPointer(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsPointer) {
                establisher.RaiseException("Type must not be a pointer");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsPrimitive(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsPrimitive) {
                establisher.RaiseException("Type must be a primitive");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotPrimitive(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsPrimitive) {
                establisher.RaiseException("Type must not be a primitive");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsSealed(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsSealed) {
                establisher.RaiseException("Type must be sealed");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotSealed(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsSealed) {
                establisher.RaiseException("Type must not be sealed");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsSecurityCritical(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsSecurityCritical) {
                establisher.RaiseException("Type must be security critical");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotSecurityCritical(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsSecurityCritical) {
                establisher.RaiseException("Type must not be security critical");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsSecuritySafeCritical(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsSecuritySafeCritical) {
                establisher.RaiseException("Type must be security safe critical");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotSecuritySafeCritical(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsSecuritySafeCritical) {
                establisher.RaiseException("Type must not be security safe critical");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsSecurityTransparent(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsSecurityTransparent) {
                establisher.RaiseException("Type must be security transparent");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotSecurityTransparent(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsSecurityTransparent) {
                establisher.RaiseException("Type must not be security transparent");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsSerializable(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsSerializable) {
                establisher.RaiseException("Type must be serializable");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotSerializable(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsSerializable) {
                establisher.RaiseException("Type must not be serializable");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsValueType(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsValueType) {
                establisher.RaiseException("Type must be a value type");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotValueType(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsValueType) {
                establisher.RaiseException("Type must not be a value type");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsVisible(this ClassEstablisher<Type> establisher) {
            if (!establisher.Value.IsVisible) {
                establisher.RaiseException("Type must be visible");
            }

            return establisher;
        }
        
        public static ClassEstablisher<Type> IsNotVisible(this ClassEstablisher<Type> establisher) {
            if (establisher.Value.IsVisible) {
                establisher.RaiseException("Type must not be visible");
            }

            return establisher;
        }

    }

}
