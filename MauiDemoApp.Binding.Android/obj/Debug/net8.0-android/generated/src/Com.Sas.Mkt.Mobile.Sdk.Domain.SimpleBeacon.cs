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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/domain/SimpleBeacon", DoNotGenerateAcw=true)]
	public partial class SimpleBeacon : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/domain/SimpleBeacon", typeof (SimpleBeacon));

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

		protected SimpleBeacon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']/constructor[@name='SimpleBeacon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleBeacon () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getBeaconUUID;
#pragma warning disable 0169
		static Delegate GetGetBeaconUUIDHandler ()
		{
			if (cb_getBeaconUUID == null)
				cb_getBeaconUUID = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetBeaconUUID));
			return cb_getBeaconUUID;
		}

		static IntPtr n_GetBeaconUUID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.BeaconUUID);
		}
#pragma warning restore 0169

		static Delegate? cb_setBeaconUUID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBeaconUUID_Ljava_lang_String_Handler ()
		{
			if (cb_setBeaconUUID_Ljava_lang_String_ == null)
				cb_setBeaconUUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBeaconUUID_Ljava_lang_String_));
			return cb_setBeaconUUID_Ljava_lang_String_;
		}

		static void n_SetBeaconUUID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconUUID = value;
		}
#pragma warning restore 0169

		public virtual unsafe string? BeaconUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']/method[@name='getBeaconUUID' and count(parameter)=0]"
			[Register ("getBeaconUUID", "()Ljava/lang/String;", "GetGetBeaconUUIDHandler")]
			get {
				const string __id = "getBeaconUUID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']/method[@name='setBeaconUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBeaconUUID", "(Ljava/lang/String;)V", "GetSetBeaconUUID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBeaconUUID.(Ljava/lang/String;)V";
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

		static Delegate? cb_getMajor;
#pragma warning disable 0169
		static Delegate GetGetMajorHandler ()
		{
			if (cb_getMajor == null)
				cb_getMajor = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_S (n_GetMajor));
			return cb_getMajor;
		}

		static short n_GetMajor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Major;
		}
#pragma warning restore 0169

		static Delegate? cb_setMajor_S;
#pragma warning disable 0169
		static Delegate GetSetMajor_SHandler ()
		{
			if (cb_setMajor_S == null)
				cb_setMajor_S = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPS_V (n_SetMajor_S));
			return cb_setMajor_S;
		}

		static void n_SetMajor_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Major = value;
		}
#pragma warning restore 0169

		public virtual unsafe short Major {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']/method[@name='getMajor' and count(parameter)=0]"
			[Register ("getMajor", "()S", "GetGetMajorHandler")]
			get {
				const string __id = "getMajor.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']/method[@name='setMajor' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setMajor", "(S)V", "GetSetMajor_SHandler")]
			set {
				const string __id = "setMajor.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getMinor;
#pragma warning disable 0169
		static Delegate GetGetMinorHandler ()
		{
			if (cb_getMinor == null)
				cb_getMinor = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_S (n_GetMinor));
			return cb_getMinor;
		}

		static short n_GetMinor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Minor;
		}
#pragma warning restore 0169

		static Delegate? cb_setMinor_S;
#pragma warning disable 0169
		static Delegate GetSetMinor_SHandler ()
		{
			if (cb_setMinor_S == null)
				cb_setMinor_S = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPS_V (n_SetMinor_S));
			return cb_setMinor_S;
		}

		static void n_SetMinor_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Minor = value;
		}
#pragma warning restore 0169

		public virtual unsafe short Minor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']/method[@name='getMinor' and count(parameter)=0]"
			[Register ("getMinor", "()S", "GetGetMinorHandler")]
			get {
				const string __id = "getMinor.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='SimpleBeacon']/method[@name='setMinor' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setMinor", "(S)V", "GetSetMinor_SHandler")]
			set {
				const string __id = "setMinor.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
