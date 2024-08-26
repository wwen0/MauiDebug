//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Com.SAS.CI360 {
	[Protocol (Name = "SASLoggerFormatter", WrapperType = typeof (SASLoggerFormatterWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FormatLevel", Selector = "formatLevel:file:function:line:msg:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (Com.SAS.CI360.SASLoggerFlag), typeof (string), typeof (string), typeof (UIntPtr), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public partial interface ISASLoggerFormatter : INativeObject, IDisposable
	{
		[RequiredMember]
		[Export ("formatLevel:file:function:line:msg:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FormatLevel (SASLoggerFlag flag, string file, string function, nuint line, string msg)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _FormatLevel (ISASLoggerFormatter This, SASLoggerFlag flag, string file, string function, nuint line, string msg)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[DynamicDependencyAttribute ("FormatLevel(Com.SAS.CI360.SASLoggerFlag,System.String,System.String,System.UIntPtr,System.String)")]
		static ISASLoggerFormatter ()
		{
			GC.KeepAlive (null);
		}
	}
	internal unsafe sealed class SASLoggerFormatterWrapper : BaseWrapper, ISASLoggerFormatter {
		[Preserve (Conditional = true)]
		public SASLoggerFormatterWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("formatLevel:file:function:line:msg:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string FormatLevel (SASLoggerFlag flag, string file, string function, nuint line, string msg)
		{
			if (file is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (file));
			if (function is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (function));
			if (msg is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (msg));
			var nsfile = CFString.CreateNative (file);
			var nsfunction = CFString.CreateNative (function);
			var nsmsg = CFString.CreateNative (msg);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("formatLevel:file:function:line:msg:"), (UIntPtr) (ulong) flag, nsfile, nsfunction, line, nsmsg))!;
			CFString.ReleaseNative (nsfile);
			CFString.ReleaseNative (nsfunction);
			CFString.ReleaseNative (nsmsg);
			return ret!;
		}
	}
}
namespace Com.SAS.CI360 {
	[Protocol()]
	[Register("ApiDefinition__Com_SAS_CI360_SASLoggerFormatter", false)]
	[Model]
	public unsafe abstract partial class SASLoggerFormatter : NSObject, ISASLoggerFormatter {
		/// <summary>Creates a new <see cref="SASLoggerFormatter" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SASLoggerFormatter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, initWithFrame, frame);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SASLoggerFormatter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SASLoggerFormatter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("formatLevel:file:function:line:msg:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FormatLevel (SASLoggerFlag flag, string file, string function, nuint line, string msg)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SASLoggerFormatter */
}
