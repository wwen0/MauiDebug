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

namespace Com.Sas.Mkt.Mobile.Sdk.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/domain/TokenData", DoNotGenerateAcw=true)]
	public partial class TokenData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/domain/TokenData", typeof (TokenData));

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

		protected TokenData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']/constructor[@name='TokenData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAppId));
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.TokenData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static Delegate? cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAppId_Ljava_lang_String_));
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.TokenData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var appId = JNIEnv.GetString (native_appId, JniHandleOwnership.DoNotTransfer);
			__this.AppId = appId;
		}
#pragma warning restore 0169

		public virtual unsafe string? AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				const string __id = "getAppId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDeviceId));
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.TokenData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		static Delegate? cb_setDeviceId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceId_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceId_Ljava_lang_String_ == null)
				cb_setDeviceId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetDeviceId_Ljava_lang_String_));
			return cb_setDeviceId_Ljava_lang_String_;
		}

		static void n_SetDeviceId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.TokenData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DeviceId = value;
		}
#pragma warning restore 0169

		public virtual unsafe string? DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				const string __id = "getDeviceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']/method[@name='setDeviceId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceId", "(Ljava/lang/String;)V", "GetSetDeviceId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetToken));
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.TokenData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate? cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetToken_Ljava_lang_String_));
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.TokenData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Token = value;
		}
#pragma warning restore 0169

		public virtual unsafe string? Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='TokenData']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setToken.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
