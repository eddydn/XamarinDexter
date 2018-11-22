package md53accd808a2855bea038096faef9853af;


public class SampleErrorListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.karumi.dexter.listener.PermissionRequestErrorListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Lcom/karumi/dexter/listener/DexterError;)V:GetOnError_Lcom_karumi_dexter_listener_DexterError_Handler:Com.Karumi.Dexter.Listener.IPermissionRequestErrorListenerInvoker, EDMTBinding\n" +
			"";
		mono.android.Runtime.register ("testDexter.Listener.SampleErrorListener, testDexter", SampleErrorListener.class, __md_methods);
	}


	public SampleErrorListener ()
	{
		super ();
		if (getClass () == SampleErrorListener.class)
			mono.android.TypeManager.Activate ("testDexter.Listener.SampleErrorListener, testDexter", "", this, new java.lang.Object[] {  });
	}


	public void onError (com.karumi.dexter.listener.DexterError p0)
	{
		n_onError (p0);
	}

	private native void n_onError (com.karumi.dexter.listener.DexterError p0);

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
