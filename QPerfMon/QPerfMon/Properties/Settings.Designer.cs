﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace QPerfMon.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LoggingDirectory {
            get {
                return ((string)(this["LoggingDirectory"]));
            }
            set {
                this["LoggingDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LoggingFileName {
            get {
                return ((string)(this["LoggingFileName"]));
            }
            set {
                this["LoggingFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LoggingAppendDateTime {
            get {
                return ((bool)(this["LoggingAppendDateTime"]));
            }
            set {
                this["LoggingAppendDateTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public long LoggingMinimumDiskSpaceLimitMB {
            get {
                return ((long)(this["LoggingMinimumDiskSpaceLimitMB"]));
            }
            set {
                this["LoggingMinimumDiskSpaceLimitMB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public long LoggingCreateNewFileEveryMB {
            get {
                return ((long)(this["LoggingCreateNewFileEveryMB"]));
            }
            set {
                this["LoggingCreateNewFileEveryMB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int LoggingCreateNewFileMaxCounter {
            get {
                return ((int)(this["LoggingCreateNewFileMaxCounter"]));
            }
            set {
                this["LoggingCreateNewFileMaxCounter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int LoggingSampleRate {
            get {
                return ((int)(this["LoggingSampleRate"]));
            }
            set {
                this["LoggingSampleRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool NewVersion {
            get {
                return ((bool)(this["NewVersion"]));
            }
            set {
                this["NewVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int LoggingDecimalDigits {
            get {
                return ((int)(this["LoggingDecimalDigits"]));
            }
            set {
                this["LoggingDecimalDigits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MainWindowSnap {
            get {
                return ((bool)(this["MainWindowSnap"]));
            }
            set {
                this["MainWindowSnap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color GraphBackgroundColor {
            get {
                return ((global::System.Drawing.Color)(this["GraphBackgroundColor"]));
            }
            set {
                this["GraphBackgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DarkGreen")]
        public global::System.Drawing.Color GridColor {
            get {
                return ((global::System.Drawing.Color)(this["GridColor"]));
            }
            set {
                this["GridColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Yellow")]
        public global::System.Drawing.Color GraphTextColor {
            get {
                return ((global::System.Drawing.Color)(this["GraphTextColor"]));
            }
            set {
                this["GraphTextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Verdana, 9.75pt, style=Bold")]
        public global::System.Drawing.Font GraphTextFont {
            get {
                return ((global::System.Drawing.Font)(this["GraphTextFont"]));
            }
            set {
                this["GraphTextFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableCounterOnError {
            get {
                return ((bool)(this["DisableCounterOnError"]));
            }
            set {
                this["DisableCounterOnError"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AlwaysOnTop {
            get {
                return ((bool)(this["AlwaysOnTop"]));
            }
            set {
                this["AlwaysOnTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RememberSizeLocationOnSaveLoad {
            get {
                return ((bool)(this["RememberSizeLocationOnSaveLoad"]));
            }
            set {
                this["RememberSizeLocationOnSaveLoad"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(",")]
        public string LoggingValueSeparator {
            get {
                return ((string)(this["LoggingValueSeparator"]));
            }
            set {
                this["LoggingValueSeparator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default.qpmset")]
        public string DefaultSet {
            get {
                return ((string)(this["DefaultSet"]));
            }
            set {
                this["DefaultSet"] = value;
            }
        }
    }
}
