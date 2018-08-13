using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public static class TypeEstablisher {

        public static BaseEstablisher<Type> IsClass(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsClass) {
                establisher.RaiseException("Type must represent a class");
            }

            return establisher;
        }

        public static BaseEstablisher<Type> IsNotClass(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsClass) {
                establisher.RaiseException("Type must not represent a class");
            }

            return establisher;
        }

        public static BaseEstablisher<Type> IsEnum(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsEnum) {
                establisher.RaiseException("Type must reprsent an enum");
            }

            return establisher;
        }

        public static BaseEstablisher<Type> IsNotEnum(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsEnum) {
                establisher.RaiseException("Type must not reprsent an enum");
            }

            return establisher;
        }

        public static BaseEstablisher<Type> HasGenericParameters(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.ContainsGenericParameters) {
                establisher.RaiseException("Type must contain generic parameters");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> HasNoGenericParameters(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.ContainsGenericParameters) {
                establisher.RaiseException("Type must not contain generic parameters");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsAbstract(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsAbstract) {
                establisher.RaiseException("Type must be abstract");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotAbstract(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsAbstract) {
                establisher.RaiseException("Type must not be abstract");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsArray(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsArray) {
                establisher.RaiseException("Type must be an array");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotArray(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsArray) {
                establisher.RaiseException("Type must not be an array");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsByRef(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsByRef) {
                establisher.RaiseException("Type must be passed by ref");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotByRef(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsByRef) {
                establisher.RaiseException("Type must not be passed by ref");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsCOMObject(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsCOMObject) {
                establisher.RaiseException("Type must be a COM object");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotCOMObject(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsCOMObject) {
                establisher.RaiseException("Type must not be a COM object");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsConstructedGenericType(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsConstructedGenericType) {
                establisher.RaiseException("Type must be a constructed generic type");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotConstructedGenericType(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsConstructedGenericType) {
                establisher.RaiseException("Type must not be a constructed generic type");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsContextful(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsContextful) {
                establisher.RaiseException("Type must be contextful");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotContextful(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsContextful) {
                establisher.RaiseException("Type must not be contextful");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsGenericParameter(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsGenericParameter) {
                establisher.RaiseException("Type must be a generic parameter");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotGenericParameter(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsGenericParameter) {
                establisher.RaiseException("Type must not be a generic parameter");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsGenericTypeDefinition(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsGenericTypeDefinition) {
                establisher.RaiseException("Type must be a generic type definition");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotGenericTypeDefinition(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsGenericTypeDefinition) {
                establisher.RaiseException("Type must not be a generic type definition");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsImport(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsImport) {
                establisher.RaiseException("Type must be an import");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotImport(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsImport) {
                establisher.RaiseException("Type must not be an import");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsInterface(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsInterface) {
                establisher.RaiseException("Type must be an interface");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotInterface(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsInterface) {
                establisher.RaiseException("Type must not be an interface");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsMarshalByRef(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsMarshalByRef) {
                establisher.RaiseException("Type must be marshal by ref");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotMarshalByRef(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsMarshalByRef) {
                establisher.RaiseException("Type must not be marshal by ref");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNested(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsNested) {
                establisher.RaiseException("Type must be nested");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotNested(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsNested) {
                establisher.RaiseException("Type must not be nested");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsPublic(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsPublic) {
                establisher.RaiseException("Type must be public");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotPublic(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsPublic) {
                establisher.RaiseException("Type must not be public");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsPointer(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsPointer) {
                establisher.RaiseException("Type must be a pointer");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotPointer(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsPointer) {
                establisher.RaiseException("Type must not be a pointer");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsPrimitive(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsPrimitive) {
                establisher.RaiseException("Type must be a primitive");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotPrimitive(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsPrimitive) {
                establisher.RaiseException("Type must not be a primitive");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsSealed(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsSealed) {
                establisher.RaiseException("Type must be sealed");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotSealed(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsSealed) {
                establisher.RaiseException("Type must not be sealed");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsSecurityCritical(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsSecurityCritical) {
                establisher.RaiseException("Type must be security critical");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotSecurityCritical(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsSecurityCritical) {
                establisher.RaiseException("Type must not be security critical");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsSecuritySafeCritical(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsSecuritySafeCritical) {
                establisher.RaiseException("Type must be security safe critical");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotSecuritySafeCritical(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsSecuritySafeCritical) {
                establisher.RaiseException("Type must not be security safe critical");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsSecurityTransparent(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsSecurityTransparent) {
                establisher.RaiseException("Type must be security transparent");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotSecurityTransparent(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsSecurityTransparent) {
                establisher.RaiseException("Type must not be security transparent");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsSerializable(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsSerializable) {
                establisher.RaiseException("Type must be serializable");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotSerializable(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsSerializable) {
                establisher.RaiseException("Type must not be serializable");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsValueType(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsValueType) {
                establisher.RaiseException("Type must be a value type");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotValueType(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsValueType) {
                establisher.RaiseException("Type must not be a value type");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsVisible(this BaseEstablisher<Type> establisher) {
            if (!establisher.Value.IsVisible) {
                establisher.RaiseException("Type must be visible");
            }

            return establisher;
        }
        
        public static BaseEstablisher<Type> IsNotVisible(this BaseEstablisher<Type> establisher) {
            if (establisher.Value.IsVisible) {
                establisher.RaiseException("Type must not be visible");
            }

            return establisher;
        }

    }

}
