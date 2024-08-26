using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sas.Mkt.Mobile.Sdk.ID {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.id']/interface[@name='IDProvider']"
	[Register ("com/sas/mkt/mobile/sdk/id/IDProvider", "", "Com.Sas.Mkt.Mobile.Sdk.ID.IDProviderInvoker")]
	public partial interface IDProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.id']/interface[@name='IDProvider']/method[@name='generateID' and count(parameter)=0]"
		[Register ("generateID", "()Ljava/lang/String;", "GetGenerateIDHandler:Com.Sas.Mkt.Mobile.Sdk.ID.IDProviderInvoker, MauiDemoApp.Binding.Android")]
		string? GenerateID ();

	}

	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/id/IDProvider", DoNotGenerateAcw=true)]
	internal partial class IDProviderInvoker : global::Java.Lang.Object, IDProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/id/IDProvider", typeof (IDProviderInvoker));

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

		public static IDProvider? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sas.mkt.mobile.sdk.id.IDProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_generateID;
#pragma warning disable 0169
		static Delegate GetGenerateIDHandler ()
		{
			if (cb_generateID == null)
				cb_generateID = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GenerateID));
			return cb_generateID;
		}

		static IntPtr n_GenerateID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.ID.IDProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GenerateID ());
		}
#pragma warning restore 0169

		IntPtr id_generateID;
		public unsafe string? GenerateID ()
		{
			if (id_generateID == IntPtr.Zero)
				id_generateID = JNIEnv.GetMethodID (class_ref, "generateID", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateID), JniHandleOwnership.TransferLocalRef);
		}

	}
}
