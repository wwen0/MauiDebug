package crc64b9036efb8b459044;


public class IdentityCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.sas.mkt.mobile.sdk.SASCollector.IdentityCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onComplete:(Z)V:GetOnComplete_ZHandler:Com.Sas.Mkt.Mobile.Sdk.SASCollector/IIdentityCallbackInvoker, MauiDemoApp.Binding.Android\n" +
			"";
		mono.android.Runtime.register ("MauiDemoApp.Platforms.Android.Services.IdentityCallback, MauiDemoApp", IdentityCallback.class, __md_methods);
	}


	public IdentityCallback ()
	{
		super ();
		if (getClass () == IdentityCallback.class) {
			mono.android.TypeManager.Activate ("MauiDemoApp.Platforms.Android.Services.IdentityCallback, MauiDemoApp", "", this, new java.lang.Object[] {  });
		}
	}


	public void onComplete (boolean p0)
	{
		n_onComplete (p0);
	}

	private native void n_onComplete (boolean p0);

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
