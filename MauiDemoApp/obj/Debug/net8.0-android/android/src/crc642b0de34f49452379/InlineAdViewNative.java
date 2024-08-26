package crc642b0de34f49452379;


public class InlineAdViewNative
	extends com.sas.mkt.mobile.sdk.ads.SASCollectorAd
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MauiDemoApp.Platforms.Android.MobileSpots.InlineAdViewNative, MauiDemoApp", InlineAdViewNative.class, __md_methods);
	}


	public InlineAdViewNative (android.content.Context p0)
	{
		super (p0);
		if (getClass () == InlineAdViewNative.class) {
			mono.android.TypeManager.Activate ("MauiDemoApp.Platforms.Android.MobileSpots.InlineAdViewNative, MauiDemoApp", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public InlineAdViewNative (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == InlineAdViewNative.class) {
			mono.android.TypeManager.Activate ("MauiDemoApp.Platforms.Android.MobileSpots.InlineAdViewNative, MauiDemoApp", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public InlineAdViewNative (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == InlineAdViewNative.class) {
			mono.android.TypeManager.Activate ("MauiDemoApp.Platforms.Android.MobileSpots.InlineAdViewNative, MauiDemoApp", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2 });
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
