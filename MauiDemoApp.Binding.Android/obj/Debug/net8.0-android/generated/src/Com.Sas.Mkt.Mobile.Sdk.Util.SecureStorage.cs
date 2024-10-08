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

namespace Com.Sas.Mkt.Mobile.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SecureStorage']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/util/SecureStorage", DoNotGenerateAcw=true)]
	public partial class SecureStorage : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SecureStorage']/field[@name='TAG']"
		[Register ("TAG")]
		public static string? Tag {
			get {
				const string __id = "TAG.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/util/SecureStorage", typeof (SecureStorage));

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

		protected SecureStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Sas.Mkt.Mobile.Sdk.Util.SecureStorage? Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SecureStorage']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/sas/mkt/mobile/sdk/util/SecureStorage;", "")]
			get {
				const string __id = "getInstance.()Lcom/sas/mkt/mobile/sdk/util/SecureStorage;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Util.SecureStorage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_init_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInit_Ljava_lang_String_Handler ()
		{
			if (cb_init_Ljava_lang_String_ == null)
				cb_init_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Init_Ljava_lang_String_));
			return cb_init_Ljava_lang_String_;
		}

		static void n_Init_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tenantId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Util.SecureStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tenantId = JNIEnv.GetString (native_tenantId, JniHandleOwnership.DoNotTransfer);
			__this.Init (tenantId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SecureStorage']/method[@name='init' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("init", "(Ljava/lang/String;)V", "GetInit_Ljava_lang_String_Handler")]
		public virtual unsafe void Init (string? tenantId)
		{
			const string __id = "init.(Ljava/lang/String;)V";
			IntPtr native_tenantId = JNIEnv.NewString ((string?)tenantId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tenantId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tenantId);
			}
		}

		static Delegate? cb_readSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_readSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_readSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_L (n_ReadSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_));
			return cb_readSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ReadSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_key, IntPtr native_defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Util.SecureStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var defaultValue = JNIEnv.GetString (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadSimple (context, key, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SecureStorage']/method[@name='readSimple' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("readSimple", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetReadSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string? ReadSimple (global::Android.Content.Context? context, string? key, string? defaultValue)
		{
			const string __id = "readSimple.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_defaultValue = JNIEnv.NewString ((string?)defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defaultValue);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_removeSimple_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveSimple_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_removeSimple_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_removeSimple_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_RemoveSimple_Landroid_content_Context_Ljava_lang_String_));
			return cb_removeSimple_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_RemoveSimple_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Util.SecureStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSimple (context, key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SecureStorage']/method[@name='removeSimple' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeSimple", "(Landroid/content/Context;Ljava/lang/String;)V", "GetRemoveSimple_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveSimple (global::Android.Content.Context? context, string? key)
		{
			const string __id = "removeSimple.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_writeSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_writeSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_writeSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_WriteSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_));
			return cb_writeSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_WriteSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sas.Mkt.Mobile.Sdk.Util.SecureStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.WriteSimple (context, key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SecureStorage']/method[@name='writeSimple' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("writeSimple", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetWriteSimple_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteSimple (global::Android.Content.Context? context, string? key, string? value)
		{
			const string __id = "writeSimple.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
