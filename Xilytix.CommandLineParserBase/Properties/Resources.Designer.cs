﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xilytix.CommandLineParserBase.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xilytix.CommandLineParserBase.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Invalid quote character in option value.
        /// </summary>
        internal static string Error_InvalidQuoteCharacterInOptionValue {
            get {
                return ResourceManager.GetString("Error_InvalidQuoteCharacterInOptionValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid quote character in text parameter.
        /// </summary>
        internal static string Error_InvalidQuoteCharacterInTextParameter {
            get {
                return ResourceManager.GetString("Error_InvalidQuoteCharacterInTextParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option missing closing quote character.
        /// </summary>
        internal static string Error_OptionMissingClosingQuoteCharacter {
            get {
                return ResourceManager.GetString("Error_OptionMissingClosingQuoteCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option not specified at line position.
        /// </summary>
        internal static string Error_OptionNotSpecifiedAtLinePosition {
            get {
                return ResourceManager.GetString("Error_OptionNotSpecifiedAtLinePosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text missing closing quote character.
        /// </summary>
        internal static string Error_TextMissingClosingQuoteCharacter {
            get {
                return ResourceManager.GetString("Error_TextMissingClosingQuoteCharacter", resourceCulture);
            }
        }
    }
}