package crc642b0de34f49452379;


public class InterstitialAdViewNative
	extends com.sas.mkt.mobile.sdk.ads.SASCollectorInterstitialAd
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MauiDemoApp.Platforms.Android.MobileSpots.InterstitialAdViewNative, MauiDemoApp", InterstitialAdViewNative.class, __md_methods);
	}


	public InterstitialAdViewNative (android.content.Context p0)
	{
		super (p0);
		if (getClass () == InterstitialAdViewNative.class) {
			mono.android.TypeManager.Activate ("MauiDemoApp.Platforms.Android.MobileSpots.InterstitialAdViewNative, MauiDemoApp", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
