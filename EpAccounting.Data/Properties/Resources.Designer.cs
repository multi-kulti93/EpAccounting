﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpAccounting.Data.Properties {
    using System;
    
    
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EpAccounting.Data.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to .db.
        /// </summary>
        internal static string Database_Extension {
            get {
                return ResourceManager.GetString("Database_Extension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Datei konnte nicht geladen werden, da sie keine Datenbankdatei ist..
        /// </summary>
        internal static string Exception_Message_CanNotLoadInvalidFile {
            get {
                return ResourceManager.GetString("Exception_Message_CanNotLoadInvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Datenbank konnte nicht geladen werden, da sie nicht existiert..
        /// </summary>
        internal static string Exception_Message_CanNotLoadNotExistingDatabase {
            get {
                return ResourceManager.GetString("Exception_Message_CanNotLoadNotExistingDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Es besteht keine Verbindung zur Datenbank!.
        /// </summary>
        internal static string Exception_Message_NoDatabaseConnection {
            get {
                return ResourceManager.GetString("Exception_Message_NoDatabaseConnection", resourceCulture);
            }
        }
    }
}