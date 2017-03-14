﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Common.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Common.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Value cannot be empty.
        ///Parameter name: {0}.
        /// </summary>
        public static string ArgumentCannotBeEmpty {
            get {
                return ResourceManager.GetString("ArgumentCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified argument {0} cannot be greater than its ceiling value of {1}..
        /// </summary>
        public static string ArgumentCannotBeGreaterThanBaseline {
            get {
                return ResourceManager.GetString("ArgumentCannotBeGreaterThanBaseline", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified argument {0} cannot be initialized with a negative value..
        /// </summary>
        public static string ArgumentCannotBeNegative {
            get {
                return ResourceManager.GetString("ArgumentCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} requires a {1} in its HTTP pipeline to work with client certificates..
        /// </summary>
        public static string CertificateCloudCredentials_InitializeServiceClient_NoWebRequestHandler {
            get {
                return ResourceManager.GetString("CertificateCloudCredentials_InitializeServiceClient_NoWebRequestHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Failed to convert parameter {0} value &apos;{1}&apos; to type {2}..
        /// </summary>
        public static string ConfigurationHelper_CreateCouldNotConvertException {
            get {
                return ResourceManager.GetString("ConfigurationHelper_CreateCouldNotConvertException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {3}  Failed to create {0} from connection settings {1} = &quot;{2}&quot;..
        /// </summary>
        public static string ConfigurationHelper_CreateFromSettings_CreateSettingsFailedException {
            get {
                return ResourceManager.GetString("ConfigurationHelper_CreateFromSettings_CreateSettingsFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No connection settings found for type {0}.  Enable tracing for more information..
        /// </summary>
        public static string ConfigurationHelper_CreateFromSettings_NoConnectionSettingsFound {
            get {
                return ResourceManager.GetString("ConfigurationHelper_CreateFromSettings_NoConnectionSettingsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No credentials of type &apos;{0}&apos; could be initialized from the provided settings..
        /// </summary>
        public static string ConfigurationHelper_GetCredentials_NotFound {
            get {
                return ResourceManager.GetString("ConfigurationHelper_GetCredentials_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Parameter {0} is required..
        /// </summary>
        public static string ConfigurationHelper_GetParameter_NotFound {
            get {
                return ResourceManager.GetString("ConfigurationHelper_GetParameter_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Default retry strategy for technology {0}, named &apos;{1}&apos;, is not defined..
        /// </summary>
        public static string DefaultRetryStrategyMappingNotFound {
            get {
                return ResourceManager.GetString("DefaultRetryStrategyMappingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Default retry strategy for technology {0} was not not defined, and there is no overall default strategy..
        /// </summary>
        public static string DefaultRetryStrategyNotFound {
            get {
                return ResourceManager.GetString("DefaultRetryStrategyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Retry handler is not present in the HttpClient handler stack..
        /// </summary>
        public static string ExceptionRetryHandlerMissing {
            get {
                return ResourceManager.GetString("ExceptionRetryHandlerMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The RetryManager is already set..
        /// </summary>
        public static string ExceptionRetryManagerAlreadySet {
            get {
                return ResourceManager.GetString("ExceptionRetryManagerAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The default RetryManager has not been set. Set it by invoking the RetryManager.SetDefault static method, or if you are using declarative configuration, you can invoke the RetryPolicyFactory.CreateDefault() method to automatically create the retry manager from the configuration file..
        /// </summary>
        public static string ExceptionRetryManagerNotSet {
            get {
                return ResourceManager.GetString("ExceptionRetryManagerNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Response status code indicates server error: {0} ({1})..
        /// </summary>
        public static string ResponseStatusCodeError {
            get {
                return ResourceManager.GetString("ResponseStatusCodeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The action has exceeded its defined retry limit..
        /// </summary>
        public static string RetryLimitExceeded {
            get {
                return ResourceManager.GetString("RetryLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The retry strategy with name &apos;{0}&apos; cannot be found..
        /// </summary>
        public static string RetryStrategyNotFound {
            get {
                return ResourceManager.GetString("RetryStrategyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified string argument {0} must not be empty..
        /// </summary>
        public static string StringCannotBeEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified argument &apos;{0}&apos; cannot return a null task when invoked..
        /// </summary>
        public static string TaskCannotBeNull {
            get {
                return ResourceManager.GetString("TaskCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified argument &apos;{0}&apos; must return a scheduled task (also known as &quot;hot&quot; task) when invoked..
        /// </summary>
        public static string TaskMustBeScheduled {
            get {
                return ResourceManager.GetString("TaskMustBeScheduled", resourceCulture);
            }
        }
    }
}
