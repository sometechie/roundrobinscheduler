﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SomeTechie.RoundRobinScheduler.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Your access code is {0}")]
        public string AccessCodeMessageLine1 {
            get {
                return ((string)(this["AccessCodeMessageLine1"]));
            }
            set {
                this["AccessCodeMessageLine1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Please show this code to PS at the info tent.")]
        public string AccessCodeMessageLine2 {
            get {
                return ((string)(this["AccessCodeMessageLine2"]));
            }
            set {
                this["AccessCodeMessageLine2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool accessCodeMessageMakeBold {
            get {
                return ((bool)(this["accessCodeMessageMakeBold"]));
            }
            set {
                this["accessCodeMessageMakeBold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public decimal numCourts {
            get {
                return ((decimal)(this["numCourts"]));
            }
            set {
                this["numCourts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("autoSaveToolStripMenuItem")]
        public string AutoSave {
            get {
                return ((string)(this["AutoSave"]));
            }
            set {
                this["AutoSave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyUrl {
            get {
                return ((string)(this["ProxyUrl"]));
            }
            set {
                this["ProxyUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxySharedKey {
            get {
                return ((string)(this["ProxySharedKey"]));
            }
            set {
                this["ProxySharedKey"] = value;
            }
        }
    }
}
