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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='ImageHandler']"
	[global::Android.Runtime.Register ("com/sas/mkt/mobile/sdk/util/ImageHandler", DoNotGenerateAcw=true)]
	public partial class ImageHandler : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sas/mkt/mobile/sdk/util/ImageHandler", typeof (ImageHandler));

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

		protected ImageHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='ImageHandler']/constructor[@name='ImageHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='ImageHandler']/method[@name='calculateInSampleSize' and count(parameter)=3 and parameter[1][@type='android.graphics.BitmapFactory.Options'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("calculateInSampleSize", "(Landroid/graphics/BitmapFactory$Options;II)I", "")]
		public static unsafe int CalculateInSampleSize (global::Android.Graphics.BitmapFactory.Options? options, int reqWidth, int reqHeight)
		{
			const string __id = "calculateInSampleSize.(Landroid/graphics/BitmapFactory$Options;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [1] = new JniArgumentValue (reqWidth);
				__args [2] = new JniArgumentValue (reqHeight);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='ImageHandler']/method[@name='loadAndScaleImage' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("loadAndScaleImage", "(Landroid/content/Context;Ljava/lang/String;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap? LoadAndScaleImage (global::Android.Content.Context? context, string? filename, int requiredWidth, int requiredHeight)
		{
			const string __id = "loadAndScaleImage.(Landroid/content/Context;Ljava/lang/String;II)Landroid/graphics/Bitmap;";
			IntPtr native_filename = JNIEnv.NewString ((string?)filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_filename);
				__args [2] = new JniArgumentValue (requiredWidth);
				__args [3] = new JniArgumentValue (requiredHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sas.mkt.mobile.sdk.util']/class[@name='ImageHandler']/method[@name='pixelsToDip' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("pixelsToDip", "(Landroid/content/Context;I)I", "")]
		public static unsafe int PixelsToDip (global::Android.Content.Context? context, int pixels)
		{
			const string __id = "pixelsToDip.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (pixels);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
