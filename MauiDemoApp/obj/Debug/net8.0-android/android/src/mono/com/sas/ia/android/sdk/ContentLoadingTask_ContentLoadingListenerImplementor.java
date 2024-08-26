package mono.com.sas.ia.android.sdk;


public class ContentLoadingTask_ContentLoadingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.sas.ia.android.sdk.ContentLoadingTask.ContentLoadingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_loadComplete:(Ljava/lang/String;Ljava/lang/String;)V:GetLoadComplete_Ljava_lang_String_Ljava_lang_String_Handler:Com.Sas.IA.Android.Sdk.ContentLoadingTask/IContentLoadingListenerInvoker, MauiDemoApp.Binding.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Sas.IA.Android.Sdk.ContentLoadingTask+IContentLoadingListenerImplementor, MauiDemoApp.Binding.Android", ContentLoadingTask_ContentLoadingListenerImplementor.class, __md_methods);
	}


	public ContentLoadingTask_ContentLoadingListenerImplementor ()
	{
		super ();
		if (getClass () == ContentLoadingTask_ContentLoadingListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Sas.IA.Android.Sdk.ContentLoadingTask+IContentLoadingListenerImplementor, MauiDemoApp.Binding.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void loadComplete (java.lang.String p0, java.lang.String p1)
	{
		n_loadComplete (p0, p1);
	}

	private native void n_loadComplete (java.lang.String p0, java.lang.String p1);

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
