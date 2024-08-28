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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		unsafe internal delegate void DAction (IntPtr block);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block) {
				var del = BlockLiteral.GetTarget<global::System.Action> (block);
				if (del != null) {
					del ();
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action callback)
			{
				delegate* unmanaged<IntPtr, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDAction), nameof (Invoke));
			}
		} /* class SDAction */
		internal sealed class NIDAction : TrampolineBlockBase {
			DAction invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAction (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action) GetExistingManagedDelegate (block);
				return del ?? new NIDAction ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDAction */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSError>))]
		unsafe internal delegate void DActionArity1V2 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V2 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSError>> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<NSError> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSError>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSError> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V2), nameof (Invoke));
			}
		} /* class SDActionArity1V2 */
		internal sealed class NIDActionArity1V2 : TrampolineBlockBase {
			DActionArity1V2 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V2 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V2> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSError>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSError>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V2 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V2 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString>))]
		unsafe internal delegate void DActionArity1V1 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSString>> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<NSString> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSString>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSString> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V1), nameof (Invoke));
			}
		} /* class SDActionArity1V1 */
		internal sealed class NIDActionArity1V1 : TrampolineBlockBase {
			DActionArity1V1 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSString>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSString>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSString obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V1 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSUrlResponse>))]
		unsafe internal delegate void DActionArity1V3 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V3 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSUrlResponse>> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<NSUrlResponse> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSUrlResponse>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSUrlResponse> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V3), nameof (Invoke));
			}
		} /* class SDActionArity1V3 */
		internal sealed class NIDActionArity1V3 : TrampolineBlockBase {
			DActionArity1V3 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V3 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V3> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSUrlResponse>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSUrlResponse>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V3 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSUrlResponse obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V3 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<bool>))]
		unsafe internal delegate void DActionArity1V0 (IntPtr block, byte obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, byte obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<bool>> (block);
				if (del != null) {
					del (obj != 0);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<bool>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<bool> callback)
			{
				delegate* unmanaged<IntPtr, byte, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V0), nameof (Invoke));
			}
		} /* class SDActionArity1V0 */
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool obj)
			{
				invoker (BlockPointer, obj ? (byte) 1 : (byte) 0);
			}
		} /* class NIDActionArity1V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSObject, NSError>))]
		unsafe internal delegate void DActionArity2V0 (IntPtr block, NativeHandle arg1, NativeHandle arg2);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSObject, NSError>> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<NSObject> (arg1)!,  Runtime.GetNSObject<NSError> (arg2)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSObject, NSError>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSObject, NSError> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity2V0), nameof (Invoke));
			}
		} /* class SDActionArity2V0 */
		internal sealed class NIDActionArity2V0 : TrampolineBlockBase {
			DActionArity2V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSObject, NSError>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSObject, NSError>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSObject arg1, NSError arg2)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__);
			}
		} /* class NIDActionArity2V0 */
	}
}
