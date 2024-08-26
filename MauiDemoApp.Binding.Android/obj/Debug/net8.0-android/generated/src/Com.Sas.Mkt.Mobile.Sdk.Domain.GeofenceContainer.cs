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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='GeofenceContainer']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/domain/GeofenceContainer", DoNotGenerateAcw=true)]
	public partial class GeofenceContainer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/domain/GeofenceContainer", typeof (GeofenceContainer));

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

		protected GeofenceContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='GeofenceContainer']/constructor[@name='GeofenceContainer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeofenceContainer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getBoundingRegion;
#pragma warning disable 0169
		static Delegate GetGetBoundingRegionHandler ()
		{
			if (cb_getBoundingRegion == null)
				cb_getBoundingRegion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetBoundingRegion));
			return cb_getBoundingRegion;
		}

		static IntPtr n_GetBoundingRegion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.GeofenceContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.BoundingRegion);
		}
#pragma warning restore 0169

		static Delegate? cb_setBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_;
#pragma warning disable 0169
		static Delegate GetSetBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_Handler ()
		{
			if (cb_setBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_ == null)
				cb_setBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_));
			return cb_setBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_;
		}

		static void n_SetBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.GeofenceContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BoundingRegion = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence? BoundingRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='GeofenceContainer']/method[@name='getBoundingRegion' and count(parameter)=0]"
			[Register ("getBoundingRegion", "()Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;", "GetGetBoundingRegionHandler")]
			get {
				const string __id = "getBoundingRegion.()Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='GeofenceContainer']/method[@name='setBoundingRegion' and count(parameter)=1 and parameter[1][@type='com.sas.mkt.mobile.sdk.domain.SimpleGeofence']]"
			[Register ("setBoundingRegion", "(Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;)V", "GetSetBoundingRegion_Lcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_Handler")]
			set {
				const string __id = "setBoundingRegion.(Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getRegions;
#pragma warning disable 0169
		static Delegate GetGetRegionsHandler ()
		{
			if (cb_getRegions == null)
				cb_getRegions = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRegions));
			return cb_getRegions;
		}

		static IntPtr n_GetRegions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.GeofenceContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetRegions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='GeofenceContainer']/method[@name='getRegions' and count(parameter)=0]"
		[Register ("getRegions", "()[Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;", "GetGetRegionsHandler")]
		public virtual unsafe global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence[]? GetRegions ()
		{
			const string __id = "getRegions.()[Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence));
			} finally {
			}
		}

		static Delegate? cb_setRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_;
#pragma warning disable 0169
		static Delegate GetSetRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_Handler ()
		{
			if (cb_setRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_ == null)
				cb_setRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_));
			return cb_setRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_;
		}

		static void n_SetRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Domain.GeofenceContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence[]?) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence));
			__this.SetRegions (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.domain']/class[@name='GeofenceContainer']/method[@name='setRegions' and count(parameter)=1 and parameter[1][@type='com.sas.mkt.mobile.sdk.domain.SimpleGeofence[]']]"
		[Register ("setRegions", "([Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;)V", "GetSetRegions_arrayLcom_sas_mkt_mobile_sdk_domain_SimpleGeofence_Handler")]
		public virtual unsafe void SetRegions (global::Com.Sas.Mkt.Mobile.Sdk.Domain.SimpleGeofence[]? value)
		{
			const string __id = "setRegions.([Lcom/sas/mkt/mobile/sdk/domain/SimpleGeofence;)V";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
				global::System.GC.KeepAlive (value);
			}
		}

	}
}
