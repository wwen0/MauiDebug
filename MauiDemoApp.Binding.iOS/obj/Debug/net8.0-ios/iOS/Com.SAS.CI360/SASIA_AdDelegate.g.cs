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
		[OptionalMember]
		[Export ("didLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoad (SASIA_AbstractAd ad)
		{
			_DidLoad (this, ad);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoad (ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didLoad:"), ad__handle__);
		}
		[OptionalMember]
		[Export ("didLoadDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadDefault (SASIA_AbstractAd ad)
		{
			_DidLoadDefault (this, ad);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoadDefault (ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didLoadDefault:"), ad__handle__);
		}
		[OptionalMember]
		[Export ("didFailLoad:error:failingUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailLoad (SASIA_AbstractAd ad, NSError error, string? failingUrl)
		{
			_DidFailLoad (this, ad, error, failingUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailLoad (ISASIA_AdDelegate This, SASIA_AbstractAd ad, NSError error, string? failingUrl)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsfailingUrl = CFString.CreateNative (failingUrl);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailLoad:error:failingUrl:"), ad__handle__, error__handle__, nsfailingUrl);
			CFString.ReleaseNative (nsfailingUrl);
		}
		[OptionalMember]
		[Export ("willClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillClose (SASIA_AbstractAd ad)
		{
			return _WillClose (this, ad);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillClose (ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willClose:"), ad__handle__);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (SASIA_AbstractAd ad)
		{
			_DidClose (this, ad);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidClose (ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didClose:"), ad__handle__);
		}
		[OptionalMember]
		[Export ("willBeginAction:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillBeginAction (SASIA_AbstractAd ad, string url)
		{
			return _WillBeginAction (this, ad, url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillBeginAction (ISASIA_AdDelegate This, SASIA_AbstractAd ad, string url)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willBeginAction:url:"), ad__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didFinishAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAction (SASIA_AbstractAd ad)
		{
			_DidFinishAction (this, ad);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishAction (ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishAction:"), ad__handle__);
		}
		[OptionalMember]
		[Export ("willExpand:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillExpand (SASIA_AbstractAd ad, string url)
		{
			return _WillExpand (this, ad, url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillExpand (ISASIA_AdDelegate This, SASIA_AbstractAd ad, string url)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willExpand:url:"), ad__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didFinishExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishExpand (SASIA_AbstractAd ad)
		{
			_DidFinishExpand (this, ad);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishExpand (ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishExpand:"), ad__handle__);
		}
		[OptionalMember]
		[Export ("willResize:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillResize (SASIA_AbstractAd ad, CGRect size)
		{
			return _WillResize (this, ad, size);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillResize (ISASIA_AdDelegate This, SASIA_AbstractAd ad, CGRect size)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("willResize:size:"), ad__handle__, size);
			return ret != 0;
		}
		[OptionalMember]
		[Export ("didFinishResize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishResize (SASIA_AbstractAd ad)
		{
			_DidFinishResize (this, ad);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishResize (ISASIA_AdDelegate This, SASIA_AbstractAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishResize:"), ad__handle__);
		}
		[DynamicDependencyAttribute ("Description")]
		[DynamicDependencyAttribute ("DidClose(Com.SAS.CI360.SASIA_AbstractAd)")]
		[DynamicDependencyAttribute ("DidFailLoad(Com.SAS.CI360.SASIA_AbstractAd,Foundation.NSError,System.String)")]
		[DynamicDependencyAttribute ("DidFinishAction(Com.SAS.CI360.SASIA_AbstractAd)")]
		[DynamicDependencyAttribute ("DidFinishExpand(Com.SAS.CI360.SASIA_AbstractAd)")]
		[DynamicDependencyAttribute ("DidFinishResize(Com.SAS.CI360.SASIA_AbstractAd)")]
		[DynamicDependencyAttribute ("DidLoad(Com.SAS.CI360.SASIA_AbstractAd)")]
		[DynamicDependencyAttribute ("DidLoadDefault(Com.SAS.CI360.SASIA_AbstractAd)")]
		[DynamicDependencyAttribute ("WillBeginAction(Com.SAS.CI360.SASIA_AbstractAd,System.String)")]
		[DynamicDependencyAttribute ("WillClose(Com.SAS.CI360.SASIA_AbstractAd)")]
		[DynamicDependencyAttribute ("WillExpand(Com.SAS.CI360.SASIA_AbstractAd,System.String)")]
		[DynamicDependencyAttribute ("WillResize(Com.SAS.CI360.SASIA_AbstractAd,CoreGraphics.CGRect)")]
		static ISASIA_AdDelegate ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[OptionalMember]
		public virtual string Description {
			[Export ("description")]
			get {
				return _GetDescription (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetDescription (ISASIA_AdDelegate This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("description")))!;
		}
	}
	/// <summary>Extension methods to the <see cref="ISASIA_AdDelegate" /> interface to support all the methods from the SASIA_AdDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISASIA_AdDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SASIA_AdDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SASIA_AdDelegate_Extensions {
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willClose:"), ad__handle__);
			return ret != 0;
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willBeginAction:url:"), ad__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willExpand:url:"), ad__handle__, nsurl);
			CFString.ReleaseNative (nsurl);
			return ret != 0;
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
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("willResize:size:"), ad__handle__, size);
			return ret != 0;
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
	internal unsafe sealed class SASIA_AdDelegateWrapper : BaseWrapper, ISASIA_AdDelegate {
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
		/// <summary>Creates a new <see cref="SASIA_AdDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASIA_AdDelegate () : base (NSObjectFlag.Empty)
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
		protected SASIA_AdDelegate (NSObjectFlag t) : base (t)
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
