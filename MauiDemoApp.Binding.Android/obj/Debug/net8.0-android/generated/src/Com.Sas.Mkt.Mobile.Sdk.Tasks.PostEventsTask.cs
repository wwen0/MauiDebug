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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/class[@name='PostEventsTask']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/tasks/PostEventsTask", DoNotGenerateAcw=true)]
	public partial class PostEventsTask : global::Com.Sas.Mkt.Mobile.Sdk.Tasks.BaseSASCollectorTask {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/interface[@name='PostEventsTask.ResultHandler']"
		[Register ("com/sas/mkt/mobile/sdk/tasks/PostEventsTask$ResultHandler", "", "Com.Sas.Mkt.Mobile.Sdk.Tasks.PostEventsTask/IResultHandlerInvoker")]
		public partial interface IResultHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/interface[@name='PostEventsTask.ResultHandler']/method[@name='handleFailure' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.sas.mkt.mobile.sdk.domain.MobileEvent&gt;'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("handleFailure", "(Ljava/util/List;Ljava/lang/Exception;)V", "GetHandleFailure_Ljava_util_List_Ljava_lang_Exception_Handler:Com.Sas.Mkt.Mobile.Sdk.Tasks.PostEventsTask/IResultHandlerInvoker, MauiDemoApp.Binding.Android")]
			void HandleFailure (global::System.Collections.Generic.IList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>? p0, global::Java.Lang.Exception? p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/interface[@name='PostEventsTask.ResultHandler']/method[@name='handleSuccess' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.sas.mkt.mobile.sdk.domain.MobileEvent&gt;']]"
			[Register ("handleSuccess", "(Ljava/util/List;)V", "GetHandleSuccess_Ljava_util_List_Handler:Com.Sas.Mkt.Mobile.Sdk.Tasks.PostEventsTask/IResultHandlerInvoker, MauiDemoApp.Binding.Android")]
			void HandleSuccess (global::System.Collections.Generic.IList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>? p0);

		}

		[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/tasks/PostEventsTask$ResultHandler", DoNotGenerateAcw=true)]
		internal partial class IResultHandlerInvoker : global::Java.Lang.Object, IResultHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/tasks/PostEventsTask$ResultHandler", typeof (IResultHandlerInvoker));

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
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sas.mkt.mobile.sdk.tasks.PostEventsTask.ResultHandler'.");
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

			static Delegate? cb_handleFailure_Ljava_util_List_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetHandleFailure_Ljava_util_List_Ljava_lang_Exception_Handler ()
			{
				if (cb_handleFailure_Ljava_util_List_Ljava_lang_Exception_ == null)
					cb_handleFailure_Ljava_util_List_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_HandleFailure_Ljava_util_List_Ljava_lang_Exception_));
				return cb_handleFailure_Ljava_util_List_Ljava_lang_Exception_;
			}

			static void n_HandleFailure_Ljava_util_List_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Tasks.PostEventsTask.IResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Android.Runtime.JavaList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.HandleFailure (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_handleFailure_Ljava_util_List_Ljava_lang_Exception_;
			public unsafe void HandleFailure (global::System.Collections.Generic.IList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>? p0, global::Java.Lang.Exception? p1)
			{
				if (id_handleFailure_Ljava_util_List_Ljava_lang_Exception_ == IntPtr.Zero)
					id_handleFailure_Ljava_util_List_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "handleFailure", "(Ljava/util/List;Ljava/lang/Exception;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleFailure_Ljava_util_List_Ljava_lang_Exception_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate? cb_handleSuccess_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetHandleSuccess_Ljava_util_List_Handler ()
			{
				if (cb_handleSuccess_Ljava_util_List_ == null)
					cb_handleSuccess_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_HandleSuccess_Ljava_util_List_));
				return cb_handleSuccess_Ljava_util_List_;
			}

			static void n_HandleSuccess_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Tasks.PostEventsTask.IResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Android.Runtime.JavaList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.HandleSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_handleSuccess_Ljava_util_List_;
			public unsafe void HandleSuccess (global::System.Collections.Generic.IList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>? p0)
			{
				if (id_handleSuccess_Ljava_util_List_ == IntPtr.Zero)
					id_handleSuccess_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "handleSuccess", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleSuccess_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/tasks/PostEventsTask", typeof (PostEventsTask));

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

		protected PostEventsTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/class[@name='PostEventsTask']/constructor[@name='PostEventsTask' and count(parameter)=2 and parameter[1][@type='com.sas.mkt.mobile.sdk.tasks.PostEventsTask.ResultHandler'] and parameter[2][@type='java.util.List&lt;com.sas.mkt.mobile.sdk.domain.MobileEvent&gt;']]"
		[Register (".ctor", "(Lcom/sas/mkt/mobile/sdk/tasks/PostEventsTask$ResultHandler;Ljava/util/List;)V", "")]
		public unsafe PostEventsTask (global::Com.Sas.Mkt.Mobile.Sdk.Tasks.PostEventsTask.IResultHandler? handler, global::System.Collections.Generic.IList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>? events) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/sas/mkt/mobile/sdk/tasks/PostEventsTask$ResultHandler;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_events = global::Android.Runtime.JavaList<global::Com.Sas.Mkt.Mobile.Sdk.Domain.MobileEvent>.ToLocalJniHandle (events);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue (native_events);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_events);
				global::System.GC.KeepAlive (handler);
				global::System.GC.KeepAlive (events);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Tasks.PostEventsTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.tasks']/class[@name='PostEventsTask']/method[@name='run' and count(parameter)=0]"
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
