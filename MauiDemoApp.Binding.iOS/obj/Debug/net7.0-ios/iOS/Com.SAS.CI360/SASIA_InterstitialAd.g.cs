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
	[Register("SASIA_InterstitialAd", true)]
	public unsafe partial class SASIA_InterstitialAd : SASIA_AbstractAd {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SASIA_InterstitialAd");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASIA_InterstitialAd () : base (NSObjectFlag.Empty)
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
		public SASIA_InterstitialAd (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SASIA_InterstitialAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASIA_InterstitialAd (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("showFromController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowFromController (global::UIKit.UIViewController hostController)
		{
			var hostController__handle__ = hostController!.GetNonNullHandle (nameof (hostController));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("showFromController:"), hostController__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("showFromController:"), hostController__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIModalTransitionStyle InterstitialTransitionStyle {
			[Export ("interstitialTransitionStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIModalTransitionStyle ret;
				if (IsDirectBinding) {
					ret = (UIModalTransitionStyle) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("interstitialTransitionStyle"));
				} else {
					ret = (UIModalTransitionStyle) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("interstitialTransitionStyle"));
				}
				return ret!;
			}
			[Export ("setInterstitialTransitionStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInterstitialTransitionStyle:"), (IntPtr) (long) value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setInterstitialTransitionStyle:"), (IntPtr) (long) value);
				}
			}
		}
		public partial class SASIA_InterstitialAdAppearance : global::Com.SAS.CI360.SASIA_AbstractAd.SASIA_AbstractAdAppearance {
			protected internal SASIA_InterstitialAdAppearance (IntPtr handle) : base (handle) {}
		}
		public static new SASIA_InterstitialAdAppearance Appearance {
			get { return new SASIA_InterstitialAdAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new SASIA_InterstitialAdAppearance GetAppearance<T> () where T: SASIA_InterstitialAd {
			return new SASIA_InterstitialAdAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new SASIA_InterstitialAdAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new SASIA_InterstitialAdAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new SASIA_InterstitialAdAppearance GetAppearance (UITraitCollection traits) {
			return new SASIA_InterstitialAdAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new SASIA_InterstitialAdAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new SASIA_InterstitialAdAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new SASIA_InterstitialAdAppearance GetAppearance<T> (UITraitCollection traits) where T: SASIA_InterstitialAd {
			return new SASIA_InterstitialAdAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new SASIA_InterstitialAdAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: SASIA_InterstitialAd{
			return new SASIA_InterstitialAdAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class SASIA_InterstitialAd */
}
