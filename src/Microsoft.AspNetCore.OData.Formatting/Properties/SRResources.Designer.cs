﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.OData.Formatting {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SRResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.OData.Formatting.Properties.SRResources", typeof(SRResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be of type &apos;{0}&apos;..
        /// </summary>
        internal static string ArgumentMustBeOfType {
            get {
                return ResourceManager.GetString("ArgumentMustBeOfType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on type &apos;{1}&apos; returned a null value. The input stream contains collection items which cannot be added if the instance is null..
        /// </summary>
        internal static string CannotAddToNullCollection {
            get {
                return ResourceManager.GetString("CannotAddToNullCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; does not exist on type &apos;{1}&apos;. Make sure to only use property names that are defined by the type..
        /// </summary>
        internal static string CannotDeserializeUnknownProperty {
            get {
                return ResourceManager.GetString("CannotDeserializeUnknownProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance of the abstract resource type &apos;{0}&apos; was found. Abstract resource types cannot be instantiated..
        /// </summary>
        internal static string CannotInstantiateAbstractResourceType {
            get {
                return ResourceManager.GetString("CannotInstantiateAbstractResourceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot apply PATCH to navigation property &apos;{0}&apos; on entity type &apos;{1}&apos;..
        /// </summary>
        internal static string CannotPatchNavigationProperties {
            get {
                return ResourceManager.GetString("CannotPatchNavigationProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dynamic dictionary property &apos;{0}&apos; of type &apos;{1}&apos; cannot be set. The dynamic property dictionary must have a setter..
        /// </summary>
        internal static string CannotSetDynamicPropertyDictionary {
            get {
                return ResourceManager.GetString("CannotSetDynamicPropertyDictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot write an object of type &apos;{1}&apos;..
        /// </summary>
        internal static string CannotWriteType {
            get {
                return ResourceManager.GetString("CannotWriteType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; of the parameter &apos;{1}&apos; does not have an Add method. Consider using a collection type that does have an Add method - for example IList&lt;T&gt; or ICollection&lt;T&gt;..
        /// </summary>
        internal static string CollectionParameterShouldHaveAddMethod {
            get {
                return ResourceManager.GetString("CollectionParameterShouldHaveAddMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; of the property &apos;{1}&apos; on type &apos;{2}&apos; does not have an Add method. Consider using a collection type that does have an Add method - for example IList&lt;T&gt; or ICollection&lt;T&gt;..
        /// </summary>
        internal static string CollectionShouldHaveAddMethod {
            get {
                return ResourceManager.GetString("CollectionShouldHaveAddMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; of the property &apos;{1}&apos; on type &apos;{2}&apos; does not have a Clear method. Consider using a collection type that does have a Clear method, such as IList&lt;T&gt; or ICollection&lt;T&gt;..
        /// </summary>
        internal static string CollectionShouldHaveClearMethod {
            get {
                return ResourceManager.GetString("CollectionShouldHaveClearMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not support CreateODataValue..
        /// </summary>
        internal static string CreateODataValueNotSupported {
            get {
                return ResourceManager.GetString("CreateODataValueNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actual entity type &apos;{0}&apos; is not assignable to the expected type &apos;{1}&apos;..
        /// </summary>
        internal static string DeltaEntityTypeNotAssignable {
            get {
                return ResourceManager.GetString("DeltaEntityTypeNotAssignable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find nested resource name &apos;{0}&apos; in parent resource type &apos;{1}&apos;.
        /// </summary>
        internal static string DeltaNestedResourceNameNotFound {
            get {
                return ResourceManager.GetString("DeltaNestedResourceNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use Delta of type &apos;{0}&apos; on an entity of type &apos;{1}&apos;..
        /// </summary>
        internal static string DeltaTypeMismatch {
            get {
                return ResourceManager.GetString("DeltaTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not support Read..
        /// </summary>
        internal static string DeserializerDoesNotSupportRead {
            get {
                return ResourceManager.GetString("DeserializerDoesNotSupportRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not support ReadInline..
        /// </summary>
        internal static string DoesNotSupportReadInLine {
            get {
                return ResourceManager.GetString("DoesNotSupportReadInLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate dynamic property name &apos;{0}&apos; found in open type &apos;{1}&apos;. Each dynamic property name must be unique..
        /// </summary>
        internal static string DuplicateDynamicPropertyNameFound {
            get {
                return ResourceManager.GetString("DuplicateDynamicPropertyNameFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type name of the dynamic resource set &apos;{0}&apos; is required and cannot be empty. Consider using a OData type annotation explicitly..
        /// </summary>
        internal static string DynamicResourceSetTypeNameIsRequired {
            get {
                return ResourceManager.GetString("DynamicResourceSetTypeNameIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a supported EDM type..
        /// </summary>
        internal static string EdmTypeNotSupported {
            get {
                return ResourceManager.GetString("EdmTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the property &apos;{0}&apos; on type &apos;{1}&apos; is an array. Consider adding a setter for the property..
        /// </summary>
        internal static string GetOnlyCollectionCannotBeArray {
            get {
                return ResourceManager.GetString("GetOnlyCollectionCannotBeArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given untyped value &apos;{0}&apos; in payload is invalid. Consider using a OData type annotation explicitly..
        /// </summary>
        internal static string InvalidODataUntypedValue {
            get {
                return ResourceManager.GetString("InvalidODataUntypedValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided mapping does not contain a resource for the resource type &apos;{0}&apos;..
        /// </summary>
        internal static string MappingDoesNotContainResourceType {
            get {
                return ResourceManager.GetString("MappingDoesNotContainResourceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EDM model is missing on the read context. The model is required on the read context to deserialize the payload..
        /// </summary>
        internal static string ModelMissingFromReadContext {
            get {
                return ResourceManager.GetString("ModelMissingFromReadContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one matching CLR type found for the EDM type {0}.\nThe matching CLR types are {1}..
        /// </summary>
        internal static string MultipleMatchingClrTypesForEdmType {
            get {
                return ResourceManager.GetString("MultipleMatchingClrTypesForEdmType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The related entity set or singleton cannot be found from the OData path. The related entity set or singleton is required to deserialize the payload..
        /// </summary>
        internal static string NavigationSourceMissingDuringDeserialization {
            get {
                return ResourceManager.GetString("NavigationSourceMissingDuringDeserialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is a nested collection type. Nested collection types are not allowed..
        /// </summary>
        internal static string NestedCollectionsNotSupported {
            get {
                return ResourceManager.GetString("NestedCollectionsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find nested property &apos;{0}&apos; on the resource type &apos;{1}&apos;..
        /// </summary>
        internal static string NestedPropertyNotfound {
            get {
                return ResourceManager.GetString("NestedPropertyNotfound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The container built by the container builder must not be null..
        /// </summary>
        internal static string NullContainer {
            get {
                return ResourceManager.GetString("NullContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collections cannot contain null elements..
        /// </summary>
        internal static string NullElementInCollection {
            get {
                return ResourceManager.GetString("NullElementInCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be completed because no ODataPath is available for the request..
        /// </summary>
        internal static string ODataPathMissing {
            get {
                return ResourceManager.GetString("ODataPathMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; of the property &apos;{1}&apos; on type &apos;{2}&apos; must be a collection..
        /// </summary>
        internal static string PropertyIsNotCollection {
            get {
                return ResourceManager.GetString("PropertyIsNotCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a boolean..
        /// </summary>
        internal static string PropertyMustBeBoolean {
            get {
                return ResourceManager.GetString("PropertyMustBeBoolean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a DateTimeOffset or Date..
        /// </summary>
        internal static string PropertyMustBeDateTimeOffsetOrDate {
            get {
                return ResourceManager.GetString("PropertyMustBeDateTimeOffsetOrDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value with type &apos;{0}&apos; must have type &apos;{1}&apos;..
        /// </summary>
        internal static string PropertyMustBeEnum {
            get {
                return ResourceManager.GetString("PropertyMustBeEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a string..
        /// </summary>
        internal static string PropertyMustBeString {
            get {
                return ResourceManager.GetString("PropertyMustBeString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a string with a length of 1..
        /// </summary>
        internal static string PropertyMustBeStringLengthOne {
            get {
                return ResourceManager.GetString("PropertyMustBeStringLengthOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a string with a maximum length of 1..
        /// </summary>
        internal static string PropertyMustBeStringMaxLengthOne {
            get {
                return ResourceManager.GetString("PropertyMustBeStringMaxLengthOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a Edm.TimeOfDay..
        /// </summary>
        internal static string PropertyMustBeTimeOfDay {
            get {
                return ResourceManager.GetString("PropertyMustBeTimeOfDay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OData formatter requires an attached request in order to deserialize. Controller classes must derive from ODataController or be marked with ODataFormattingAttribute. Custom parameter bindings must call GetPerRequestFormatterInstance on each formatter and use these per-request instances..
        /// </summary>
        internal static string ReadFromStreamAsyncMustHaveRequest {
            get {
                return ResourceManager.GetString("ReadFromStreamAsyncMustHaveRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The last segment of the request URI &apos;{0}&apos; was not recognized as an OData action..
        /// </summary>
        internal static string RequestNotActionInvocation {
            get {
                return ResourceManager.GetString("RequestNotActionInvocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the resource type &apos;{0}&apos; in the model..
        /// </summary>
        internal static string ResourceTypeNotInModel {
            get {
                return ResourceManager.GetString("ResourceTypeNotInModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be deserialized using the ODataMediaTypeFormatter..
        /// </summary>
        internal static string TypeCannotBeDeserialized {
            get {
                return ResourceManager.GetString("TypeCannotBeDeserialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be serialized using the ODataMediaTypeFormatter..
        /// </summary>
        internal static string TypeCannotBeSerialized {
            get {
                return ResourceManager.GetString("TypeCannotBeSerialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; must be an enum or Nullable&lt;T&gt; where T is an enum type..
        /// </summary>
        internal static string TypeMustBeEnumOrNullableEnum {
            get {
                return ResourceManager.GetString("TypeMustBeEnumOrNullableEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a resource set type. Only resource set are supported..
        /// </summary>
        internal static string TypeMustBeResourceSet {
            get {
                return ResourceManager.GetString("TypeMustBeResourceSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The element type &apos;{0}&apos; of the given collection type &apos;{1}&apos; is not of the type &apos;{2}&apos;..
        /// </summary>
        internal static string UnexpectedElementType {
            get {
                return ResourceManager.GetString("UnexpectedElementType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EDM type &apos;{0}&apos; of kind &apos;{1}&apos; is not supported..
        /// </summary>
        internal static string UnsupportedEdmType {
            get {
                return ResourceManager.GetString("UnsupportedEdmType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found unsupported EdmTypeKind &apos;{0}&apos; in list of available types..
        /// </summary>
        internal static string UnsupportedEdmTypeKind {
            get {
                return ResourceManager.GetString("UnsupportedEdmTypeKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not support WriteObjectInline..
        /// </summary>
        internal static string WriteObjectInlineNotSupported {
            get {
                return ResourceManager.GetString("WriteObjectInlineNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not support WriteObject..
        /// </summary>
        internal static string WriteObjectNotSupported {
            get {
                return ResourceManager.GetString("WriteObjectNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OData formatter does not support writing client requests. This formatter instance must have an associated request..
        /// </summary>
        internal static string WriteToStreamAsyncMustHaveRequest {
            get {
                return ResourceManager.GetString("WriteToStreamAsyncMustHaveRequest", resourceCulture);
            }
        }
    }
}
