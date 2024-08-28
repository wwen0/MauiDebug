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
	[Protocol (Name = "SASMobileMessagingDelegate2", WrapperType = typeof (SASMobileMessagingDelegate2Wrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MessageDismissed", Selector = "messageDismissed")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ActionWithLink", Selector = "actionWithLink:type:", ParameterType = new Type [] { typeof (string), typeof (Com.SAS.CI360.SASMobileMessageType) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISASMobileMessagingDelegate2 : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("messageDismissed")]
		[Preserve (Conditional = true)]
		void MessageDismissed ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("actionWithLink:type:")]
		[Preserve (Conditional = true)]
		void ActionWithLink (string link, SASMobileMessageType type);
	}
	internal sealed class SASMobileMessagingDelegate2Wrapper : BaseWrapper, ISASMobileMessagingDelegate2 {
		[Preserve (Conditional = true)]
		public SASMobileMessagingDelegate2Wrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("messageDismissed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MessageDismissed ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("messageDismissed"));
		}
		[Export ("actionWithLink:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ActionWithLink (string link, SASMobileMessageType type)
		{
			if (link is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (link));
			var nslink = CFString.CreateNative (link);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("actionWithLink:type:"), nslink, (UIntPtr) (ulong) type);
			CFString.ReleaseNative (nslink);
		}
	}
}
namespace Com.SAS.CI360 {
	[Protocol()]
	[Register("ApiDefinition__Com_SAS_CI360_SASMobileMessagingDelegate2", false)]
	[Model]
	public unsafe abstract partial class SASMobileMessagingDelegate2 : NSObject, ISASMobileMessagingDelegate2 {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SASMobileMessagingDelegate2 () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASMobileMessagingDelegate2 (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASMobileMessagingDelegate2 (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("actionWithLink:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ActionWithLink (string link, SASMobileMessageType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("messageDismissed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MessageDismissed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SASMobileMessagingDelegate2 */
}
