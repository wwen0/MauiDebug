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

namespace Com.Sas.Mkt.Mobile.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/ActivityLifecycleListener", DoNotGenerateAcw=true)]
	public partial class ActivityLifecycleListener : global::Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/ActivityLifecycleListener", typeof (ActivityLifecycleListener));

		internal static IntPtr class_ref {
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

		protected ActivityLifecycleListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/constructor[@name='ActivityLifecycleListener' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ActivityLifecycleListener (global::Android.Content.Context? context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_getCurrentActivity;
#pragma warning disable 0169
		static Delegate GetGetCurrentActivityHandler ()
		{
			if (cb_getCurrentActivity == null)
				cb_getCurrentActivity = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCurrentActivity));
			return cb_getCurrentActivity;
		}

		static IntPtr n_GetCurrentActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CurrentActivity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity? CurrentActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='getCurrentActivity' and count(parameter)=0]"
			[Register ("getCurrentActivity", "()Landroid/app/Activity;", "GetGetCurrentActivityHandler")]
			get {
				const string __id = "getCurrentActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_ignoreActivityReload;
#pragma warning disable 0169
		static Delegate GetIgnoreActivityReloadHandler ()
		{
			if (cb_ignoreActivityReload == null)
				cb_ignoreActivityReload = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_IgnoreActivityReload));
			return cb_ignoreActivityReload;
		}

		static void n_IgnoreActivityReload (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.IgnoreActivityReload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='ignoreActivityReload' and count(parameter)=0]"
		[Register ("ignoreActivityReload", "()V", "GetIgnoreActivityReloadHandler")]
		public virtual unsafe void IgnoreActivityReload ()
		{
			const string __id = "ignoreActivityReload.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_));
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_arg1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arg1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (activity, arg1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivityCreated (global::Android.App.Activity? activity, global::Android.OS.Bundle? arg1)
		{
			const string __id = "onActivityCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (arg1);
			}
		}

		static Delegate? cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnActivityDestroyed_Landroid_app_Activity_));
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityDestroyed (global::Android.App.Activity? activity)
		{
			const string __id = "onActivityDestroyed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate? cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnActivityPaused_Landroid_app_Activity_));
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityPaused (global::Android.App.Activity? activity)
		{
			const string __id = "onActivityPaused.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate? cb_onActivityPostResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPostResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPostResumed_Landroid_app_Activity_ == null)
				cb_onActivityPostResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnActivityPostResumed_Landroid_app_Activity_));
			return cb_onActivityPostResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityPostResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPostResumed (activity!);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivityPostResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPostResumed", "(Landroid/app/Activity;)V", "GetOnActivityPostResumed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityPostResumed (global::Android.App.Activity activity)
		{
			const string __id = "onActivityPostResumed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate? cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnActivityResumed_Landroid_app_Activity_));
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityResumed (global::Android.App.Activity? activity)
		{
			const string __id = "onActivityResumed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate? cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_));
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_arg1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arg1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (activity, arg1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivitySaveInstanceState (global::Android.App.Activity? activity, global::Android.OS.Bundle? arg1)
		{
			const string __id = "onActivitySaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (arg1);
			}
		}

		static Delegate? cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnActivityStarted_Landroid_app_Activity_));
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStarted (global::Android.App.Activity? activity)
		{
			const string __id = "onActivityStarted.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate? cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnActivityStopped_Landroid_app_Activity_));
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStopped (global::Android.App.Activity? activity)
		{
			const string __id = "onActivityStopped.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate? cb_setCurrentActivity_Landroid_app_Activity_Z;
#pragma warning disable 0169
		static Delegate GetSetCurrentActivity_Landroid_app_Activity_ZHandler ()
		{
			if (cb_setCurrentActivity_Landroid_app_Activity_Z == null)
				cb_setCurrentActivity_Landroid_app_Activity_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_V (n_SetCurrentActivity_Landroid_app_Activity_Z));
			return cb_setCurrentActivity_Landroid_app_Activity_Z;
		}

		static void n_SetCurrentActivity_Landroid_app_Activity_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, bool notifyListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ActivityLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentActivity (activity, notifyListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk']/class[@name='ActivityLifecycleListener']/method[@name='setCurrentActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean']]"
		[Register ("setCurrentActivity", "(Landroid/app/Activity;Z)V", "GetSetCurrentActivity_Landroid_app_Activity_ZHandler")]
		public virtual unsafe void SetCurrentActivity (global::Android.App.Activity? activity, bool notifyListener)
		{
			const string __id = "setCurrentActivity.(Landroid/app/Activity;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (notifyListener);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

	}
}
