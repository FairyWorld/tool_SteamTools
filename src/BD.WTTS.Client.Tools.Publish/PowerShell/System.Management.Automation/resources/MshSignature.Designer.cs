﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Management.Automation {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MshSignature {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MshSignature() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BD.WTTS.Client.Tools.Publish.PowerShell.System.Management.Automation.resources.Ms" +
                            "hSignature", typeof(MshSignature).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 The contents of file {0} might have been changed by an unauthorized user or process, because the hash of the file does not match the hash stored in the digital signature. The script cannot run on the specified system. For more information, run Get-Help about_Signing. 的本地化字符串。
        /// </summary>
        internal static string MshSignature_HashMismatch {
            get {
                return ResourceManager.GetString("MshSignature_HashMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The signature cannot be verified because it is incompatible with the current system. 的本地化字符串。
        /// </summary>
        internal static string MshSignature_Incompatible {
            get {
                return ResourceManager.GetString("MshSignature_Incompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The signature cannot be verified because it is incompatible with the current system. The hash algorithm is not valid. 的本地化字符串。
        /// </summary>
        internal static string MshSignature_Incompatible_HashAlgorithm {
            get {
                return ResourceManager.GetString("MshSignature_Incompatible_HashAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The file {0} is not digitally signed. You cannot run this script on the current system. For more information about running scripts and setting execution policy, see about_Execution_Policies at https://go.microsoft.com/fwlink/?LinkID=135170 的本地化字符串。
        /// </summary>
        internal static string MshSignature_NotSigned {
            get {
                return ResourceManager.GetString("MshSignature_NotSigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot sign the file because the system does not support signing operations on {0} files. 的本地化字符串。
        /// </summary>
        internal static string MshSignature_NotSupportedFileFormat {
            get {
                return ResourceManager.GetString("MshSignature_NotSupportedFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot sign the file because the system does not support signing operations on files that do not have a file name extension. 的本地化字符串。
        /// </summary>
        internal static string MshSignature_NotSupportedFileFormat_NoExtension {
            get {
                return ResourceManager.GetString("MshSignature_NotSupportedFileFormat_NoExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 File {0} is signed but the signer is not trusted on this system. 的本地化字符串。
        /// </summary>
        internal static string MshSignature_NotTrusted {
            get {
                return ResourceManager.GetString("MshSignature_NotTrusted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Signature verified. 的本地化字符串。
        /// </summary>
        internal static string MshSignature_Valid {
            get {
                return ResourceManager.GetString("MshSignature_Valid", resourceCulture);
            }
        }
    }
}