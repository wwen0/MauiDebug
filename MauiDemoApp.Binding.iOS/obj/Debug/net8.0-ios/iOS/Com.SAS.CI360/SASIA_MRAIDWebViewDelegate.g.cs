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
		[OptionalMember]
		[Export ("didLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoad (SASIA_MRAIDWebView mraidView)
		{
			_DidLoad (this, mraidView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoad (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didLoad:"), mraidView__handle__);
		}
		[OptionalMember]
		[Export ("didFailLoad:error:failingUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailLoad (SASIA_MRAIDWebView mraidView, NSError error, string? url)
		{
			_DidFailLoad (this, mraidView, error, url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailLoad (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, NSError error, string? url)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsurl = CFString.CreateNative (url);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailLoad:error:failingUrl:"), mraidView__handle__, error__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
		}
		[OptionalMember]
		[Export ("willClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillClose (SASIA_MRAIDWebView mraidView)
		{
			return _WillClose (this, mraidView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillClose (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willClose:"), mraidView__handle__);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (SASIA_MRAIDWebView mraidView)
		{
			_DidClose (this, mraidView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidClose (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didClose:"), mraidView__handle__);
		}
		[OptionalMember]
		[Export ("willBeginAction:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillBeginAction (SASIA_MRAIDWebView mraidView, string url)
		{
			return _WillBeginAction (this, mraidView, url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillBeginAction (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, string url)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willBeginAction:url:"), mraidView__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didFinishAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAction (SASIA_MRAIDWebView mraidView)
		{
			_DidFinishAction (this, mraidView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishAction (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishAction:"), mraidView__handle__);
		}
		[OptionalMember]
		[Export ("willExpand:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillExpand (SASIA_MRAIDWebView mraidView, string url)
		{
			return _WillExpand (this, mraidView, url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillExpand (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, string url)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willExpand:url:"), mraidView__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didFinishExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishExpand (SASIA_MRAIDWebView mraidView)
		{
			_DidFinishExpand (this, mraidView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishExpand (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishExpand:"), mraidView__handle__);
		}
		[OptionalMember]
		[Export ("willResize:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillResize (SASIA_MRAIDWebView mraidView, CGRect size)
		{
			return _WillResize (this, mraidView, size);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillResize (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView, CGRect size)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("willResize:size:"), mraidView__handle__, size);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didFinishResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishResize (SASIA_MRAIDWebView mraidView)
		{
			_DidFinishResize (this, mraidView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishResize (ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishResize:"), mraidView__handle__);
		}
		[DynamicDependencyAttribute ("DidClose(Com.SAS.CI360.SASIA_MRAIDWebView)")]
		[DynamicDependencyAttribute ("DidFailLoad(Com.SAS.CI360.SASIA_MRAIDWebView,Foundation.NSError,System.String)")]
		[DynamicDependencyAttribute ("DidFinishAction(Com.SAS.CI360.SASIA_MRAIDWebView)")]
		[DynamicDependencyAttribute ("DidFinishExpand(Com.SAS.CI360.SASIA_MRAIDWebView)")]
		[DynamicDependencyAttribute ("DidFinishResize(Com.SAS.CI360.SASIA_MRAIDWebView)")]
		[DynamicDependencyAttribute ("DidLoad(Com.SAS.CI360.SASIA_MRAIDWebView)")]
		[DynamicDependencyAttribute ("WillBeginAction(Com.SAS.CI360.SASIA_MRAIDWebView,System.String)")]
		[DynamicDependencyAttribute ("WillClose(Com.SAS.CI360.SASIA_MRAIDWebView)")]
		[DynamicDependencyAttribute ("WillExpand(Com.SAS.CI360.SASIA_MRAIDWebView,System.String)")]
		[DynamicDependencyAttribute ("WillResize(Com.SAS.CI360.SASIA_MRAIDWebView,CoreGraphics.CGRect)")]
		static ISASIA_MRAIDWebViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ISASIA_MRAIDWebViewDelegate" /> interface to support all the methods from the SASIA_MRAIDWebViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISASIA_MRAIDWebViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SASIA_MRAIDWebViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SASIA_MRAIDWebViewDelegate_Extensions {
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willClose:"), mraidView__handle__);
			return ret != 0;
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willBeginAction:url:"), mraidView__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willExpand:url:"), mraidView__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("willResize:size:"), mraidView__handle__, size);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishResize (this ISASIA_MRAIDWebViewDelegate This, SASIA_MRAIDWebView mraidView)
		{
			var mraidView__handle__ = mraidView!.GetNonNullHandle (nameof (mraidView));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishResize:"), mraidView__handle__);
		}
	}
	internal unsafe sealed class SASIA_MRAIDWebViewDelegateWrapper : BaseWrapper, ISASIA_MRAIDWebViewDelegate {
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
		/// <summary>Creates a new <see cref="SASIA_MRAIDWebViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASIA_MRAIDWebViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, initWithFrame, frame);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASIA_MRAIDWebViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
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
