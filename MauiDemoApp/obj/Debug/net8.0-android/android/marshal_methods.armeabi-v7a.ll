; ModuleID = 'marshal_methods.armeabi-v7a.ll'
source_filename = "marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [344 x ptr] zeroinitializer, align 4

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [682 x i32] [
	i32 2616222, ; 0: System.Net.NetworkInformation.dll => 0x27eb9e => 68
	i32 10166715, ; 1: System.Net.NameResolution.dll => 0x9b21bb => 67
	i32 15721112, ; 2: System.Runtime.Intrinsics.dll => 0xefe298 => 108
	i32 32687329, ; 3: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 235
	i32 34715100, ; 4: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 288
	i32 34839235, ; 5: System.IO.FileSystem.DriveInfo => 0x2139ac3 => 48
	i32 39485524, ; 6: System.Net.WebSockets.dll => 0x25a8054 => 80
	i32 42639949, ; 7: System.Threading.Thread => 0x28aa24d => 145
	i32 45981941, ; 8: Xamarin.KotlinX.AtomicFU.Jvm => 0x2bda0f5 => 300
	i32 53857724, ; 9: ca/Microsoft.Maui.Controls.resources => 0x335cdbc => 306
	i32 57305218, ; 10: Xamarin.KotlinX.Coroutines.Play.Services => 0x36a6882 => 304
	i32 66541672, ; 11: System.Diagnostics.StackTrace => 0x3f75868 => 30
	i32 68219467, ; 12: System.Security.Cryptography.Primitives => 0x410f24b => 124
	i32 72070932, ; 13: Microsoft.Maui.Graphics.dll => 0x44bb714 => 191
	i32 82292897, ; 14: System.Runtime.CompilerServices.VisualC.dll => 0x4e7b0a1 => 102
	i32 101534019, ; 15: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 256
	i32 103834273, ; 16: Xamarin.Firebase.Annotations.dll => 0x63062a1 => 268
	i32 113429830, ; 17: zh-HK/Microsoft.Maui.Controls.resources => 0x6c2cd46 => 336
	i32 117431740, ; 18: System.Runtime.InteropServices => 0x6ffddbc => 107
	i32 120558881, ; 19: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 256
	i32 122350210, ; 20: System.Threading.Channels.dll => 0x74aea82 => 139
	i32 134690465, ; 21: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 297
	i32 142721839, ; 22: System.Net.WebHeaderCollection => 0x881c32f => 77
	i32 149972175, ; 23: System.Security.Cryptography.Primitives.dll => 0x8f064cf => 124
	i32 159306688, ; 24: System.ComponentModel.Annotations => 0x97ed3c0 => 13
	i32 165246403, ; 25: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 207
	i32 166070894, ; 26: Xamarin.KotlinX.AtomicFU.dll => 0x9e60a6e => 299
	i32 176265551, ; 27: System.ServiceProcess => 0xa81994f => 132
	i32 182336117, ; 28: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 258
	i32 184328833, ; 29: System.ValueTuple.dll => 0xafca281 => 151
	i32 195452805, ; 30: vi/Microsoft.Maui.Controls.resources.dll => 0xba65f85 => 335
	i32 199333315, ; 31: zh-HK/Microsoft.Maui.Controls.resources.dll => 0xbe195c3 => 336
	i32 205061960, ; 32: System.ComponentModel => 0xc38ff48 => 18
	i32 209399409, ; 33: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 205
	i32 220171995, ; 34: System.Diagnostics.Debug => 0xd1f8edb => 26
	i32 230216969, ; 35: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 228
	i32 230752869, ; 36: Microsoft.CSharp.dll => 0xdc10265 => 1
	i32 231409092, ; 37: System.Linq.Parallel => 0xdcb05c4 => 59
	i32 231814094, ; 38: System.Globalization => 0xdd133ce => 42
	i32 246610117, ; 39: System.Reflection.Emit.Lightweight => 0xeb2f8c5 => 91
	i32 261689757, ; 40: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 211
	i32 276479776, ; 41: System.Threading.Timer.dll => 0x107abf20 => 147
	i32 278686392, ; 42: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 231
	i32 280482487, ; 43: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 227
	i32 280992041, ; 44: cs/Microsoft.Maui.Controls.resources.dll => 0x10bf9929 => 307
	i32 291076382, ; 45: System.IO.Pipes.AccessControl.dll => 0x1159791e => 54
	i32 298918909, ; 46: System.Net.Ping.dll => 0x11d123fd => 69
	i32 318968648, ; 47: Xamarin.AndroidX.Activity.dll => 0x13031348 => 196
	i32 321597661, ; 48: System.Numerics => 0x132b30dd => 83
	i32 336156722, ; 49: ja/Microsoft.Maui.Controls.resources.dll => 0x14095832 => 320
	i32 342366114, ; 50: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 229
	i32 356389973, ; 51: it/Microsoft.Maui.Controls.resources.dll => 0x153e1455 => 319
	i32 357576608, ; 52: cs/Microsoft.Maui.Controls.resources => 0x15502fa0 => 307
	i32 360082299, ; 53: System.ServiceModel.Web => 0x15766b7b => 131
	i32 367780167, ; 54: System.IO.Pipes => 0x15ebe147 => 55
	i32 374914964, ; 55: System.Transactions.Local => 0x1658bf94 => 149
	i32 375677976, ; 56: System.Net.ServicePoint.dll => 0x16646418 => 74
	i32 379916513, ; 57: System.Threading.Thread.dll => 0x16a510e1 => 145
	i32 385762202, ; 58: System.Memory.dll => 0x16fe439a => 62
	i32 392610295, ; 59: System.Threading.ThreadPool.dll => 0x1766c1f7 => 146
	i32 395744057, ; 60: _Microsoft.Android.Resource.Designer => 0x17969339 => 340
	i32 403441872, ; 61: WindowsBase => 0x180c08d0 => 165
	i32 425531652, ; 62: Xamarin.AndroidX.Lifecycle.Runtime.Android => 0x195d1904 => 236
	i32 435591531, ; 63: sv/Microsoft.Maui.Controls.resources.dll => 0x19f6996b => 331
	i32 441335492, ; 64: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 212
	i32 442565967, ; 65: System.Collections => 0x1a61054f => 12
	i32 450948140, ; 66: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 225
	i32 451504562, ; 67: System.Security.Cryptography.X509Certificates => 0x1ae969b2 => 125
	i32 456227837, ; 68: System.Web.HttpUtility.dll => 0x1b317bfd => 152
	i32 459347974, ; 69: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 113
	i32 465846621, ; 70: mscorlib => 0x1bc4415d => 166
	i32 469710990, ; 71: System.dll => 0x1bff388e => 164
	i32 476646585, ; 72: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 227
	i32 485140951, ; 73: Xamarin.Google.Android.DataTransport.TransportRuntime => 0x1ceaa9d7 => 283
	i32 486930444, ; 74: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 244
	i32 495452658, ; 75: Xamarin.Google.Android.DataTransport.TransportRuntime.dll => 0x1d8801f2 => 283
	i32 498788369, ; 76: System.ObjectModel => 0x1dbae811 => 84
	i32 500358224, ; 77: id/Microsoft.Maui.Controls.resources.dll => 0x1dd2dc50 => 318
	i32 503918385, ; 78: fi/Microsoft.Maui.Controls.resources.dll => 0x1e092f31 => 312
	i32 507148113, ; 79: Xamarin.Google.Android.DataTransport.TransportApi.dll => 0x1e3a7751 => 281
	i32 513247710, ; 80: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 185
	i32 526420162, ; 81: System.Transactions.dll => 0x1f6088c2 => 150
	i32 527168573, ; 82: hi/Microsoft.Maui.Controls.resources => 0x1f6bf43d => 315
	i32 527452488, ; 83: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 297
	i32 530272170, ; 84: System.Linq.Queryable => 0x1f9b4faa => 60
	i32 539058512, ; 85: Microsoft.Extensions.Logging => 0x20216150 => 181
	i32 540030774, ; 86: System.IO.FileSystem.dll => 0x20303736 => 51
	i32 542030372, ; 87: Xamarin.GooglePlayServices.Stats => 0x204eba24 => 292
	i32 545304856, ; 88: System.Runtime.Extensions => 0x2080b118 => 103
	i32 546455878, ; 89: System.Runtime.Serialization.Xml => 0x20924146 => 114
	i32 549171840, ; 90: System.Globalization.Calendars => 0x20bbb280 => 40
	i32 557405415, ; 91: Jsr305Binding => 0x213954e7 => 285
	i32 569601784, ; 92: Xamarin.AndroidX.Window.Extensions.Core.Core => 0x21f36ef8 => 267
	i32 577335427, ; 93: System.Security.Cryptography.Cng => 0x22697083 => 120
	i32 592146354, ; 94: pt-BR/Microsoft.Maui.Controls.resources.dll => 0x234b6fb2 => 326
	i32 597488923, ; 95: CommunityToolkit.Maui => 0x239cf51b => 173
	i32 601371474, ; 96: System.IO.IsolatedStorage.dll => 0x23d83352 => 52
	i32 605376203, ; 97: System.IO.Compression.FileSystem => 0x24154ecb => 44
	i32 613668793, ; 98: System.Security.Cryptography.Algorithms => 0x2493d7b9 => 119
	i32 621990341, ; 99: Xamarin.AndroidX.Lifecycle.Runtime.Android.dll => 0x2512d1c5 => 236
	i32 627609679, ; 100: Xamarin.AndroidX.CustomView => 0x2568904f => 217
	i32 635680787, ; 101: MauiDemoApp.dll => 0x25e3b813 => 0
	i32 639843206, ; 102: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 223
	i32 643868501, ; 103: System.Net => 0x2660a755 => 81
	i32 662205335, ; 104: System.Text.Encodings.Web.dll => 0x27787397 => 136
	i32 663517072, ; 105: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 263
	i32 666292255, ; 106: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 203
	i32 672442732, ; 107: System.Collections.Concurrent => 0x2814a96c => 8
	i32 679221896, ; 108: Xamarin.KotlinX.AtomicFU => 0x287c1a88 => 299
	i32 683518922, ; 109: System.Net.Security => 0x28bdabca => 73
	i32 688181140, ; 110: ca/Microsoft.Maui.Controls.resources.dll => 0x2904cf94 => 306
	i32 690569205, ; 111: System.Xml.Linq.dll => 0x29293ff5 => 155
	i32 691348768, ; 112: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 301
	i32 693804605, ; 113: System.Windows => 0x295a9e3d => 154
	i32 699345723, ; 114: System.Reflection.Emit => 0x29af2b3b => 92
	i32 700284507, ; 115: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 295
	i32 700358131, ; 116: System.IO.Compression.ZipFile => 0x29be9df3 => 45
	i32 706645707, ; 117: ko/Microsoft.Maui.Controls.resources.dll => 0x2a1e8ecb => 321
	i32 709557578, ; 118: de/Microsoft.Maui.Controls.resources.dll => 0x2a4afd4a => 309
	i32 720511267, ; 119: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 298
	i32 722857257, ; 120: System.Runtime.Loader.dll => 0x2b15ed29 => 109
	i32 735137430, ; 121: System.Security.SecureString.dll => 0x2bd14e96 => 129
	i32 752232764, ; 122: System.Diagnostics.Contracts.dll => 0x2cd6293c => 25
	i32 755313932, ; 123: Xamarin.Android.Glide.Annotations.dll => 0x2d052d0c => 193
	i32 759454413, ; 124: System.Net.Requests => 0x2d445acd => 72
	i32 762598435, ; 125: System.IO.Pipes.dll => 0x2d745423 => 55
	i32 775507847, ; 126: System.IO.Compression => 0x2e394f87 => 46
	i32 789151979, ; 127: Microsoft.Extensions.Options => 0x2f0980eb => 184
	i32 790371945, ; 128: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 218
	i32 804715423, ; 129: System.Data.Common => 0x2ff6fb9f => 22
	i32 807930345, ; 130: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx.dll => 0x302809e9 => 233
	i32 823281589, ; 131: System.Private.Uri.dll => 0x311247b5 => 86
	i32 830298997, ; 132: System.IO.Compression.Brotli => 0x317d5b75 => 43
	i32 832635846, ; 133: System.Xml.XPath.dll => 0x31a103c6 => 160
	i32 834051424, ; 134: System.Net.Quic => 0x31b69d60 => 71
	i32 843511501, ; 135: Xamarin.AndroidX.Print => 0x3246f6cd => 249
	i32 846667644, ; 136: Xamarin.Firebase.Installations.dll => 0x32771f7c => 277
	i32 870878177, ; 137: ar/Microsoft.Maui.Controls.resources => 0x33e88be1 => 305
	i32 873119928, ; 138: Microsoft.VisualBasic => 0x340ac0b8 => 3
	i32 877678880, ; 139: System.Globalization.dll => 0x34505120 => 42
	i32 878954865, ; 140: System.Net.Http.Json => 0x3463c971 => 63
	i32 882434999, ; 141: Xamarin.Firebase.Installations.InterOp.dll => 0x3498e3b7 => 278
	i32 904024072, ; 142: System.ComponentModel.Primitives.dll => 0x35e25008 => 16
	i32 911108515, ; 143: System.IO.MemoryMappedFiles.dll => 0x364e69a3 => 53
	i32 926902833, ; 144: tr/Microsoft.Maui.Controls.resources.dll => 0x373f6a31 => 333
	i32 928116545, ; 145: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 288
	i32 952186615, ; 146: System.Runtime.InteropServices.JavaScript.dll => 0x38c136f7 => 105
	i32 956575887, ; 147: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 298
	i32 966729478, ; 148: Xamarin.Google.Crypto.Tink.Android => 0x399f1f06 => 286
	i32 967690846, ; 149: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 229
	i32 975236339, ; 150: System.Diagnostics.Tracing => 0x3a20ecf3 => 34
	i32 975874589, ; 151: System.Xml.XDocument => 0x3a2aaa1d => 158
	i32 986514023, ; 152: System.Private.DataContractSerialization.dll => 0x3acd0267 => 85
	i32 987214855, ; 153: System.Diagnostics.Tools => 0x3ad7b407 => 32
	i32 992768348, ; 154: System.Collections.dll => 0x3b2c715c => 12
	i32 993161700, ; 155: zh-Hans/Microsoft.Maui.Controls.resources => 0x3b3271e4 => 337
	i32 994442037, ; 156: System.IO.FileSystem => 0x3b45fb35 => 51
	i32 994547685, ; 157: es/Microsoft.Maui.Controls.resources => 0x3b4797e5 => 311
	i32 996733531, ; 158: Xamarin.Google.Android.DataTransport.TransportBackendCct => 0x3b68f25b => 282
	i32 1001831731, ; 159: System.IO.UnmanagedMemoryStream.dll => 0x3bb6bd33 => 56
	i32 1012816738, ; 160: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 253
	i32 1019214401, ; 161: System.Drawing => 0x3cbffa41 => 36
	i32 1028951442, ; 162: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 180
	i32 1029334545, ; 163: da/Microsoft.Maui.Controls.resources.dll => 0x3d5a6611 => 308
	i32 1031528504, ; 164: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 287
	i32 1035644815, ; 165: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 201
	i32 1036359102, ; 166: Xamarin.GooglePlayServices.CloudMessaging.dll => 0x3dc595be => 291
	i32 1036536393, ; 167: System.Drawing.Primitives.dll => 0x3dc84a49 => 35
	i32 1044663988, ; 168: System.Linq.Expressions.dll => 0x3e444eb4 => 58
	i32 1052210849, ; 169: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 239
	i32 1067306892, ; 170: GoogleGson => 0x3f9dcf8c => 176
	i32 1082857460, ; 171: System.ComponentModel.TypeConverter => 0x408b17f4 => 17
	i32 1084122840, ; 172: Xamarin.Kotlin.StdLib => 0x409e66d8 => 296
	i32 1098259244, ; 173: System => 0x41761b2c => 164
	i32 1121599056, ; 174: Xamarin.AndroidX.Lifecycle.Runtime.Ktx.dll => 0x42da3e50 => 237
	i32 1127624469, ; 175: Microsoft.Extensions.Logging.Debug => 0x43362f15 => 183
	i32 1141947663, ; 176: Xamarin.Firebase.Measurement.Connector.dll => 0x4410bd0f => 279
	i32 1149092582, ; 177: Xamarin.AndroidX.Window => 0x447dc2e6 => 266
	i32 1170634674, ; 178: System.Web.dll => 0x45c677b2 => 153
	i32 1175144683, ; 179: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 262
	i32 1178241025, ; 180: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 247
	i32 1178797549, ; 181: fi/Microsoft.Maui.Controls.resources => 0x464305ed => 312
	i32 1203215381, ; 182: pl/Microsoft.Maui.Controls.resources.dll => 0x47b79c15 => 325
	i32 1204270330, ; 183: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 203
	i32 1208641965, ; 184: System.Diagnostics.Process => 0x480a69ad => 29
	i32 1214827643, ; 185: CommunityToolkit.Mvvm => 0x4868cc7b => 175
	i32 1219128291, ; 186: System.IO.IsolatedStorage => 0x48aa6be3 => 52
	i32 1234928153, ; 187: nb/Microsoft.Maui.Controls.resources.dll => 0x499b8219 => 323
	i32 1243150071, ; 188: Xamarin.AndroidX.Window.Extensions.Core.Core.dll => 0x4a18f6f7 => 267
	i32 1246548578, ; 189: Xamarin.AndroidX.Collection.Jvm.dll => 0x4a4cd262 => 208
	i32 1253011324, ; 190: Microsoft.Win32.Registry => 0x4aaf6f7c => 5
	i32 1264511973, ; 191: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 257
	i32 1264890200, ; 192: Xamarin.KotlinX.Coroutines.Core.dll => 0x4b64b158 => 302
	i32 1267360935, ; 193: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 261
	i32 1273260888, ; 194: Xamarin.AndroidX.Collection.Ktx => 0x4be46b58 => 209
	i32 1275534314, ; 195: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 301
	i32 1278448581, ; 196: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 200
	i32 1293217323, ; 197: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 220
	i32 1309188875, ; 198: System.Private.DataContractSerialization => 0x4e08a30b => 85
	i32 1322716291, ; 199: Xamarin.AndroidX.Window.dll => 0x4ed70c83 => 266
	i32 1324164729, ; 200: System.Linq => 0x4eed2679 => 61
	i32 1333047053, ; 201: Xamarin.Firebase.Common => 0x4f74af0d => 269
	i32 1335329327, ; 202: System.Runtime.Serialization.Json.dll => 0x4f97822f => 112
	i32 1364015309, ; 203: System.IO => 0x514d38cd => 57
	i32 1376866003, ; 204: Xamarin.AndroidX.SavedState => 0x52114ed3 => 253
	i32 1379779777, ; 205: System.Resources.ResourceManager => 0x523dc4c1 => 99
	i32 1379897097, ; 206: Xamarin.JavaX.Inject => 0x523f8f09 => 294
	i32 1402170036, ; 207: System.Configuration.dll => 0x53936ab4 => 19
	i32 1406073936, ; 208: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 213
	i32 1408764838, ; 209: System.Runtime.Serialization.Formatters.dll => 0x53f80ba6 => 111
	i32 1411638395, ; 210: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 101
	i32 1422545099, ; 211: System.Runtime.CompilerServices.VisualC => 0x54ca50cb => 102
	i32 1434145427, ; 212: System.Runtime.Handles => 0x557b5293 => 104
	i32 1435222561, ; 213: Xamarin.Google.Crypto.Tink.Android.dll => 0x558bc221 => 286
	i32 1437299793, ; 214: Xamarin.AndroidX.Lifecycle.Common.Jvm => 0x55ab7451 => 230
	i32 1439761251, ; 215: System.Net.Quic.dll => 0x55d10363 => 71
	i32 1441095154, ; 216: Xamarin.AndroidX.Lifecycle.ViewModel.Android => 0x55e55df2 => 240
	i32 1452070440, ; 217: System.Formats.Asn1.dll => 0x568cd628 => 38
	i32 1453312822, ; 218: System.Diagnostics.Tools.dll => 0x569fcb36 => 32
	i32 1457743152, ; 219: System.Runtime.Extensions.dll => 0x56e36530 => 103
	i32 1458022317, ; 220: System.Net.Security.dll => 0x56e7a7ad => 73
	i32 1461234159, ; 221: System.Collections.Immutable.dll => 0x5718a9ef => 9
	i32 1461719063, ; 222: System.Security.Cryptography.OpenSsl => 0x57201017 => 123
	i32 1462112819, ; 223: System.IO.Compression.dll => 0x57261233 => 46
	i32 1469204771, ; 224: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 202
	i32 1470490898, ; 225: Microsoft.Extensions.Primitives => 0x57a5e912 => 185
	i32 1479771757, ; 226: System.Collections.Immutable => 0x5833866d => 9
	i32 1480492111, ; 227: System.IO.Compression.Brotli.dll => 0x583e844f => 43
	i32 1487239319, ; 228: Microsoft.Win32.Primitives => 0x58a57897 => 4
	i32 1490025113, ; 229: Xamarin.AndroidX.SavedState.SavedState.Ktx.dll => 0x58cffa99 => 254
	i32 1493001747, ; 230: hi/Microsoft.Maui.Controls.resources.dll => 0x58fd6613 => 315
	i32 1514721132, ; 231: el/Microsoft.Maui.Controls.resources.dll => 0x5a48cf6c => 310
	i32 1531040989, ; 232: Xamarin.Firebase.Iid.Interop.dll => 0x5b41d4dd => 276
	i32 1536373174, ; 233: System.Diagnostics.TextWriterTraceListener => 0x5b9331b6 => 31
	i32 1543031311, ; 234: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 138
	i32 1543355203, ; 235: System.Reflection.Emit.dll => 0x5bfdbb43 => 92
	i32 1550322496, ; 236: System.Reflection.Extensions.dll => 0x5c680b40 => 93
	i32 1551623176, ; 237: sk/Microsoft.Maui.Controls.resources.dll => 0x5c7be408 => 330
	i32 1554762148, ; 238: fr/Microsoft.Maui.Controls.resources => 0x5cabc9a4 => 313
	i32 1565862583, ; 239: System.IO.FileSystem.Primitives => 0x5d552ab7 => 49
	i32 1566207040, ; 240: System.Threading.Tasks.Dataflow.dll => 0x5d5a6c40 => 141
	i32 1573704789, ; 241: System.Runtime.Serialization.Json => 0x5dccd455 => 112
	i32 1580037396, ; 242: System.Threading.Overlapped => 0x5e2d7514 => 140
	i32 1580413037, ; 243: sv/Microsoft.Maui.Controls.resources => 0x5e33306d => 331
	i32 1582372066, ; 244: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 219
	i32 1591080825, ; 245: zh-Hant/Microsoft.Maui.Controls.resources => 0x5ed5f779 => 338
	i32 1592978981, ; 246: System.Runtime.Serialization.dll => 0x5ef2ee25 => 115
	i32 1597949149, ; 247: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 287
	i32 1601112923, ; 248: System.Xml.Serialization => 0x5f6f0b5b => 157
	i32 1604827217, ; 249: System.Net.WebClient => 0x5fa7b851 => 76
	i32 1618516317, ; 250: System.Net.WebSockets.Client.dll => 0x6078995d => 79
	i32 1622152042, ; 251: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 243
	i32 1622358360, ; 252: System.Dynamic.Runtime => 0x60b33958 => 37
	i32 1624863272, ; 253: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 265
	i32 1634654947, ; 254: CommunityToolkit.Maui.Core.dll => 0x616edae3 => 174
	i32 1635184631, ; 255: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 223
	i32 1636350590, ; 256: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 216
	i32 1639515021, ; 257: System.Net.Http.dll => 0x61b9038d => 64
	i32 1639986890, ; 258: System.Text.RegularExpressions => 0x61c036ca => 138
	i32 1641389582, ; 259: System.ComponentModel.EventBasedAsync.dll => 0x61d59e0e => 15
	i32 1657153582, ; 260: System.Runtime => 0x62c6282e => 116
	i32 1658241508, ; 261: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 259
	i32 1658251792, ; 262: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 284
	i32 1670060433, ; 263: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 211
	i32 1675553242, ; 264: System.IO.FileSystem.DriveInfo.dll => 0x63dee9da => 48
	i32 1677501392, ; 265: System.Net.Primitives.dll => 0x63fca3d0 => 70
	i32 1678508291, ; 266: System.Net.WebSockets => 0x640c0103 => 80
	i32 1679769178, ; 267: System.Security.Cryptography => 0x641f3e5a => 126
	i32 1691477237, ; 268: System.Reflection.Metadata => 0x64d1e4f5 => 94
	i32 1696967625, ; 269: System.Security.Cryptography.Csp => 0x6525abc9 => 121
	i32 1701541528, ; 270: System.Diagnostics.Debug.dll => 0x656b7698 => 26
	i32 1718585270, ; 271: MauiDemoApp => 0x666f87b6 => 0
	i32 1720223769, ; 272: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx => 0x66888819 => 233
	i32 1726116996, ; 273: System.Reflection.dll => 0x66e27484 => 97
	i32 1728033016, ; 274: System.Diagnostics.FileVersionInfo.dll => 0x66ffb0f8 => 28
	i32 1729485958, ; 275: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 206
	i32 1736233607, ; 276: ro/Microsoft.Maui.Controls.resources.dll => 0x677cd287 => 328
	i32 1744735666, ; 277: System.Transactions.Local.dll => 0x67fe8db2 => 149
	i32 1746316138, ; 278: Mono.Android.Export => 0x6816ab6a => 169
	i32 1750313021, ; 279: Microsoft.Win32.Primitives.dll => 0x6853a83d => 4
	i32 1758240030, ; 280: System.Resources.Reader.dll => 0x68cc9d1e => 98
	i32 1763938596, ; 281: System.Diagnostics.TraceSource.dll => 0x69239124 => 33
	i32 1765942094, ; 282: System.Reflection.Extensions => 0x6942234e => 93
	i32 1766324549, ; 283: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 258
	i32 1770582343, ; 284: Microsoft.Extensions.Logging.dll => 0x6988f147 => 181
	i32 1776026572, ; 285: System.Core.dll => 0x69dc03cc => 21
	i32 1777075843, ; 286: System.Globalization.Extensions.dll => 0x69ec0683 => 41
	i32 1780572499, ; 287: Mono.Android.Runtime.dll => 0x6a216153 => 170
	i32 1788241197, ; 288: Xamarin.AndroidX.Fragment => 0x6a96652d => 225
	i32 1808609942, ; 289: Xamarin.AndroidX.Loader => 0x6bcd3296 => 243
	i32 1809966115, ; 290: nb/Microsoft.Maui.Controls.resources => 0x6be1e423 => 323
	i32 1813058853, ; 291: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 296
	i32 1813201214, ; 292: Xamarin.Google.Android.Material => 0x6c13413e => 284
	i32 1818569960, ; 293: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 248
	i32 1818787751, ; 294: Microsoft.VisualBasic.Core => 0x6c687fa7 => 2
	i32 1821794637, ; 295: hu/Microsoft.Maui.Controls.resources => 0x6c96614d => 317
	i32 1824175904, ; 296: System.Text.Encoding.Extensions => 0x6cbab720 => 134
	i32 1824722060, ; 297: System.Runtime.Serialization.Formatters => 0x6cc30c8c => 111
	i32 1828688058, ; 298: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 182
	i32 1842015223, ; 299: uk/Microsoft.Maui.Controls.resources.dll => 0x6dcaebf7 => 334
	i32 1847515442, ; 300: Xamarin.Android.Glide.Annotations => 0x6e1ed932 => 193
	i32 1858542181, ; 301: System.Linq.Expressions => 0x6ec71a65 => 58
	i32 1870277092, ; 302: System.Reflection.Primitives => 0x6f7a29e4 => 95
	i32 1876173635, ; 303: Xamarin.Firebase.Encoders.Proto => 0x6fd42343 => 275
	i32 1879696579, ; 304: System.Formats.Tar.dll => 0x7009e4c3 => 39
	i32 1885316902, ; 305: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 204
	i32 1888955245, ; 306: System.Diagnostics.Contracts => 0x70972b6d => 25
	i32 1889954781, ; 307: System.Reflection.Metadata.dll => 0x70a66bdd => 94
	i32 1898237753, ; 308: System.Reflection.DispatchProxy => 0x7124cf39 => 89
	i32 1900610850, ; 309: System.Resources.ResourceManager.dll => 0x71490522 => 99
	i32 1908813208, ; 310: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 290
	i32 1910275211, ; 311: System.Collections.NonGeneric.dll => 0x71dc7c8b => 10
	i32 1933215285, ; 312: Xamarin.Firebase.Messaging.dll => 0x733a8635 => 280
	i32 1939592360, ; 313: System.Private.Xml.Linq => 0x739bd4a8 => 87
	i32 1956758971, ; 314: System.Resources.Writer => 0x74a1c5bb => 100
	i32 1960264639, ; 315: ja/Microsoft.Maui.Controls.resources => 0x74d743bf => 320
	i32 1961813231, ; 316: Xamarin.AndroidX.Security.SecurityCrypto.dll => 0x74eee4ef => 255
	i32 1968388702, ; 317: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 177
	i32 1985761444, ; 318: Xamarin.Android.Glide.GifDecoder => 0x765c50a4 => 195
	i32 2011961780, ; 319: System.Buffers.dll => 0x77ec19b4 => 7
	i32 2014344398, ; 320: hr/Microsoft.Maui.Controls.resources => 0x781074ce => 316
	i32 2019465201, ; 321: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 239
	i32 2025202353, ; 322: ar/Microsoft.Maui.Controls.resources.dll => 0x78b622b1 => 305
	i32 2031763787, ; 323: Xamarin.Android.Glide => 0x791a414b => 192
	i32 2043674646, ; 324: it/Microsoft.Maui.Controls.resources => 0x79d00016 => 319
	i32 2045470958, ; 325: System.Private.Xml => 0x79eb68ee => 88
	i32 2055257422, ; 326: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 232
	i32 2060060697, ; 327: System.Windows.dll => 0x7aca0819 => 154
	i32 2070888862, ; 328: System.Diagnostics.TraceSource => 0x7b6f419e => 33
	i32 2074273287, ; 329: MauiDemoApp.Binding.Android => 0x7ba2e607 => 339
	i32 2079903147, ; 330: System.Runtime.dll => 0x7bf8cdab => 116
	i32 2090596640, ; 331: System.Numerics.Vectors => 0x7c9bf920 => 82
	i32 2124230737, ; 332: Xamarin.Google.Android.DataTransport.TransportBackendCct.dll => 0x7e9d3051 => 282
	i32 2127167465, ; 333: System.Console => 0x7ec9ffe9 => 20
	i32 2129483829, ; 334: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 289
	i32 2142473426, ; 335: System.Collections.Specialized => 0x7fb38cd2 => 11
	i32 2143790110, ; 336: System.Xml.XmlSerializer.dll => 0x7fc7a41e => 162
	i32 2146852085, ; 337: Microsoft.VisualBasic.dll => 0x7ff65cf5 => 3
	i32 2150663486, ; 338: ko/Microsoft.Maui.Controls.resources => 0x8030853e => 321
	i32 2159891885, ; 339: Microsoft.Maui => 0x80bd55ad => 189
	i32 2165051842, ; 340: ro/Microsoft.Maui.Controls.resources => 0x810c11c2 => 328
	i32 2174878672, ; 341: Xamarin.Firebase.Annotations => 0x81a203d0 => 268
	i32 2181898931, ; 342: Microsoft.Extensions.Options.dll => 0x820d22b3 => 184
	i32 2192057212, ; 343: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 182
	i32 2193016926, ; 344: System.ObjectModel.dll => 0x82b6c85e => 84
	i32 2201107256, ; 345: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 303
	i32 2201231467, ; 346: System.Net.Http => 0x8334206b => 64
	i32 2217644978, ; 347: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 262
	i32 2222056684, ; 348: System.Threading.Tasks.Parallel => 0x8471e4ec => 143
	i32 2225853105, ; 349: Xamarin.Firebase.Common.Ktx => 0x84abd2b1 => 270
	i32 2244775296, ; 350: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 244
	i32 2252106437, ; 351: System.Xml.Serialization.dll => 0x863c6ac5 => 157
	i32 2256313426, ; 352: System.Globalization.Extensions => 0x867c9c52 => 41
	i32 2265110946, ; 353: System.Security.AccessControl.dll => 0x8702d9a2 => 117
	i32 2266799131, ; 354: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 178
	i32 2267999099, ; 355: Xamarin.Android.Glide.DiskLruCache.dll => 0x872eeb7b => 194
	i32 2270573516, ; 356: fr/Microsoft.Maui.Controls.resources.dll => 0x875633cc => 313
	i32 2279755925, ; 357: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 251
	i32 2289298199, ; 358: th/Microsoft.Maui.Controls.resources => 0x8873eb17 => 332
	i32 2293034957, ; 359: System.ServiceModel.Web.dll => 0x88acefcd => 131
	i32 2295906218, ; 360: System.Net.Sockets => 0x88d8bfaa => 75
	i32 2298471582, ; 361: System.Net.Mail => 0x88ffe49e => 66
	i32 2305521784, ; 362: System.Private.CoreLib.dll => 0x896b7878 => 172
	i32 2315684594, ; 363: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 198
	i32 2320631194, ; 364: System.Threading.Tasks.Parallel.dll => 0x8a52059a => 143
	i32 2340441535, ; 365: System.Runtime.InteropServices.RuntimeInformation.dll => 0x8b804dbf => 106
	i32 2344264397, ; 366: System.ValueTuple => 0x8bbaa2cd => 151
	i32 2353062107, ; 367: System.Net.Primitives => 0x8c40e0db => 70
	i32 2368005991, ; 368: System.Xml.ReaderWriter.dll => 0x8d24e767 => 156
	i32 2369760409, ; 369: tr/Microsoft.Maui.Controls.resources => 0x8d3fac99 => 333
	i32 2371007202, ; 370: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 177
	i32 2378619854, ; 371: System.Security.Cryptography.Csp.dll => 0x8dc6dbce => 121
	i32 2383496789, ; 372: System.Security.Principal.Windows.dll => 0x8e114655 => 127
	i32 2401565422, ; 373: System.Web.HttpUtility => 0x8f24faee => 152
	i32 2403452196, ; 374: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 222
	i32 2421380589, ; 375: System.Threading.Tasks.Dataflow => 0x905355ed => 141
	i32 2421992093, ; 376: nl/Microsoft.Maui.Controls.resources => 0x905caa9d => 324
	i32 2423080555, ; 377: Xamarin.AndroidX.Collection.Ktx.dll => 0x906d466b => 209
	i32 2435356389, ; 378: System.Console.dll => 0x912896e5 => 20
	i32 2435904999, ; 379: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 14
	i32 2454642406, ; 380: System.Text.Encoding.dll => 0x924edee6 => 135
	i32 2458678730, ; 381: System.Net.Sockets.dll => 0x928c75ca => 75
	i32 2459001652, ; 382: System.Linq.Parallel.dll => 0x92916334 => 59
	i32 2465532216, ; 383: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 212
	i32 2471841756, ; 384: netstandard.dll => 0x93554fdc => 167
	i32 2475788418, ; 385: Java.Interop.dll => 0x93918882 => 168
	i32 2480646305, ; 386: Microsoft.Maui.Controls => 0x93dba8a1 => 187
	i32 2483661569, ; 387: Xamarin.Firebase.Measurement.Connector => 0x9409ab01 => 279
	i32 2483742551, ; 388: Xamarin.Firebase.Messaging => 0x940ae757 => 280
	i32 2483903535, ; 389: System.ComponentModel.EventBasedAsync => 0x940d5c2f => 15
	i32 2484371297, ; 390: System.Net.ServicePoint => 0x94147f61 => 74
	i32 2486410006, ; 391: Xamarin.GooglePlayServices.CloudMessaging => 0x94339b16 => 291
	i32 2490993605, ; 392: System.AppContext.dll => 0x94798bc5 => 6
	i32 2501346920, ; 393: System.Data.DataSetExtensions => 0x95178668 => 23
	i32 2505896520, ; 394: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 235
	i32 2520433370, ; 395: sk/Microsoft.Maui.Controls.resources => 0x963ac2da => 330
	i32 2522472828, ; 396: Xamarin.Android.Glide.dll => 0x9659e17c => 192
	i32 2538310050, ; 397: System.Reflection.Emit.Lightweight.dll => 0x974b89a2 => 91
	i32 2562349572, ; 398: Microsoft.CSharp => 0x98ba5a04 => 1
	i32 2570120770, ; 399: System.Text.Encodings.Web => 0x9930ee42 => 136
	i32 2577256205, ; 400: Xamarin.AndroidX.Lifecycle.Runtime.Ktx.Android => 0x999dcf0d => 238
	i32 2581783588, ; 401: Xamarin.AndroidX.Lifecycle.Runtime.Ktx => 0x99e2e424 => 237
	i32 2581819634, ; 402: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 261
	i32 2585220780, ; 403: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 134
	i32 2585805581, ; 404: System.Net.Ping => 0x9a20430d => 69
	i32 2589602615, ; 405: System.Threading.ThreadPool => 0x9a5a3337 => 146
	i32 2605712449, ; 406: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 303
	i32 2615233544, ; 407: Xamarin.AndroidX.Fragment.Ktx => 0x9be14c08 => 226
	i32 2616218305, ; 408: Microsoft.Extensions.Logging.Debug.dll => 0x9bf052c1 => 183
	i32 2617129537, ; 409: System.Private.Xml.dll => 0x9bfe3a41 => 88
	i32 2618712057, ; 410: System.Reflection.TypeExtensions.dll => 0x9c165ff9 => 96
	i32 2620111890, ; 411: Xamarin.Firebase.Encoders.dll => 0x9c2bbc12 => 273
	i32 2620871830, ; 412: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 216
	i32 2623491480, ; 413: Xamarin.Firebase.Installations.InterOp => 0x9c5f4d98 => 278
	i32 2624644809, ; 414: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 221
	i32 2627185994, ; 415: System.Diagnostics.TextWriterTraceListener.dll => 0x9c97ad4a => 31
	i32 2629843544, ; 416: System.IO.Compression.ZipFile.dll => 0x9cc03a58 => 45
	i32 2633051222, ; 417: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 231
	i32 2639764100, ; 418: Xamarin.Firebase.Encoders => 0x9d579a84 => 273
	i32 2663391936, ; 419: Xamarin.Android.Glide.DiskLruCache => 0x9ec022c0 => 194
	i32 2663698177, ; 420: System.Runtime.Loader => 0x9ec4cf01 => 109
	i32 2664396074, ; 421: System.Xml.XDocument.dll => 0x9ecf752a => 158
	i32 2665622720, ; 422: System.Drawing.Primitives => 0x9ee22cc0 => 35
	i32 2671474046, ; 423: Xamarin.KotlinX.Coroutines.Core => 0x9f3b757e => 302
	i32 2676780864, ; 424: System.Data.Common.dll => 0x9f8c6f40 => 22
	i32 2686887180, ; 425: System.Runtime.Serialization.Xml.dll => 0xa026a50c => 114
	i32 2693849962, ; 426: System.IO.dll => 0xa090e36a => 57
	i32 2701096212, ; 427: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 259
	i32 2715334215, ; 428: System.Threading.Tasks.dll => 0xa1d8b647 => 144
	i32 2717744543, ; 429: System.Security.Claims => 0xa1fd7d9f => 118
	i32 2719963679, ; 430: System.Security.Cryptography.Cng.dll => 0xa21f5a1f => 120
	i32 2724373263, ; 431: System.Runtime.Numerics.dll => 0xa262a30f => 110
	i32 2732626843, ; 432: Xamarin.AndroidX.Activity => 0xa2e0939b => 196
	i32 2735172069, ; 433: System.Threading.Channels => 0xa30769e5 => 139
	i32 2737747696, ; 434: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 202
	i32 2740948882, ; 435: System.IO.Pipes.AccessControl => 0xa35f8f92 => 54
	i32 2748088231, ; 436: System.Runtime.InteropServices.JavaScript => 0xa3cc7fa7 => 105
	i32 2758225723, ; 437: Microsoft.Maui.Controls.Xaml => 0xa4672f3b => 188
	i32 2764765095, ; 438: Microsoft.Maui.dll => 0xa4caf7a7 => 189
	i32 2765824710, ; 439: System.Text.Encoding.CodePages.dll => 0xa4db22c6 => 133
	i32 2766642685, ; 440: Xamarin.AndroidX.Lifecycle.ViewModel.Android.dll => 0xa4e79dfd => 240
	i32 2770495804, ; 441: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 295
	i32 2778768386, ; 442: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 264
	i32 2779977773, ; 443: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 252
	i32 2780199943, ; 444: Xamarin.AndroidX.Lifecycle.Common.Jvm.dll => 0xa5b67c07 => 230
	i32 2788224221, ; 445: Xamarin.AndroidX.Fragment.Ktx.dll => 0xa630ecdd => 226
	i32 2801831435, ; 446: Microsoft.Maui.Graphics => 0xa7008e0b => 191
	i32 2802068195, ; 447: uk/Microsoft.Maui.Controls.resources => 0xa7042ae3 => 334
	i32 2803228030, ; 448: System.Xml.XPath.XDocument.dll => 0xa715dd7e => 159
	i32 2804607052, ; 449: Xamarin.Firebase.Components.dll => 0xa72ae84c => 271
	i32 2806116107, ; 450: es/Microsoft.Maui.Controls.resources.dll => 0xa741ef0b => 311
	i32 2810250172, ; 451: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 213
	i32 2819470561, ; 452: System.Xml.dll => 0xa80db4e1 => 163
	i32 2821205001, ; 453: System.ServiceProcess.dll => 0xa8282c09 => 132
	i32 2821294376, ; 454: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 252
	i32 2824502124, ; 455: System.Xml.XmlDocument => 0xa85a7b6c => 161
	i32 2831556043, ; 456: nl/Microsoft.Maui.Controls.resources.dll => 0xa8c61dcb => 324
	i32 2838993487, ; 457: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx.dll => 0xa9379a4f => 241
	i32 2847418871, ; 458: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 289
	i32 2849599387, ; 459: System.Threading.Overlapped.dll => 0xa9d96f9b => 140
	i32 2853208004, ; 460: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 264
	i32 2855708567, ; 461: Xamarin.AndroidX.Transition => 0xaa36a797 => 260
	i32 2857259519, ; 462: el/Microsoft.Maui.Controls.resources => 0xaa4e51ff => 310
	i32 2861098320, ; 463: Mono.Android.Export.dll => 0xaa88e550 => 169
	i32 2861189240, ; 464: Microsoft.Maui.Essentials => 0xaa8a4878 => 190
	i32 2868488919, ; 465: CommunityToolkit.Maui.Core => 0xaaf9aad7 => 174
	i32 2870099610, ; 466: Xamarin.AndroidX.Activity.Ktx.dll => 0xab123e9a => 197
	i32 2875164099, ; 467: Jsr305Binding.dll => 0xab5f85c3 => 285
	i32 2875220617, ; 468: System.Globalization.Calendars.dll => 0xab606289 => 40
	i32 2883495834, ; 469: ru/Microsoft.Maui.Controls.resources => 0xabdea79a => 329
	i32 2883826422, ; 470: Xamarin.Firebase.Installations => 0xabe3b2f6 => 277
	i32 2884993177, ; 471: Xamarin.AndroidX.ExifInterface => 0xabf58099 => 224
	i32 2887636118, ; 472: System.Net.dll => 0xac1dd496 => 81
	i32 2899753641, ; 473: System.IO.UnmanagedMemoryStream => 0xacd6baa9 => 56
	i32 2900621748, ; 474: System.Dynamic.Runtime.dll => 0xace3f9b4 => 37
	i32 2901442782, ; 475: System.Reflection => 0xacf080de => 97
	i32 2905242038, ; 476: mscorlib.dll => 0xad2a79b6 => 166
	i32 2909740682, ; 477: System.Private.CoreLib => 0xad6f1e8a => 172
	i32 2914202368, ; 478: Xamarin.Firebase.Iid.Interop => 0xadb33300 => 276
	i32 2916838712, ; 479: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 265
	i32 2919462931, ; 480: System.Numerics.Vectors.dll => 0xae037813 => 82
	i32 2921128767, ; 481: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 199
	i32 2936416060, ; 482: System.Resources.Reader => 0xaf06273c => 98
	i32 2940926066, ; 483: System.Diagnostics.StackTrace.dll => 0xaf4af872 => 30
	i32 2942453041, ; 484: System.Xml.XPath.XDocument => 0xaf624531 => 159
	i32 2959614098, ; 485: System.ComponentModel.dll => 0xb0682092 => 18
	i32 2968338931, ; 486: System.Security.Principal.Windows => 0xb0ed41f3 => 127
	i32 2972252294, ; 487: System.Security.Cryptography.Algorithms.dll => 0xb128f886 => 119
	i32 2978675010, ; 488: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 220
	i32 2987532451, ; 489: Xamarin.AndroidX.Security.SecurityCrypto => 0xb21220a3 => 255
	i32 2996846495, ; 490: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 234
	i32 3016983068, ; 491: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 257
	i32 3023353419, ; 492: WindowsBase.dll => 0xb434b64b => 165
	i32 3024354802, ; 493: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 228
	i32 3038032645, ; 494: _Microsoft.Android.Resource.Designer.dll => 0xb514b305 => 340
	i32 3056245963, ; 495: Xamarin.AndroidX.SavedState.SavedState.Ktx => 0xb62a9ccb => 254
	i32 3057625584, ; 496: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 245
	i32 3058099980, ; 497: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 293
	i32 3059408633, ; 498: Mono.Android.Runtime => 0xb65adef9 => 170
	i32 3059793426, ; 499: System.ComponentModel.Primitives => 0xb660be12 => 16
	i32 3071899978, ; 500: Xamarin.Firebase.Common.dll => 0xb719794a => 269
	i32 3075834255, ; 501: System.Threading.Tasks => 0xb755818f => 144
	i32 3077302341, ; 502: hu/Microsoft.Maui.Controls.resources.dll => 0xb76be845 => 317
	i32 3090735792, ; 503: System.Security.Cryptography.X509Certificates.dll => 0xb838e2b0 => 125
	i32 3099732863, ; 504: System.Security.Claims.dll => 0xb8c22b7f => 118
	i32 3103600923, ; 505: System.Formats.Asn1 => 0xb8fd311b => 38
	i32 3106737866, ; 506: Xamarin.Firebase.Datatransport.dll => 0xb92d0eca => 272
	i32 3111772706, ; 507: System.Runtime.Serialization => 0xb979e222 => 115
	i32 3113438731, ; 508: MauiDemoApp.Binding.Android.dll => 0xb9934e0b => 339
	i32 3121463068, ; 509: System.IO.FileSystem.AccessControl.dll => 0xba0dbf1c => 47
	i32 3124832203, ; 510: System.Threading.Tasks.Extensions => 0xba4127cb => 142
	i32 3132293585, ; 511: System.Security.AccessControl => 0xbab301d1 => 117
	i32 3147165239, ; 512: System.Diagnostics.Tracing.dll => 0xbb95ee37 => 34
	i32 3148237826, ; 513: GoogleGson.dll => 0xbba64c02 => 176
	i32 3150271759, ; 514: Xamarin.KotlinX.Coroutines.Play.Services.dll => 0xbbc5550f => 304
	i32 3155362983, ; 515: Xamarin.Google.Android.DataTransport.TransportApi => 0xbc1304a7 => 281
	i32 3159123045, ; 516: System.Reflection.Primitives.dll => 0xbc4c6465 => 95
	i32 3160747431, ; 517: System.IO.MemoryMappedFiles => 0xbc652da7 => 53
	i32 3178803400, ; 518: Xamarin.AndroidX.Navigation.Fragment.dll => 0xbd78b0c8 => 246
	i32 3192346100, ; 519: System.Security.SecureString => 0xbe4755f4 => 129
	i32 3193515020, ; 520: System.Web => 0xbe592c0c => 153
	i32 3204380047, ; 521: System.Data.dll => 0xbefef58f => 24
	i32 3209718065, ; 522: System.Xml.XmlDocument.dll => 0xbf506931 => 161
	i32 3211777861, ; 523: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 219
	i32 3220365878, ; 524: System.Threading => 0xbff2e236 => 148
	i32 3226221578, ; 525: System.Runtime.Handles.dll => 0xc04c3c0a => 104
	i32 3230466174, ; 526: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 290
	i32 3251039220, ; 527: System.Reflection.DispatchProxy.dll => 0xc1c6ebf4 => 89
	i32 3258312781, ; 528: Xamarin.AndroidX.CardView => 0xc235e84d => 206
	i32 3265493905, ; 529: System.Linq.Queryable.dll => 0xc2a37b91 => 60
	i32 3265893370, ; 530: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 142
	i32 3277815716, ; 531: System.Resources.Writer.dll => 0xc35f7fa4 => 100
	i32 3279906254, ; 532: Microsoft.Win32.Registry.dll => 0xc37f65ce => 5
	i32 3280506390, ; 533: System.ComponentModel.Annotations.dll => 0xc3888e16 => 13
	i32 3290767353, ; 534: System.Security.Cryptography.Encoding => 0xc4251ff9 => 122
	i32 3299363146, ; 535: System.Text.Encoding => 0xc4a8494a => 135
	i32 3303498502, ; 536: System.Diagnostics.FileVersionInfo => 0xc4e76306 => 28
	i32 3316684772, ; 537: System.Net.Requests.dll => 0xc5b097e4 => 72
	i32 3317135071, ; 538: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 217
	i32 3317144872, ; 539: System.Data => 0xc5b79d28 => 24
	i32 3331531814, ; 540: Xamarin.GooglePlayServices.Stats.dll => 0xc6932426 => 292
	i32 3340431453, ; 541: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 204
	i32 3345895724, ; 542: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 250
	i32 3346324047, ; 543: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 247
	i32 3358260929, ; 544: System.Text.Json => 0xc82afec1 => 137
	i32 3362336904, ; 545: Xamarin.AndroidX.Activity.Ktx => 0xc8693088 => 197
	i32 3362522851, ; 546: Xamarin.AndroidX.Core => 0xc86c06e3 => 214
	i32 3366347497, ; 547: Java.Interop => 0xc8a662e9 => 168
	i32 3371992681, ; 548: Xamarin.Firebase.Encoders.Proto.dll => 0xc8fc8669 => 275
	i32 3374999561, ; 549: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 251
	i32 3383578424, ; 550: Xamarin.Firebase.Encoders.JSON => 0xc9ad4f38 => 274
	i32 3395150330, ; 551: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 101
	i32 3403906625, ; 552: System.Security.Cryptography.OpenSsl.dll => 0xcae37e41 => 123
	i32 3405233483, ; 553: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 218
	i32 3428513518, ; 554: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 179
	i32 3429136800, ; 555: System.Xml => 0xcc6479a0 => 163
	i32 3430777524, ; 556: netstandard => 0xcc7d82b4 => 167
	i32 3441283291, ; 557: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 221
	i32 3445260447, ; 558: System.Formats.Tar => 0xcd5a809f => 39
	i32 3452344032, ; 559: Microsoft.Maui.Controls.Compatibility.dll => 0xcdc696e0 => 186
	i32 3463511458, ; 560: hr/Microsoft.Maui.Controls.resources.dll => 0xce70fda2 => 316
	i32 3471940407, ; 561: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 17
	i32 3476120550, ; 562: Mono.Android => 0xcf3163e6 => 171
	i32 3479583265, ; 563: ru/Microsoft.Maui.Controls.resources.dll => 0xcf663a21 => 329
	i32 3485117614, ; 564: System.Text.Json.dll => 0xcfbaacae => 137
	i32 3486566296, ; 565: System.Transactions => 0xcfd0c798 => 150
	i32 3493954962, ; 566: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 210
	i32 3509114376, ; 567: System.Xml.Linq => 0xd128d608 => 155
	i32 3515174580, ; 568: System.Security.dll => 0xd1854eb4 => 130
	i32 3530912306, ; 569: System.Configuration => 0xd2757232 => 19
	i32 3539954161, ; 570: System.Net.HttpListener => 0xd2ff69f1 => 65
	i32 3542658132, ; 571: vi/Microsoft.Maui.Controls.resources => 0xd328ac54 => 335
	i32 3560100363, ; 572: System.Threading.Timer => 0xd432d20b => 147
	i32 3570554715, ; 573: System.IO.FileSystem.AccessControl => 0xd4d2575b => 47
	i32 3596930546, ; 574: de/Microsoft.Maui.Controls.resources => 0xd664cdf2 => 309
	i32 3597029428, ; 575: Xamarin.Android.Glide.GifDecoder.dll => 0xd6665034 => 195
	i32 3598340787, ; 576: System.Net.WebSockets.Client => 0xd67a52b3 => 79
	i32 3608519521, ; 577: System.Linq.dll => 0xd715a361 => 61
	i32 3623444314, ; 578: da/Microsoft.Maui.Controls.resources => 0xd7f95f5a => 308
	i32 3624195450, ; 579: System.Runtime.InteropServices.RuntimeInformation => 0xd804d57a => 106
	i32 3627220390, ; 580: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 249
	i32 3633644679, ; 581: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 199
	i32 3638274909, ; 582: System.IO.FileSystem.Primitives.dll => 0xd8dbab5d => 49
	i32 3641597786, ; 583: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 232
	i32 3643854240, ; 584: Xamarin.AndroidX.Navigation.Fragment => 0xd930cda0 => 246
	i32 3645089577, ; 585: System.ComponentModel.DataAnnotations => 0xd943a729 => 14
	i32 3647796983, ; 586: pt-BR/Microsoft.Maui.Controls.resources => 0xd96cf6f7 => 326
	i32 3657292374, ; 587: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 178
	i32 3660523487, ; 588: System.Net.NetworkInformation => 0xda2f27df => 68
	i32 3662115805, ; 589: he/Microsoft.Maui.Controls.resources => 0xda4773dd => 314
	i32 3672681054, ; 590: Mono.Android.dll => 0xdae8aa5e => 171
	i32 3682565725, ; 591: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 205
	i32 3684561358, ; 592: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 210
	i32 3686075795, ; 593: ms/Microsoft.Maui.Controls.resources => 0xdbb50d93 => 322
	i32 3697841164, ; 594: zh-Hant/Microsoft.Maui.Controls.resources.dll => 0xdc68940c => 338
	i32 3700866549, ; 595: System.Net.WebProxy.dll => 0xdc96bdf5 => 78
	i32 3706696989, ; 596: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 215
	i32 3716563718, ; 597: System.Runtime.Intrinsics => 0xdd864306 => 108
	i32 3718780102, ; 598: Xamarin.AndroidX.Annotation => 0xdda814c6 => 198
	i32 3724971120, ; 599: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 245
	i32 3732100267, ; 600: System.Net.NameResolution => 0xde7354ab => 67
	i32 3737834244, ; 601: System.Net.Http.Json.dll => 0xdecad304 => 63
	i32 3748608112, ; 602: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 27
	i32 3751444290, ; 603: System.Xml.XPath => 0xdf9a7f42 => 160
	i32 3764085317, ; 604: Xamarin.AndroidX.Lifecycle.Runtime.Ktx.Android.dll => 0xe05b6245 => 238
	i32 3786282454, ; 605: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 207
	i32 3792276235, ; 606: System.Collections.NonGeneric => 0xe2098b0b => 10
	i32 3800979733, ; 607: Microsoft.Maui.Controls.Compatibility => 0xe28e5915 => 186
	i32 3802395368, ; 608: System.Collections.Specialized.dll => 0xe2a3f2e8 => 11
	i32 3817368567, ; 609: CommunityToolkit.Maui.dll => 0xe3886bf7 => 173
	i32 3819260425, ; 610: System.Net.WebProxy => 0xe3a54a09 => 78
	i32 3823082795, ; 611: System.Security.Cryptography.dll => 0xe3df9d2b => 126
	i32 3829621856, ; 612: System.Numerics.dll => 0xe4436460 => 83
	i32 3841636137, ; 613: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 180
	i32 3844307129, ; 614: System.Net.Mail.dll => 0xe52378b9 => 66
	i32 3849253459, ; 615: System.Runtime.InteropServices.dll => 0xe56ef253 => 107
	i32 3870376305, ; 616: System.Net.HttpListener.dll => 0xe6b14171 => 65
	i32 3873536506, ; 617: System.Security.Principal => 0xe6e179fa => 128
	i32 3875112723, ; 618: System.Security.Cryptography.Encoding.dll => 0xe6f98713 => 122
	i32 3885497537, ; 619: System.Net.WebHeaderCollection.dll => 0xe797fcc1 => 77
	i32 3885922214, ; 620: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 260
	i32 3888767677, ; 621: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 250
	i32 3889960447, ; 622: zh-Hans/Microsoft.Maui.Controls.resources.dll => 0xe7dc15ff => 337
	i32 3896106733, ; 623: System.Collections.Concurrent.dll => 0xe839deed => 8
	i32 3896760992, ; 624: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 214
	i32 3901907137, ; 625: Microsoft.VisualBasic.Core.dll => 0xe89260c1 => 2
	i32 3910130544, ; 626: Xamarin.AndroidX.Collection.Jvm => 0xe90fdb70 => 208
	i32 3920810846, ; 627: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 44
	i32 3921031405, ; 628: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 263
	i32 3928044579, ; 629: System.Xml.ReaderWriter => 0xea213423 => 156
	i32 3930554604, ; 630: System.Security.Principal.dll => 0xea4780ec => 128
	i32 3931092270, ; 631: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 248
	i32 3934056515, ; 632: Xamarin.JavaX.Inject.dll => 0xea7cf043 => 294
	i32 3945713374, ; 633: System.Data.DataSetExtensions.dll => 0xeb2ecede => 23
	i32 3953953790, ; 634: System.Text.Encoding.CodePages => 0xebac8bfe => 133
	i32 3955647286, ; 635: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 201
	i32 3959773229, ; 636: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 234
	i32 3970018735, ; 637: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 293
	i32 3980434154, ; 638: th/Microsoft.Maui.Controls.resources.dll => 0xed409aea => 332
	i32 3987592930, ; 639: he/Microsoft.Maui.Controls.resources.dll => 0xedadd6e2 => 314
	i32 4003436829, ; 640: System.Diagnostics.Process.dll => 0xee9f991d => 29
	i32 4015948917, ; 641: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 200
	i32 4025784931, ; 642: System.Memory => 0xeff49a63 => 62
	i32 4046471985, ; 643: Microsoft.Maui.Controls.Xaml.dll => 0xf1304331 => 188
	i32 4054681211, ; 644: System.Reflection.Emit.ILGeneration => 0xf1ad867b => 90
	i32 4068434129, ; 645: System.Private.Xml.Linq.dll => 0xf27f60d1 => 87
	i32 4070331268, ; 646: id/Microsoft.Maui.Controls.resources => 0xf29c5384 => 318
	i32 4073602200, ; 647: System.Threading.dll => 0xf2ce3c98 => 148
	i32 4094352644, ; 648: Microsoft.Maui.Essentials.dll => 0xf40add04 => 190
	i32 4099507663, ; 649: System.Drawing.dll => 0xf45985cf => 36
	i32 4100113165, ; 650: System.Private.Uri => 0xf462c30d => 86
	i32 4101593132, ; 651: Xamarin.AndroidX.Emoji2 => 0xf479582c => 222
	i32 4102112229, ; 652: pt/Microsoft.Maui.Controls.resources.dll => 0xf48143e5 => 327
	i32 4119206479, ; 653: pl/Microsoft.Maui.Controls.resources => 0xf5861a4f => 325
	i32 4125707920, ; 654: ms/Microsoft.Maui.Controls.resources.dll => 0xf5e94e90 => 322
	i32 4126470640, ; 655: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 179
	i32 4127667938, ; 656: System.IO.FileSystem.Watcher => 0xf60736e2 => 50
	i32 4130442656, ; 657: System.AppContext => 0xf6318da0 => 6
	i32 4147896353, ; 658: System.Reflection.Emit.ILGeneration.dll => 0xf73be021 => 90
	i32 4151237749, ; 659: System.Core => 0xf76edc75 => 21
	i32 4157403133, ; 660: Xamarin.Firebase.Common.Ktx.dll => 0xf7cceffd => 270
	i32 4159265925, ; 661: System.Xml.XmlSerializer => 0xf7e95c85 => 162
	i32 4161255271, ; 662: System.Reflection.TypeExtensions => 0xf807b767 => 96
	i32 4164802419, ; 663: System.IO.FileSystem.Watcher.dll => 0xf83dd773 => 50
	i32 4181436372, ; 664: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 113
	i32 4182413190, ; 665: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 242
	i32 4185676441, ; 666: System.Security => 0xf97c5a99 => 130
	i32 4192648326, ; 667: Xamarin.Firebase.Encoders.JSON.dll => 0xf9e6bc86 => 274
	i32 4196529839, ; 668: System.Net.WebClient.dll => 0xfa21f6af => 76
	i32 4213026141, ; 669: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 27
	i32 4228543782, ; 670: Xamarin.KotlinX.AtomicFU.Jvm.dll => 0xfc0a7526 => 300
	i32 4234116406, ; 671: pt/Microsoft.Maui.Controls.resources => 0xfc5f7d36 => 327
	i32 4256097574, ; 672: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 215
	i32 4258378803, ; 673: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx => 0xfdd1b433 => 241
	i32 4260525087, ; 674: System.Buffers => 0xfdf2741f => 7
	i32 4269159614, ; 675: Xamarin.Firebase.Datatransport => 0xfe7634be => 272
	i32 4271975918, ; 676: Microsoft.Maui.Controls.dll => 0xfea12dee => 187
	i32 4274623895, ; 677: CommunityToolkit.Mvvm.dll => 0xfec99597 => 175
	i32 4274976490, ; 678: System.Runtime.Numerics => 0xfecef6ea => 110
	i32 4284549794, ; 679: Xamarin.Firebase.Components => 0xff610aa2 => 271
	i32 4292120959, ; 680: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 242
	i32 4294763496 ; 681: Xamarin.AndroidX.ExifInterface.dll => 0xfffce3e8 => 224
], align 4

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [682 x i32] [
	i32 68, ; 0
	i32 67, ; 1
	i32 108, ; 2
	i32 235, ; 3
	i32 288, ; 4
	i32 48, ; 5
	i32 80, ; 6
	i32 145, ; 7
	i32 300, ; 8
	i32 306, ; 9
	i32 304, ; 10
	i32 30, ; 11
	i32 124, ; 12
	i32 191, ; 13
	i32 102, ; 14
	i32 256, ; 15
	i32 268, ; 16
	i32 336, ; 17
	i32 107, ; 18
	i32 256, ; 19
	i32 139, ; 20
	i32 297, ; 21
	i32 77, ; 22
	i32 124, ; 23
	i32 13, ; 24
	i32 207, ; 25
	i32 299, ; 26
	i32 132, ; 27
	i32 258, ; 28
	i32 151, ; 29
	i32 335, ; 30
	i32 336, ; 31
	i32 18, ; 32
	i32 205, ; 33
	i32 26, ; 34
	i32 228, ; 35
	i32 1, ; 36
	i32 59, ; 37
	i32 42, ; 38
	i32 91, ; 39
	i32 211, ; 40
	i32 147, ; 41
	i32 231, ; 42
	i32 227, ; 43
	i32 307, ; 44
	i32 54, ; 45
	i32 69, ; 46
	i32 196, ; 47
	i32 83, ; 48
	i32 320, ; 49
	i32 229, ; 50
	i32 319, ; 51
	i32 307, ; 52
	i32 131, ; 53
	i32 55, ; 54
	i32 149, ; 55
	i32 74, ; 56
	i32 145, ; 57
	i32 62, ; 58
	i32 146, ; 59
	i32 340, ; 60
	i32 165, ; 61
	i32 236, ; 62
	i32 331, ; 63
	i32 212, ; 64
	i32 12, ; 65
	i32 225, ; 66
	i32 125, ; 67
	i32 152, ; 68
	i32 113, ; 69
	i32 166, ; 70
	i32 164, ; 71
	i32 227, ; 72
	i32 283, ; 73
	i32 244, ; 74
	i32 283, ; 75
	i32 84, ; 76
	i32 318, ; 77
	i32 312, ; 78
	i32 281, ; 79
	i32 185, ; 80
	i32 150, ; 81
	i32 315, ; 82
	i32 297, ; 83
	i32 60, ; 84
	i32 181, ; 85
	i32 51, ; 86
	i32 292, ; 87
	i32 103, ; 88
	i32 114, ; 89
	i32 40, ; 90
	i32 285, ; 91
	i32 267, ; 92
	i32 120, ; 93
	i32 326, ; 94
	i32 173, ; 95
	i32 52, ; 96
	i32 44, ; 97
	i32 119, ; 98
	i32 236, ; 99
	i32 217, ; 100
	i32 0, ; 101
	i32 223, ; 102
	i32 81, ; 103
	i32 136, ; 104
	i32 263, ; 105
	i32 203, ; 106
	i32 8, ; 107
	i32 299, ; 108
	i32 73, ; 109
	i32 306, ; 110
	i32 155, ; 111
	i32 301, ; 112
	i32 154, ; 113
	i32 92, ; 114
	i32 295, ; 115
	i32 45, ; 116
	i32 321, ; 117
	i32 309, ; 118
	i32 298, ; 119
	i32 109, ; 120
	i32 129, ; 121
	i32 25, ; 122
	i32 193, ; 123
	i32 72, ; 124
	i32 55, ; 125
	i32 46, ; 126
	i32 184, ; 127
	i32 218, ; 128
	i32 22, ; 129
	i32 233, ; 130
	i32 86, ; 131
	i32 43, ; 132
	i32 160, ; 133
	i32 71, ; 134
	i32 249, ; 135
	i32 277, ; 136
	i32 305, ; 137
	i32 3, ; 138
	i32 42, ; 139
	i32 63, ; 140
	i32 278, ; 141
	i32 16, ; 142
	i32 53, ; 143
	i32 333, ; 144
	i32 288, ; 145
	i32 105, ; 146
	i32 298, ; 147
	i32 286, ; 148
	i32 229, ; 149
	i32 34, ; 150
	i32 158, ; 151
	i32 85, ; 152
	i32 32, ; 153
	i32 12, ; 154
	i32 337, ; 155
	i32 51, ; 156
	i32 311, ; 157
	i32 282, ; 158
	i32 56, ; 159
	i32 253, ; 160
	i32 36, ; 161
	i32 180, ; 162
	i32 308, ; 163
	i32 287, ; 164
	i32 201, ; 165
	i32 291, ; 166
	i32 35, ; 167
	i32 58, ; 168
	i32 239, ; 169
	i32 176, ; 170
	i32 17, ; 171
	i32 296, ; 172
	i32 164, ; 173
	i32 237, ; 174
	i32 183, ; 175
	i32 279, ; 176
	i32 266, ; 177
	i32 153, ; 178
	i32 262, ; 179
	i32 247, ; 180
	i32 312, ; 181
	i32 325, ; 182
	i32 203, ; 183
	i32 29, ; 184
	i32 175, ; 185
	i32 52, ; 186
	i32 323, ; 187
	i32 267, ; 188
	i32 208, ; 189
	i32 5, ; 190
	i32 257, ; 191
	i32 302, ; 192
	i32 261, ; 193
	i32 209, ; 194
	i32 301, ; 195
	i32 200, ; 196
	i32 220, ; 197
	i32 85, ; 198
	i32 266, ; 199
	i32 61, ; 200
	i32 269, ; 201
	i32 112, ; 202
	i32 57, ; 203
	i32 253, ; 204
	i32 99, ; 205
	i32 294, ; 206
	i32 19, ; 207
	i32 213, ; 208
	i32 111, ; 209
	i32 101, ; 210
	i32 102, ; 211
	i32 104, ; 212
	i32 286, ; 213
	i32 230, ; 214
	i32 71, ; 215
	i32 240, ; 216
	i32 38, ; 217
	i32 32, ; 218
	i32 103, ; 219
	i32 73, ; 220
	i32 9, ; 221
	i32 123, ; 222
	i32 46, ; 223
	i32 202, ; 224
	i32 185, ; 225
	i32 9, ; 226
	i32 43, ; 227
	i32 4, ; 228
	i32 254, ; 229
	i32 315, ; 230
	i32 310, ; 231
	i32 276, ; 232
	i32 31, ; 233
	i32 138, ; 234
	i32 92, ; 235
	i32 93, ; 236
	i32 330, ; 237
	i32 313, ; 238
	i32 49, ; 239
	i32 141, ; 240
	i32 112, ; 241
	i32 140, ; 242
	i32 331, ; 243
	i32 219, ; 244
	i32 338, ; 245
	i32 115, ; 246
	i32 287, ; 247
	i32 157, ; 248
	i32 76, ; 249
	i32 79, ; 250
	i32 243, ; 251
	i32 37, ; 252
	i32 265, ; 253
	i32 174, ; 254
	i32 223, ; 255
	i32 216, ; 256
	i32 64, ; 257
	i32 138, ; 258
	i32 15, ; 259
	i32 116, ; 260
	i32 259, ; 261
	i32 284, ; 262
	i32 211, ; 263
	i32 48, ; 264
	i32 70, ; 265
	i32 80, ; 266
	i32 126, ; 267
	i32 94, ; 268
	i32 121, ; 269
	i32 26, ; 270
	i32 0, ; 271
	i32 233, ; 272
	i32 97, ; 273
	i32 28, ; 274
	i32 206, ; 275
	i32 328, ; 276
	i32 149, ; 277
	i32 169, ; 278
	i32 4, ; 279
	i32 98, ; 280
	i32 33, ; 281
	i32 93, ; 282
	i32 258, ; 283
	i32 181, ; 284
	i32 21, ; 285
	i32 41, ; 286
	i32 170, ; 287
	i32 225, ; 288
	i32 243, ; 289
	i32 323, ; 290
	i32 296, ; 291
	i32 284, ; 292
	i32 248, ; 293
	i32 2, ; 294
	i32 317, ; 295
	i32 134, ; 296
	i32 111, ; 297
	i32 182, ; 298
	i32 334, ; 299
	i32 193, ; 300
	i32 58, ; 301
	i32 95, ; 302
	i32 275, ; 303
	i32 39, ; 304
	i32 204, ; 305
	i32 25, ; 306
	i32 94, ; 307
	i32 89, ; 308
	i32 99, ; 309
	i32 290, ; 310
	i32 10, ; 311
	i32 280, ; 312
	i32 87, ; 313
	i32 100, ; 314
	i32 320, ; 315
	i32 255, ; 316
	i32 177, ; 317
	i32 195, ; 318
	i32 7, ; 319
	i32 316, ; 320
	i32 239, ; 321
	i32 305, ; 322
	i32 192, ; 323
	i32 319, ; 324
	i32 88, ; 325
	i32 232, ; 326
	i32 154, ; 327
	i32 33, ; 328
	i32 339, ; 329
	i32 116, ; 330
	i32 82, ; 331
	i32 282, ; 332
	i32 20, ; 333
	i32 289, ; 334
	i32 11, ; 335
	i32 162, ; 336
	i32 3, ; 337
	i32 321, ; 338
	i32 189, ; 339
	i32 328, ; 340
	i32 268, ; 341
	i32 184, ; 342
	i32 182, ; 343
	i32 84, ; 344
	i32 303, ; 345
	i32 64, ; 346
	i32 262, ; 347
	i32 143, ; 348
	i32 270, ; 349
	i32 244, ; 350
	i32 157, ; 351
	i32 41, ; 352
	i32 117, ; 353
	i32 178, ; 354
	i32 194, ; 355
	i32 313, ; 356
	i32 251, ; 357
	i32 332, ; 358
	i32 131, ; 359
	i32 75, ; 360
	i32 66, ; 361
	i32 172, ; 362
	i32 198, ; 363
	i32 143, ; 364
	i32 106, ; 365
	i32 151, ; 366
	i32 70, ; 367
	i32 156, ; 368
	i32 333, ; 369
	i32 177, ; 370
	i32 121, ; 371
	i32 127, ; 372
	i32 152, ; 373
	i32 222, ; 374
	i32 141, ; 375
	i32 324, ; 376
	i32 209, ; 377
	i32 20, ; 378
	i32 14, ; 379
	i32 135, ; 380
	i32 75, ; 381
	i32 59, ; 382
	i32 212, ; 383
	i32 167, ; 384
	i32 168, ; 385
	i32 187, ; 386
	i32 279, ; 387
	i32 280, ; 388
	i32 15, ; 389
	i32 74, ; 390
	i32 291, ; 391
	i32 6, ; 392
	i32 23, ; 393
	i32 235, ; 394
	i32 330, ; 395
	i32 192, ; 396
	i32 91, ; 397
	i32 1, ; 398
	i32 136, ; 399
	i32 238, ; 400
	i32 237, ; 401
	i32 261, ; 402
	i32 134, ; 403
	i32 69, ; 404
	i32 146, ; 405
	i32 303, ; 406
	i32 226, ; 407
	i32 183, ; 408
	i32 88, ; 409
	i32 96, ; 410
	i32 273, ; 411
	i32 216, ; 412
	i32 278, ; 413
	i32 221, ; 414
	i32 31, ; 415
	i32 45, ; 416
	i32 231, ; 417
	i32 273, ; 418
	i32 194, ; 419
	i32 109, ; 420
	i32 158, ; 421
	i32 35, ; 422
	i32 302, ; 423
	i32 22, ; 424
	i32 114, ; 425
	i32 57, ; 426
	i32 259, ; 427
	i32 144, ; 428
	i32 118, ; 429
	i32 120, ; 430
	i32 110, ; 431
	i32 196, ; 432
	i32 139, ; 433
	i32 202, ; 434
	i32 54, ; 435
	i32 105, ; 436
	i32 188, ; 437
	i32 189, ; 438
	i32 133, ; 439
	i32 240, ; 440
	i32 295, ; 441
	i32 264, ; 442
	i32 252, ; 443
	i32 230, ; 444
	i32 226, ; 445
	i32 191, ; 446
	i32 334, ; 447
	i32 159, ; 448
	i32 271, ; 449
	i32 311, ; 450
	i32 213, ; 451
	i32 163, ; 452
	i32 132, ; 453
	i32 252, ; 454
	i32 161, ; 455
	i32 324, ; 456
	i32 241, ; 457
	i32 289, ; 458
	i32 140, ; 459
	i32 264, ; 460
	i32 260, ; 461
	i32 310, ; 462
	i32 169, ; 463
	i32 190, ; 464
	i32 174, ; 465
	i32 197, ; 466
	i32 285, ; 467
	i32 40, ; 468
	i32 329, ; 469
	i32 277, ; 470
	i32 224, ; 471
	i32 81, ; 472
	i32 56, ; 473
	i32 37, ; 474
	i32 97, ; 475
	i32 166, ; 476
	i32 172, ; 477
	i32 276, ; 478
	i32 265, ; 479
	i32 82, ; 480
	i32 199, ; 481
	i32 98, ; 482
	i32 30, ; 483
	i32 159, ; 484
	i32 18, ; 485
	i32 127, ; 486
	i32 119, ; 487
	i32 220, ; 488
	i32 255, ; 489
	i32 234, ; 490
	i32 257, ; 491
	i32 165, ; 492
	i32 228, ; 493
	i32 340, ; 494
	i32 254, ; 495
	i32 245, ; 496
	i32 293, ; 497
	i32 170, ; 498
	i32 16, ; 499
	i32 269, ; 500
	i32 144, ; 501
	i32 317, ; 502
	i32 125, ; 503
	i32 118, ; 504
	i32 38, ; 505
	i32 272, ; 506
	i32 115, ; 507
	i32 339, ; 508
	i32 47, ; 509
	i32 142, ; 510
	i32 117, ; 511
	i32 34, ; 512
	i32 176, ; 513
	i32 304, ; 514
	i32 281, ; 515
	i32 95, ; 516
	i32 53, ; 517
	i32 246, ; 518
	i32 129, ; 519
	i32 153, ; 520
	i32 24, ; 521
	i32 161, ; 522
	i32 219, ; 523
	i32 148, ; 524
	i32 104, ; 525
	i32 290, ; 526
	i32 89, ; 527
	i32 206, ; 528
	i32 60, ; 529
	i32 142, ; 530
	i32 100, ; 531
	i32 5, ; 532
	i32 13, ; 533
	i32 122, ; 534
	i32 135, ; 535
	i32 28, ; 536
	i32 72, ; 537
	i32 217, ; 538
	i32 24, ; 539
	i32 292, ; 540
	i32 204, ; 541
	i32 250, ; 542
	i32 247, ; 543
	i32 137, ; 544
	i32 197, ; 545
	i32 214, ; 546
	i32 168, ; 547
	i32 275, ; 548
	i32 251, ; 549
	i32 274, ; 550
	i32 101, ; 551
	i32 123, ; 552
	i32 218, ; 553
	i32 179, ; 554
	i32 163, ; 555
	i32 167, ; 556
	i32 221, ; 557
	i32 39, ; 558
	i32 186, ; 559
	i32 316, ; 560
	i32 17, ; 561
	i32 171, ; 562
	i32 329, ; 563
	i32 137, ; 564
	i32 150, ; 565
	i32 210, ; 566
	i32 155, ; 567
	i32 130, ; 568
	i32 19, ; 569
	i32 65, ; 570
	i32 335, ; 571
	i32 147, ; 572
	i32 47, ; 573
	i32 309, ; 574
	i32 195, ; 575
	i32 79, ; 576
	i32 61, ; 577
	i32 308, ; 578
	i32 106, ; 579
	i32 249, ; 580
	i32 199, ; 581
	i32 49, ; 582
	i32 232, ; 583
	i32 246, ; 584
	i32 14, ; 585
	i32 326, ; 586
	i32 178, ; 587
	i32 68, ; 588
	i32 314, ; 589
	i32 171, ; 590
	i32 205, ; 591
	i32 210, ; 592
	i32 322, ; 593
	i32 338, ; 594
	i32 78, ; 595
	i32 215, ; 596
	i32 108, ; 597
	i32 198, ; 598
	i32 245, ; 599
	i32 67, ; 600
	i32 63, ; 601
	i32 27, ; 602
	i32 160, ; 603
	i32 238, ; 604
	i32 207, ; 605
	i32 10, ; 606
	i32 186, ; 607
	i32 11, ; 608
	i32 173, ; 609
	i32 78, ; 610
	i32 126, ; 611
	i32 83, ; 612
	i32 180, ; 613
	i32 66, ; 614
	i32 107, ; 615
	i32 65, ; 616
	i32 128, ; 617
	i32 122, ; 618
	i32 77, ; 619
	i32 260, ; 620
	i32 250, ; 621
	i32 337, ; 622
	i32 8, ; 623
	i32 214, ; 624
	i32 2, ; 625
	i32 208, ; 626
	i32 44, ; 627
	i32 263, ; 628
	i32 156, ; 629
	i32 128, ; 630
	i32 248, ; 631
	i32 294, ; 632
	i32 23, ; 633
	i32 133, ; 634
	i32 201, ; 635
	i32 234, ; 636
	i32 293, ; 637
	i32 332, ; 638
	i32 314, ; 639
	i32 29, ; 640
	i32 200, ; 641
	i32 62, ; 642
	i32 188, ; 643
	i32 90, ; 644
	i32 87, ; 645
	i32 318, ; 646
	i32 148, ; 647
	i32 190, ; 648
	i32 36, ; 649
	i32 86, ; 650
	i32 222, ; 651
	i32 327, ; 652
	i32 325, ; 653
	i32 322, ; 654
	i32 179, ; 655
	i32 50, ; 656
	i32 6, ; 657
	i32 90, ; 658
	i32 21, ; 659
	i32 270, ; 660
	i32 162, ; 661
	i32 96, ; 662
	i32 50, ; 663
	i32 113, ; 664
	i32 242, ; 665
	i32 130, ; 666
	i32 274, ; 667
	i32 76, ; 668
	i32 27, ; 669
	i32 300, ; 670
	i32 327, ; 671
	i32 215, ; 672
	i32 241, ; 673
	i32 7, ; 674
	i32 272, ; 675
	i32 187, ; 676
	i32 175, ; 677
	i32 110, ; 678
	i32 271, ; 679
	i32 242, ; 680
	i32 224 ; 681
], align 4

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 4

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 4

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 4

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nofree norecurse nosync nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 4, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 1

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: "no-trapping-math"="true" noreturn nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nofree norecurse nosync nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { "no-trapping-math"="true" noreturn nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }

; Metadata
!llvm.module.flags = !{!0, !1, !7}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.2xx @ 96b6bb65e8736e45180905177aa343f0e1854ea3"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"min_enum_size", i32 4}
