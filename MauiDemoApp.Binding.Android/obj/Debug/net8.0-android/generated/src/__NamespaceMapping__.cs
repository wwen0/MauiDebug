using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.ia.android.sdk", Managed="Com.Sas.IA.Android.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk", Managed="Com.Sas.Mkt.Mobile.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.ads", Managed="Com.Sas.Mkt.Mobile.Sdk.Ads")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.database", Managed="Com.Sas.Mkt.Mobile.Sdk.Database")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.domain", Managed="Com.Sas.Mkt.Mobile.Sdk.Domain")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.id", Managed="Com.Sas.Mkt.Mobile.Sdk.ID")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.loc", Managed="Com.Sas.Mkt.Mobile.Sdk.Loc")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.offline", Managed="Com.Sas.Mkt.Mobile.Sdk.Offline")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.server", Managed="Com.Sas.Mkt.Mobile.Sdk.Server")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.tasks", Managed="Com.Sas.Mkt.Mobile.Sdk.Tasks")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sas.mkt.mobile.sdk.util", Managed="Com.Sas.Mkt.Mobile.Sdk.Util")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate float _JniMarshal_PP_F (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate short _JniMarshal_PP_S (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPD_V (IntPtr jnienv, IntPtr klass, double p0);
delegate IntPtr _JniMarshal_PPDD_L (IntPtr jnienv, IntPtr klass, double p0, double p1);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPILL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate bool _JniMarshal_PPJ_Z (IntPtr jnienv, IntPtr klass, long p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate long _JniMarshal_PPL_J (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLF_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPLILI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, int p3);
delegate void _JniMarshal_PPLILL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLIZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, bool p3);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLSS_V (IntPtr jnienv, IntPtr klass, IntPtr p0, short p1, short p2);
delegate void _JniMarshal_PPLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate bool _JniMarshal_PPLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate void _JniMarshal_PPS_V (IntPtr jnienv, IntPtr klass, short p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

