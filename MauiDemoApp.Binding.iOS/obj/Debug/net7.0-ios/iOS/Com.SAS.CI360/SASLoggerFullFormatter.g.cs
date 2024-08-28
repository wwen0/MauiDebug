//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Com.SAS.CI360 {
	[Register("SASLoggerFullFormatter", true)]
	public unsafe partial class SASLoggerFullFormatter : NSObject, ISASLoggerFormatter {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SASLoggerFullFormatter");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASLoggerFullFormatter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASLoggerFullFormatter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASLoggerFullFormatter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("formatLevel:file:function:line:msg:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FormatLevel (SASLoggerFlag flag, string file, string function, nuint line, string msg)
		{
			if (file is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (file));
			if (function is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (function));
			if (msg is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (msg));
			var nsfile = CFString.CreateNative (file);
			var nsfunction = CFString.CreateNative (function);
			var nsmsg = CFString.CreateNative (msg);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("formatLevel:file:function:line:msg:"), (UIntPtr) (ulong) flag, nsfile, nsfunction, line, nsmsg))!;
			} else {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.SuperHandle, Selector.GetHandle ("formatLevel:file:function:line:msg:"), (UIntPtr) (ulong) flag, nsfile, nsfunction, line, nsmsg))!;
			}
			CFString.ReleaseNative (nsfile);
			CFString.ReleaseNative (nsfunction);
			CFString.ReleaseNative (nsmsg);
			return ret!;
		}
	} /* class SASLoggerFullFormatter */
}
