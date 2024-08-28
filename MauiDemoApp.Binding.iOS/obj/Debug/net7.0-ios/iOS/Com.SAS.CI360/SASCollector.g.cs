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
	[Register("SASCollector", true)]
	public unsafe partial class SASCollector : NSObject, global::CoreLocation.ICLLocationManagerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SASCollector");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SASCollector () : base (NSObjectFlag.Empty)
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
		protected SASCollector (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASCollector (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAppEvent:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAppEvent (string eventKey, NSDictionary? data)
		{
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var data__handle__ = data.GetHandle ();
			var nseventKey = CFString.CreateNative (eventKey);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addAppEvent:data:"), nseventKey, data__handle__);
			CFString.ReleaseNative (nseventKey);
		}
		[Export ("addAppEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAppEvent (SASCollectorEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addAppEvent:"), @event__handle__);
		}
		[Export ("addAppEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAppEvents (SASCollectorEvent[] events)
		{
			if (events is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (events));
			var nsa_events = NSArray.FromNSObjects (events);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addAppEvents:"), nsa_events.Handle);
			nsa_events.Dispose ();
		}
		[Export ("detachIdentity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DetachIdentity ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("detachIdentity:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("determineIARequest:completionHandler:failureHandler:badResponseHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DetermineIARequest (string spotID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSString> completionHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<NSError> failureHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<NSUrlResponse> badResponseHandler)
		{
			if (spotID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spotID));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			if (failureHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (failureHandler));
			if (badResponseHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (badResponseHandler));
			var nsspotID = CFString.CreateNative (spotID);
			using var block_completionHandler = Trampolines.SDActionArity1V1.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			using var block_failureHandler = Trampolines.SDActionArity1V2.CreateBlock (failureHandler);
			BlockLiteral *block_ptr_failureHandler = &block_failureHandler;
			using var block_badResponseHandler = Trampolines.SDActionArity1V3.CreateBlock (badResponseHandler);
			BlockLiteral *block_ptr_badResponseHandler = &block_badResponseHandler;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("determineIARequest:completionHandler:failureHandler:badResponseHandler:"), nsspotID, (IntPtr) block_ptr_completionHandler, (IntPtr) block_ptr_failureHandler, (IntPtr) block_ptr_badResponseHandler);
			CFString.ReleaseNative (nsspotID);
		}
		[Export ("disableLocationMonitoring")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisableLocationMonitoring ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("disableLocationMonitoring"));
		}
		[Export ("getDecoratedWebSessionURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetDecoratedWebSessionURL (string url)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getDecoratedWebSessionURL:"), nsurl))!;
			CFString.ReleaseNative (nsurl);
			return ret!;
		}
		[Export ("handleMobileMessage:WithApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandleMobileMessage (NSDictionary userInfo, global::UIKit.UIApplication application)
		{
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("handleMobileMessage:WithApplication:"), userInfo__handle__, application__handle__);
		}
		[Export ("identity:withType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Identity (string value, string type)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nsvalue = CFString.CreateNative (value);
			var nstype = CFString.CreateNative (type);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("identity:withType:"), nsvalue, nstype);
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nstype);
		}
		[Export ("identity:withType:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Identity (string value, string type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsvalue = CFString.CreateNative (value);
			var nstype = CFString.CreateNative (type);
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("identity:withType:completion:"), nsvalue, nstype, (IntPtr) block_ptr_completionHandler);
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nstype);
		}
		[Export ("initializeCollection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitializeCollection ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("initializeCollection"));
		}
		[Export ("newPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NewPage (string uri)
		{
			if (uri is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (uri));
			var nsuri = CFString.CreateNative (uri);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("newPage:"), nsuri);
			CFString.ReleaseNative (nsuri);
		}
		[Export ("registerForMobileMessages:completionHandler:failureHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RegisterForMobileMessages (NSData deviceToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action failureHandler)
		{
			var deviceToken__handle__ = deviceToken!.GetNonNullHandle (nameof (deviceToken));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			if (failureHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (failureHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			using var block_failureHandler = Trampolines.SDAction.CreateBlock (failureHandler);
			BlockLiteral *block_ptr_failureHandler = &block_failureHandler;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("registerForMobileMessages:completionHandler:failureHandler:"), deviceToken__handle__, (IntPtr) block_ptr_completionHandler, (IntPtr) block_ptr_failureHandler);
		}
		[Export ("resetDeviceId")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetDeviceId ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("resetDeviceId"));
		}
		[Export ("setDeveloperInitialized")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDeveloperInitialized ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("setDeveloperInitialized"));
		}
		[Export ("setMobileMessagingDelegate2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMobileMessagingDelegate2 (SASMobileMessagingDelegate2? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setMobileMessagingDelegate2:"), @delegate__handle__);
		}
		[Export ("shutdown")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Shutdown ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("shutdown"));
		}
		[Export ("shutdownAndDetachIdentity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ShutdownAndDetachIdentity ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("shutdownAndDetachIdentity:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("skewClock:key:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SkewClock (double ms, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_NativeHandle (class_ptr, Selector.GetHandle ("skewClock:key:"), ms, nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("startMonitoringLocation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartMonitoringLocation ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("startMonitoringLocation"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? AppId {
			[Export ("appId")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("appId")))!;
			}
			[Export ("setAppId:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setAppId:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ApplicationVersion {
			[Export ("applicationVersion")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("applicationVersion")))!;
			}
			[Export ("setApplicationVersion:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setApplicationVersion:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::WebKit.WKWebsiteDataStore? ConfiguredWKWebsiteDatastore {
			[Export ("getConfiguredWKWebsiteDatastore")]
			get {
				global::WebKit.WKWebsiteDataStore? ret;
				ret =  Runtime.GetNSObject<global::WebKit.WKWebsiteDataStore> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getConfiguredWKWebsiteDatastore")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? CurrentGEOFence {
			[Export ("currentGEOFence")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("currentGEOFence")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? DeviceId {
			[Export ("deviceId")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("deviceId")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsEnabled {
			[Export ("isEnabled")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isEnabled"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreLocation.CLLocationManager? LocationManager {
			[Export ("locationManager")]
			get {
				global::CoreLocation.CLLocationManager? ret;
				ret =  Runtime.GetNSObject<global::CoreLocation.CLLocationManager> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("locationManager")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string SdkVersion {
			[Export ("sdkVersion")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sdkVersion")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? SessionBindingParamter {
			[Export ("getSessionBindingParamter")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getSessionBindingParamter")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::WebKit.WKWebViewConfiguration? SessionWKWebViewConfiguration {
			[Export ("getSessionWKWebViewConfiguration")]
			get {
				global::WebKit.WKWebViewConfiguration? ret;
				ret =  Runtime.GetNSObject<global::WebKit.WKWebViewConfiguration> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getSessionWKWebViewConfiguration")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? TagServer {
			[Export ("tagServer")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("tagServer")))!;
			}
			[Export ("setTagServer:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setTagServer:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? TenantId {
			[Export ("tenantId")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("tenantId")))!;
			}
			[Export ("setTenantId:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setTenantId:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class SASCollector */
}
