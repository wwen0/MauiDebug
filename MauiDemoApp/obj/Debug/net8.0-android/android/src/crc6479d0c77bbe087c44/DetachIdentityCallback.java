package crc6479d0c77bbe087c44;


public class DetachIdentityCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.sas.mkt.mobile.sdk.SASCollector.DetachIdentityCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onComplete:(Z)V:GetOnComplete_ZHandler:Com.Sas.Mkt.Mobile.Sdk.SASCollector/IDetachIdentityCallbackInvoker, MauiDemoApp.Binding.Android\n" +
			"";
		mono.android.Runtime.register ("MauiDemoApp.Services.DetachIdentityCallback, MauiDemoApp", DetachIdentityCallback.class, __md_methods);
	}


	public DetachIdentityCallback ()
	{
		super ();
		if (getClass () == DetachIdentityCallback.class) {
			mono.android.TypeManager.Activate ("MauiDemoApp.Services.DetachIdentityCallback, MauiDemoApp", "", this, new java.lang.Object[] {  });
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
