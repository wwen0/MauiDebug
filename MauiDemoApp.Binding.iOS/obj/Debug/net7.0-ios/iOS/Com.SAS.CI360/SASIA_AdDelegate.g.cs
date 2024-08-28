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
	[Protocol (Name = "SASIA_AdDelegate", WrapperType = typeof (SASIA_AdDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoad", Selector = "didLoad:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadDefault", Selector = "didLoadDefault:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailLoad", Selector = "didFailLoad:error:failingUrl:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd), typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillClose", Selector = "willClose:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "didClose:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginAction", Selector = "willBeginAction:url:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishAction", Selector = "didFinishAction:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExpand", Selector = "willExpand:url:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishExpand", Selector = "didFinishExpand:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResize", Selector = "willResize:size:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishResize", Selector = "didFinishResize:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_AbstractAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Description", Selector = "description", PropertyType = typeof (string), GetterSelector = "description", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISASIA_AdDelegate : INativeObject, IDisposable
	{
	}
	public static partial class SASIA_AdDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoad (this ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didLoad:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoadDefault (this ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didLoadDefault:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailLoad (this ISASIA_AdDelegate This, SASIA_AbstractAd ad, NSError error, string? failingUrl)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsfailingUrl = CFString.CreateNative (failingUrl);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailLoad:error:failingUrl:"), ad__handle__, error__handle__, nsfailingUrl);
			CFString.ReleaseNative (nsfailingUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillClose (this ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willClose:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClose (this ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didClose:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillBeginAction (this ISASIA_AdDelegate This, SASIA_AbstractAd ad, string url)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willBeginAction:url:"), ad__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishAction (this ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishAction:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillExpand (this ISASIA_AdDelegate This, SASIA_AbstractAd ad, string url)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willExpand:url:"), ad__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishExpand (this ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishExpand:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillResize (this ISASIA_AdDelegate This, SASIA_AbstractAd ad, CGRect size)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("willResize:size:"), ad__handle__, size);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishResize (this ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishResize:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetDescription (this ISASIA_AdDelegate This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("description")))!;
		}
	}
	internal sealed class SASIA_AdDelegateWrapper : BaseWrapper, ISASIA_AdDelegate {
		[Preserve (Conditional = true)]
		public SASIA_AdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Com.SAS.CI360 {
	[Protocol()]
	[Register("ApiDefinition__Com_SAS_CI360_SASIA_AdDelegate", false)]
	[Model]
	public unsafe partial class SASIA_AdDelegate : NSObject, ISASIA_AdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASIA_AdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASIA_AdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASIA_AdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (SASIA_AbstractAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailLoad:error:failingUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailLoad (SASIA_AbstractAd ad, NSError error, string? failingUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFinishAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAction (SASIA_AbstractAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFinishExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishExpand (SASIA_AbstractAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFinishResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishResize (SASIA_AbstractAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoad (SASIA_AbstractAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLoadDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadDefault (SASIA_AbstractAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willBeginAction:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillBeginAction (SASIA_AbstractAd ad, string url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillClose (SASIA_AbstractAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willExpand:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillExpand (SASIA_AbstractAd ad, string url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willResize:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillResize (SASIA_AbstractAd ad, CGRect size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Description {
			[Export ("description")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class SASIA_AdDelegate */
}
