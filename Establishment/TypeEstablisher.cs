using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class TypeEstablisher : BaseEstablisher<Type>, IClassEstablisher<TypeEstablisher, Type> {

        public TypeEstablisher IsClass() {
            if (!Value.IsClass) {
                HandleException("Type must represent a class");
            }

            return this;
        }

        public TypeEstablisher IsNotClass() {
            if (Value.IsClass) {
                HandleException("Type must not represent a class");
            }

            return this;
        }

        public TypeEstablisher IsEnum() {
            if (!Value.IsEnum) {
                HandleException("Type must reprsent an enum");
            }

            return this;
        }

        public TypeEstablisher IsNotEnum() {
            if (Value.IsEnum) {
                HandleException("Type must not reprsent an enum");
            }

            return this;
        }

        public TypeEstablisher HasGenericParameters() {
            if (!Value.ContainsGenericParameters) {
                HandleException("Type must contain generic parameters");
            }

            return this;
        }
        
        public TypeEstablisher HasNoGenericParameters() {
            if (Value.ContainsGenericParameters) {
                HandleException("Type must not contain generic parameters");
            }

            return this;
        }
        
        public TypeEstablisher IsAbstract() {
            if (!Value.IsAbstract) {
                HandleException("Type must be abstract");
            }

            return this;
        }
        
        public TypeEstablisher IsNotAbstract() {
            if (Value.IsAbstract) {
                HandleException("Type must not be abstract");
            }

            return this;
        }
        
        public TypeEstablisher IsArray() {
            if (!Value.IsArray) {
                HandleException("Type must be an array");
            }

            return this;
        }
        
        public TypeEstablisher IsNotArray() {
            if (Value.IsArray) {
                HandleException("Type must not be an array");
            }

            return this;
        }
        
        public TypeEstablisher IsByRef() {
            if (!Value.IsByRef) {
                HandleException("Type must be passed by ref");
            }

            return this;
        }
        
        public TypeEstablisher IsNotByRef() {
            if (Value.IsByRef) {
                HandleException("Type must not be passed by ref");
            }

            return this;
        }
        
        public TypeEstablisher IsCOMObject() {
            if (!Value.IsCOMObject) {
                HandleException("Type must be a COM object");
            }

            return this;
        }
        
        public TypeEstablisher IsNotCOMObject() {
            if (Value.IsCOMObject) {
                HandleException("Type must not be a COM object");
            }

            return this;
        }
        
        public TypeEstablisher IsConstructedGenericType() {
            if (!Value.IsConstructedGenericType) {
                HandleException("Type must be a constructed generic type");
            }

            return this;
        }
        
        public TypeEstablisher IsNotConstructedGenericType() {
            if (Value.IsConstructedGenericType) {
                HandleException("Type must not be a constructed generic type");
            }

            return this;
        }
        
        public TypeEstablisher IsContextful() {
            if (!Value.IsContextful) {
                HandleException("Type must be contextful");
            }

            return this;
        }
        
        public TypeEstablisher IsNotContextful() {
            if (Value.IsContextful) {
                HandleException("Type must not be contextful");
            }

            return this;
        }
        
        public TypeEstablisher IsGenericParameter() {
            if (!Value.IsGenericParameter) {
                HandleException("Type must be a generic parameter");
            }

            return this;
        }
        
        public TypeEstablisher IsNotGenericParameter() {
            if (Value.IsGenericParameter) {
                HandleException("Type must not be a generic parameter");
            }

            return this;
        }
        
        public TypeEstablisher IsGenericTypeDefinition() {
            if (!Value.IsGenericTypeDefinition) {
                HandleException("Type must be a generic type definition");
            }

            return this;
        }
        
        public TypeEstablisher IsNotGenericTypeDefinition() {
            if (Value.IsGenericTypeDefinition) {
                HandleException("Type must not be a generic type definition");
            }

            return this;
        }
        
        public TypeEstablisher IsImport() {
            if (!Value.IsImport) {
                HandleException("Type must be an import");
            }

            return this;
        }
        
        public TypeEstablisher IsNotImport() {
            if (Value.IsImport) {
                HandleException("Type must not be an import");
            }

            return this;
        }
        
        public TypeEstablisher IsInterface() {
            if (!Value.IsInterface) {
                HandleException("Type must be an interface");
            }

            return this;
        }
        
        public TypeEstablisher IsNotInterface() {
            if (Value.IsInterface) {
                HandleException("Type must not be an interface");
            }

            return this;
        }
        
        public TypeEstablisher IsMarshalByRef() {
            if (!Value.IsMarshalByRef) {
                HandleException("Type must be marshal by ref");
            }

            return this;
        }
        
        public TypeEstablisher IsNotMarshalByRef() {
            if (Value.IsMarshalByRef) {
                HandleException("Type must not be marshal by ref");
            }

            return this;
        }
        
        public TypeEstablisher IsNested() {
            if (!Value.IsNested) {
                HandleException("Type must be nested");
            }

            return this;
        }
        
        public TypeEstablisher IsNotNested() {
            if (Value.IsNested) {
                HandleException("Type must not be nested");
            }

            return this;
        }
        
        public TypeEstablisher IsPublic() {
            if (!Value.IsPublic) {
                HandleException("Type must be public");
            }

            return this;
        }
        
        public TypeEstablisher IsNotPublic() {
            if (Value.IsPublic) {
                HandleException("Type must not be public");
            }

            return this;
        }
        
        public TypeEstablisher IsPointer() {
            if (!Value.IsPointer) {
                HandleException("Type must be a pointer");
            }

            return this;
        }
        
        public TypeEstablisher IsNotPointer() {
            if (Value.IsPointer) {
                HandleException("Type must not be a pointer");
            }

            return this;
        }
        
        public TypeEstablisher IsPrimitive() {
            if (!Value.IsPrimitive) {
                HandleException("Type must be a primitive");
            }

            return this;
        }
        
        public TypeEstablisher IsNotPrimitive() {
            if (Value.IsPrimitive) {
                HandleException("Type must not be a primitive");
            }

            return this;
        }
        
        public TypeEstablisher IsSealed() {
            if (!Value.IsSealed) {
                HandleException("Type must be sealed");
            }

            return this;
        }
        
        public TypeEstablisher IsNotSealed() {
            if (Value.IsSealed) {
                HandleException("Type must not be sealed");
            }

            return this;
        }
        
        public TypeEstablisher IsSecurityCritical() {
            if (!Value.IsSecurityCritical) {
                HandleException("Type must be security critical");
            }

            return this;
        }
        
        public TypeEstablisher IsNotSecurityCritical() {
            if (Value.IsSecurityCritical) {
                HandleException("Type must not be security critical");
            }

            return this;
        }
        
        public TypeEstablisher IsSecuritySafeCritical() {
            if (!Value.IsSecuritySafeCritical) {
                HandleException("Type must be security safe critical");
            }

            return this;
        }
        
        public TypeEstablisher IsNotSecuritySafeCritical() {
            if (Value.IsSecuritySafeCritical) {
                HandleException("Type must not be security safe critical");
            }

            return this;
        }
        
        public TypeEstablisher IsSecurityTransparent() {
            if (!Value.IsSecurityTransparent) {
                HandleException("Type must be security transparent");
            }

            return this;
        }
        
        public TypeEstablisher IsNotSecurityTransparent() {
            if (Value.IsSecurityTransparent) {
                HandleException("Type must not be security transparent");
            }

            return this;
        }
        
        public TypeEstablisher IsSerializable() {
            if (!Value.IsSerializable) {
                HandleException("Type must be serializable");
            }

            return this;
        }
        
        public TypeEstablisher IsNotSerializable() {
            if (Value.IsSerializable) {
                HandleException("Type must not be serializable");
            }

            return this;
        }
        
        public TypeEstablisher IsValueType() {
            if (!Value.IsValueType) {
                HandleException("Type must be a value type");
            }

            return this;
        }
        
        public TypeEstablisher IsNotValueType() {
            if (Value.IsValueType) {
                HandleException("Type must not be a value type");
            }

            return this;
        }
        
        public TypeEstablisher IsVisible() {
            if (!Value.IsVisible) {
                HandleException("Type must be visible");
            }

            return this;
        }
        
        public TypeEstablisher IsNotVisible() {
            if (Value.IsVisible) {
                HandleException("Type must not be visible");
            }

            return this;
        }

        public TypeEstablisher IsNull() {
            return base.IsDefault<TypeEstablisher>();
        }

        public TypeEstablisher IsNotNull() {
            return base.IsNotDefault<TypeEstablisher>();
        }

        public TypeEstablisher IsEqualTo(Type constraint) {
            return base.IsEqualTo<TypeEstablisher>(constraint);
        }

        public TypeEstablisher IsNotEqualTo(Type constraint) {
            return base.IsNotEqualTo<TypeEstablisher>(constraint);
        }

    }

}
