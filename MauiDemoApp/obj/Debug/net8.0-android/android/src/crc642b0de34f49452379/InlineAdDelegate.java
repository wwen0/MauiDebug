package crc642b0de34f49452379;


public class InlineAdDelegate
	extends com.sas.ia.android.sdk.AdDelegate
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoaded:(Lcom/sas/ia/android/sdk/AbstractAd;)V:GetOnLoaded_Lcom_sas_ia_android_sdk_AbstractAd_Handler\n" +
			"n_onDefaultLoaded:(Lcom/sas/ia/android/sdk/AbstractAd;)V:GetOnDefaultLoaded_Lcom_sas_ia_android_sdk_AbstractAd_Handler\n" +
			"n_onClosed:(Lcom/sas/ia/android/sdk/AbstractAd;)V:GetOnClosed_Lcom_sas_ia_android_sdk_AbstractAd_Handler\n" +
			"";
		mono.android.Runtime.register ("MauiDemoApp.Platforms.Android.MobileSpots.InlineAdDelegate, MauiDemoApp", InlineAdDelegate.class, __md_methods);
	}


	public InlineAdDelegate ()
	{
		super ();
		if (getClass () == InlineAdDelegate.class) {
			mono.android.TypeManager.Activate ("MauiDemoApp.Platforms.Android.MobileSpots.InlineAdDelegate, MauiDemoApp", "", this, new java.lang.Object[] {  });
		}
	}


	public void onLoaded (com.sas.ia.android.sdk.AbstractAd p0)
	{
		n_onLoaded (p0);
	}

	private native void n_onLoaded (com.sas.ia.android.sdk.AbstractAd p0);


	public void onDefaultLoaded (com.sas.ia.android.sdk.AbstractAd p0)
	{
		n_onDefaultLoaded (p0);
	}

	private native void n_onDefaultLoaded (com.sas.ia.android.sdk.AbstractAd p0);


	public void onClosed (com.sas.ia.android.sdk.AbstractAd p0)
	{
		n_onClosed (p0);
	}

	private native void n_onClosed (com.sas.ia.android.sdk.AbstractAd p0);

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
