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
	[Protocol (Name = "SASIA_MRAIDWebViewDelegate", WrapperType = typeof (SASIA_MRAIDWebViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoad", Selector = "didLoad:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailLoad", Selector = "didFailLoad:error:failingUrl:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView), typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillClose", Selector = "willClose:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "didClose:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginAction", Selector = "willBeginAction:url:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishAction", Selector = "didFinishAction:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExpand", Selector = "willExpand:url:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishExpand", Selector = "didFinishExpand:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResize", Selector = "willResize:size:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishResize", Selector = "didFinishResize:", ParameterType = new Type [] { typeof (Com.SAS.CI360.SASIA_MRAIDWebView) }, ParameterByRef = new bool [] { false })]
	public partial interface ISASIA_MRAIDWebViewDelegate : INativeObject, IDisposable
	{
	}
	public static partial class SASIA_MRAIDWebViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoad (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didLoad:"), mraidView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailLoad (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, NSError error, string? url)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsurl = CFString.CreateNative (url);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailLoad:error:failingUrl:"), mraidView__handle__, error__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillClose (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willClose:"), mraidView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClose (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didClose:"), mraidView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillBeginAction (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, string url)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willBeginAction:url:"), mraidView__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishAction (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishAction:"), mraidView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillExpand (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, string url)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willExpand:url:"), mraidView__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishExpand (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishExpand:"), mraidView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillResize (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, CGRect size)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("willResize:size:"), mraidView__handle__, size);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishResize (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishResize:"), mraidView__handle__);
		}
	}
	internal sealed class SASIA_MRAIDWebViewDelegateWrapper : BaseWrapper, ISASIA_MRAIDWebViewDelegate {
		[Preserve (Conditional = true)]
		public SASIA_MRAIDWebViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Com.SAS.CI360 {
	[Protocol()]
	[Register("ApiDefinition__Com_SAS_CI360_SASIA_MRAIDWebViewDelegate", false)]
	[Model]
	public unsafe partial class SASIA_MRAIDWebViewDelegate : NSObject, ISASIA_MRAIDWebViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASIA_MRAIDWebViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASIA_MRAIDWebViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASIA_MRAIDWebViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (SASIA_MRAIDWebView mraidView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailLoad:error:failingUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailLoad (SASIA_MRAIDWebView mraidView, NSError error, string? url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFinishAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAction (SASIA_MRAIDWebView mraidView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFinishExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishExpand (SASIA_MRAIDWebView mraidView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFinishResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishResize (SASIA_MRAIDWebView mraidView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoad (SASIA_MRAIDWebView mraidView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willBeginAction:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillBeginAction (SASIA_MRAIDWebView mraidView, string url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillClose (SASIA_MRAIDWebView mraidView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willExpand:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillExpand (SASIA_MRAIDWebView mraidView, string url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willResize:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillResize (SASIA_MRAIDWebView mraidView, CGRect size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SASIA_MRAIDWebViewDelegate */
}
