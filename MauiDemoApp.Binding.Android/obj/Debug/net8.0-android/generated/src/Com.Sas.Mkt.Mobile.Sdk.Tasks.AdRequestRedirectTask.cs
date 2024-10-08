//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sas.Mkt.Mobile.Sdk.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/class[@name='AdRequestRedirectTask']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/tasks/AdRequestRedirectTask", DoNotGenerateAcw=true)]
	public partial class AdRequestRedirectTask : global::Com.Sas.Mkt.Mobile.Sdk.Tasks.BaseSASCollectorTask {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/class[@name='AdRequestRedirectTask']/field[@name='TAG']"
		[Register ("TAG")]
		public static string? Tag {
			get {
				const string __id = "TAG.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/interface[@name='AdRequestRedirectTask.ResultHandler']"
		[Register ("com/sas/mkt/mobile/sdk/tasks/AdRequestRedirectTask$ResultHandler", "", "Com.Sas.Mkt.Mobile.Sdk.Tasks.AdRequestRedirectTask/IResultHandlerInvoker")]
		public partial interface IResultHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/interface[@name='AdRequestRedirectTask.ResultHandler']/method[@name='handleError' and count(parameter)=1 and parameter[1][@type='com.sas.mkt.mobile.sdk.server.MidtierServicesException']]"
			[Register ("handleError", "(Lcom/sas/mkt/mobile/sdk/server/MidtierServicesException;)V", "GetHandleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_Handler:Com.Sas.Mkt.Mobile.Sdk.Tasks.AdRequestRedirectTask/IResultHandlerInvoker, MauiDemoApp.Binding.Android")]
			void HandleError (global::Com.Sas.Mkt.Mobile.Sdk.Server.MidtierServicesException? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/interface[@name='AdRequestRedirectTask.ResultHandler']/method[@name='handleResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("handleResult", "(Ljava/lang/String;)V", "GetHandleResult_Ljava_lang_String_Handler:Com.Sas.Mkt.Mobile.Sdk.Tasks.AdRequestRedirectTask/IResultHandlerInvoker, MauiDemoApp.Binding.Android")]
			void HandleResult (string? p0);

		}

		[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/tasks/AdRequestRedirectTask$ResultHandler", DoNotGenerateAcw=true)]
		internal partial class IResultHandlerInvoker : global::Java.Lang.Object, IResultHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/tasks/AdRequestRedirectTask$ResultHandler", typeof (IResultHandlerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IResultHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResultHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sas.mkt.mobile.sdk.tasks.AdRequestRedirectTask.ResultHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResultHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_;
#pragma warning disable 0169
			static Delegate GetHandleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_Handler ()
			{
				if (cb_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_ == null)
					cb_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_HandleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_));
				return cb_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_;
			}

			static void n_HandleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Tasks.AdRequestRedirectTask.IResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Server.MidtierServicesException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.HandleError (p0);
			}
#pragma warning restore 0169

			IntPtr id_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_;
			public unsafe void HandleError (global::Com.Sas.Mkt.Mobile.Sdk.Server.MidtierServicesException? p0)
			{
				if (id_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_ == IntPtr.Zero)
					id_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_ = JNIEnv.GetMethodID (class_ref, "handleError", "(Lcom/sas/mkt/mobile/sdk/server/MidtierServicesException;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleError_Lcom_sas_mkt_mobile_sdk_server_MidtierServicesException_, __args);
			}

			static Delegate? cb_handleResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetHandleResult_Ljava_lang_String_Handler ()
			{
				if (cb_handleResult_Ljava_lang_String_ == null)
					cb_handleResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_HandleResult_Ljava_lang_String_));
				return cb_handleResult_Ljava_lang_String_;
			}

			static void n_HandleResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Tasks.AdRequestRedirectTask.IResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.HandleResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_handleResult_Ljava_lang_String_;
			public unsafe void HandleResult (string? p0)
			{
				if (id_handleResult_Ljava_lang_String_ == IntPtr.Zero)
					id_handleResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleResult", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/tasks/AdRequestRedirectTask", typeof (AdRequestRedirectTask));

		internal static new IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected AdRequestRedirectTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/class[@name='AdRequestRedirectTask']/constructor[@name='AdRequestRedirectTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.sas.mkt.mobile.sdk.tasks.AdRequestRedirectTask.ResultHandler']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/sas/mkt/mobile/sdk/tasks/AdRequestRedirectTask$ResultHandler;)V", "")]
		public unsafe AdRequestRedirectTask (string? spotId, global::Com.Sas.Mkt.Mobile.Sdk.Tasks.AdRequestRedirectTask.IResultHandler? handler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/sas/mkt/mobile/sdk/tasks/AdRequestRedirectTask$ResultHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_spotId = JNIEnv.NewString ((string?)spotId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_spotId);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_spotId);
				global::System.GC.KeepAlive (handler);
			}
		}

		static Delegate? cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Run));
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Tasks.AdRequestRedirectTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/class[@name='AdRequestRedirectTask']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public override unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
