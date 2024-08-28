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
	[Protocol (Name = "SASLoggerFormatter", WrapperType = typeof (SASLoggerFormatterWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FormatLevel", Selector = "formatLevel:file:function:line:msg:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASLoggerFlag), typeof (string), typeof (string), typeof (UIntPtr), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public partial interface ISASLoggerFormatter : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("formatLevel:file:function:line:msg:")]
		[Preserve (Conditional = true)]
		string FormatLevel (SASLoggerFlag flag, string file, string function, nuint line, string msg);
	}
	internal sealed class SASLoggerFormatterWrapper : BaseWrapper, ISASLoggerFormatter {
		[Preserve (Conditional = true)]
		public SASLoggerFormatterWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("formatLevel:file:function:line:msg:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string FormatLevel (SASLoggerFlag flag, string file, string function, nuint line, string msg)
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
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("formatLevel:file:function:line:msg:"), (UIntPtr) (ulong) flag, nsfile, nsfunction, line, nsmsg))!;
			CFString.ReleaseNative (nsfile);
			CFString.ReleaseNative (nsfunction);
			CFString.ReleaseNative (nsmsg);
			return ret!;
		}
	}
}
namespace Com.SAS.CI360 {
	[Protocol()]
	[Register("ApiDefinition__Com_SAS_CI360_SASLoggerFormatter", false)]
	[Model]
	public unsafe abstract partial class SASLoggerFormatter : NSObject, ISASLoggerFormatter {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SASLoggerFormatter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASLoggerFormatter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASLoggerFormatter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("formatLevel:file:function:line:msg:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FormatLevel (SASLoggerFlag flag, string file, string function, nuint line, string msg)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SASLoggerFormatter */
}
