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
	[Register("SASCollectorUIAdView", true)]
	public unsafe partial class SASCollectorUIAdView : SASIA_Ad {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SASCollectorUIAdView");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASCollectorUIAdView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SASCollectorUIAdView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASCollectorUIAdView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASCollectorUIAdView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initForController:withFrame:withSpotId:withTags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SASCollectorUIAdView (global::UIKit.UIViewController hostViewController, CGRect frame, string spotid, NSDictionary attributes)
			: base (NSObjectFlag.Empty)
		{
			var hostViewController__handle__ = hostViewController!.GetNonNullHandle (nameof (hostViewController));
			if (spotid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spotid));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var nsspotid = CFString.CreateNative (spotid);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_CGRect_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initForController:withFrame:withSpotId:withTags:"), hostViewController__handle__, frame, nsspotid, attributes__handle__), "initForController:withFrame:withSpotId:withTags:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initForController:withFrame:withSpotId:withTags:"), hostViewController__handle__, frame, nsspotid, attributes__handle__), "initForController:withFrame:withSpotId:withTags:");
			}
			CFString.ReleaseNative (nsspotid);
		}
		[Export ("addSpotAttributeName:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSpotAttributeName (string name, string value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsname = CFString.CreateNative (name);
			var nsvalue = CFString.CreateNative (value);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addSpotAttributeName:value:"), nsname, nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("addSpotAttributeName:value:"), nsname, nsvalue);
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsvalue);
		}
		[Export ("load")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Load ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("load"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("load"));
			}
		}
		[Export ("removeSpotAttribute:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSpotAttribute (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeSpotAttribute:"), nsname);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("removeSpotAttribute:"), nsname);
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("setSpotAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSpotAttributes (NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSpotAttributes:"), attributes__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSpotAttributes:"), attributes__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SASIA_AdRequest AdRequest {
			[Export ("adRequest", ArgumentSemantic.Retain)]
			get {
				SASIA_AdRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SASIA_AdRequest> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adRequest")))!;
				} else {
					ret =  Runtime.GetNSObject<SASIA_AdRequest> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adRequest")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SpotID {
			[Export ("spotID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("spotID")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("spotID")))!;
				}
			}
			[Export ("setSpotID:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSpotID:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSpotID:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		public partial class SASCollectorUIAdViewAppearance : global::Com.SAS.CI360.SASIA_Ad.SASIA_AdAppearance {
			protected internal SASCollectorUIAdViewAppearance (IntPtr handle) : base (handle) {}
		}
		public static new SASCollectorUIAdViewAppearance Appearance {
			get { return new SASCollectorUIAdViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new SASCollectorUIAdViewAppearance GetAppearance<T> () where T: SASCollectorUIAdView {
			return new SASCollectorUIAdViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new SASCollectorUIAdViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new SASCollectorUIAdViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new SASCollectorUIAdViewAppearance GetAppearance (UITraitCollection traits) {
			return new SASCollectorUIAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new SASCollectorUIAdViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new SASCollectorUIAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new SASCollectorUIAdViewAppearance GetAppearance<T> (UITraitCollection traits) where T: SASCollectorUIAdView {
			return new SASCollectorUIAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new SASCollectorUIAdViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: SASCollectorUIAdView{
			return new SASCollectorUIAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class SASCollectorUIAdView */
}
