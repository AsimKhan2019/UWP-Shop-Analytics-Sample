﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopAnalyticsPCL.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Keys {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Keys() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ShopAnalyticsPCL.Resources.Keys", typeof(Keys).GetTypeInfo().Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://ridoshopserver.azurewebsites.net.
        /// </summary>
        public static string AzureWebAppUri {
            get {
                return ResourceManager.GetString("AzureWebAppUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to events.
        /// </summary>
        public static string DocDbCollectionName {
            get {
                return ResourceManager.GetString("DocDbCollectionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to eventDoc.
        /// </summary>
        public static string DocDbDocName {
            get {
                return ResourceManager.GetString("DocDbDocName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to poZUfiYj6kq4P0YKaw1djfxRIll9kXy494xv1JS6KW5FTm0duFinBeUX6rx8Dyf34NgtjZEIhiAPYlQISKny9w==.
        /// </summary>
        public static string DocDbKey {
            get {
                return ResourceManager.GetString("DocDbKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EventsDB.
        /// </summary>
        public static string DocDbName {
            get {
                return ResourceManager.GetString("DocDbName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://ridophotos.documents.azure.com:443/.
        /// </summary>
        public static string DocDbUri {
            get {
                return ResourceManager.GetString("DocDbUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Endpoint=sb://photoseventsnh.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=DniAXgy7XXHaTesc7/jul4Hp0xF6dy8u0p5dKjFwAso=.
        /// </summary>
        public static string NhFullConnection {
            get {
                return ResourceManager.GetString("NhFullConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Endpoint=sb://photoseventsnh.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=hc0UfF534NCsHG+BgWQVnWvL5E9eTHGDx2I3PiITtOk=.
        /// </summary>
        public static string NhListenConnection {
            get {
                return ResourceManager.GetString("NhListenConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to eventshub.
        /// </summary>
        public static string NhName {
            get {
                return ResourceManager.GetString("NhName", resourceCulture);
            }
        }
    }
}
