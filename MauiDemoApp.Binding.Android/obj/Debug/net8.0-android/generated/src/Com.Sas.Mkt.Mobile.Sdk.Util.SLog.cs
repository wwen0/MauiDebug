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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/util/SLog", DoNotGenerateAcw=true)]
	public partial class SLog : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='ALL']"
		[Register ("ALL")]
		public const int All = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const int Debug = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='NONE']"
		[Register ("NONE")]
		public const int None = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='TAG_API']"
		[Register ("TAG_API")]
		public const string TagApi = (string) "SASCOLLECTOR_API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public const int Verbose = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/field[@name='WARN']"
		[Register ("WARN")]
		public const int Warn = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/util/SLog", typeof (SLog));

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

		protected SLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/constructor[@name='SLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SLog () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe int Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()I", "")]
			get {
				const string __id = "getLevel.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLevel", "(I)V", "")]
			set {
				const string __id = "setLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("api", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Api (string? name, params global::Java.Lang.Object[]? args)
		{
			const string __id = "api.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string? tag, global::Java.Lang.ICharSequence? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_format = CharSequence.ToLocalJniHandle (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (args);
			}
		}

		public static void D (string? tag, string? format, params global::Java.Lang.Object[]? args)
		{
			var jls_format = format == null ? null : new global::Java.Lang.String (format);
			D (tag, jls_format, args);
			jls_format?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='dapi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("dapi", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Dapi (string? name, params global::Java.Lang.Object[]? args)
		{
			const string __id = "dapi.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string? tag, global::Java.Lang.ICharSequence? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_format = CharSequence.ToLocalJniHandle (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (args);
			}
		}

		public static void E (string? tag, string? format, params global::Java.Lang.Object[]? args)
		{
			var jls_format = format == null ? null : new global::Java.Lang.String (format);
			E (tag, jls_format, args);
			jls_format?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='e' and count(parameter)=4 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable? t, string? tag, global::Java.Lang.ICharSequence? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "e.(Ljava/lang/Throwable;Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_format = CharSequence.ToLocalJniHandle (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				__args [1] = new JniArgumentValue (native_tag);
				__args [2] = new JniArgumentValue (native_format);
				__args [3] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (t);
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (args);
			}
		}

		public static void E (global::Java.Lang.Throwable? t, string? tag, string? format, params global::Java.Lang.Object[]? args)
		{
			var jls_format = format == null ? null : new global::Java.Lang.String (format);
			E (t, tag, jls_format, args);
			jls_format?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='fullException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("fullException", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void FullException (string? tag, string? context, global::Java.Lang.Throwable? t)
		{
			const string __id = "fullException.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_context = JNIEnv.NewString ((string?)context);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_context);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_context);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string? tag, global::Java.Lang.ICharSequence? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_format = CharSequence.ToLocalJniHandle (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (args);
			}
		}

		public static void I (string? tag, string? format, params global::Java.Lang.Object[]? args)
		{
			var jls_format = format == null ? null : new global::Java.Lang.String (format);
			I (tag, jls_format, args);
			jls_format?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string? tag, global::Java.Lang.ICharSequence? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_format = CharSequence.ToLocalJniHandle (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (args);
			}
		}

		public static void V (string? tag, string? format, params global::Java.Lang.Object[]? args)
		{
			var jls_format = format == null ? null : new global::Java.Lang.String (format);
			V (tag, jls_format, args);
			jls_format?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='SLog']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string? tag, global::Java.Lang.ICharSequence? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/CharSequence;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_format = CharSequence.ToLocalJniHandle (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (args);
			}
		}

		public static void W (string? tag, string? format, params global::Java.Lang.Object[]? args)
		{
			var jls_format = format == null ? null : new global::Java.Lang.String (format);
			W (tag, jls_format, args);
			jls_format?.Dispose ();
		}

	}
}
