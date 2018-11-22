package md53accd808a2855bea038096faef9853af;


public class SamplePermissionListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.karumi.dexter.listener.single.PermissionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPermissionDenied:(Lcom/karumi/dexter/listener/PermissionDeniedResponse;)V:GetOnPermissionDenied_Lcom_karumi_dexter_listener_PermissionDeniedResponse_Handler:Com.Karumi.Dexter.Listener.Single.IPermissionListenerInvoker, EDMTBinding\n" +
			"n_onPermissionGranted:(Lcom/karumi/dexter/listener/PermissionGrantedResponse;)V:GetOnPermissionGranted_Lcom_karumi_dexter_listener_PermissionGrantedResponse_Handler:Com.Karumi.Dexter.Listener.Single.IPermissionListenerInvoker, EDMTBinding\n" +
			"n_onPermissionRationaleShouldBeShown:(Lcom/karumi/dexter/listener/PermissionRequest;Lcom/karumi/dexter/PermissionToken;)V:GetOnPermissionRationaleShouldBeShown_Lcom_karumi_dexter_listener_PermissionRequest_Lcom_karumi_dexter_PermissionToken_Handler:Com.Karumi.Dexter.Listener.Single.IPermissionListenerInvoker, EDMTBinding\n" +
			"";
		mono.android.Runtime.register ("testDexter.Listener.SamplePermissionListener, testDexter", SamplePermissionListener.class, __md_methods);
	}


	public SamplePermissionListener ()
	{
		super ();
		if (getClass () == SamplePermissionListener.class)
			mono.android.TypeManager.Activate ("testDexter.Listener.SamplePermissionListener, testDexter", "", this, new java.lang.Object[] {  });
	}

	public SamplePermissionListener (md508f1a7b38f0b1d592147cc859dfb6cc3.MainActivity p0)
	{
		super ();
		if (getClass () == SamplePermissionListener.class)
			mono.android.TypeManager.Activate ("testDexter.Listener.SamplePermissionListener, testDexter", "testDexter.MainActivity, testDexter", this, new java.lang.Object[] { p0 });
	}


	public void onPermissionDenied (com.karumi.dexter.listener.PermissionDeniedResponse p0)
	{
		n_onPermissionDenied (p0);
	}

	private native void n_onPermissionDenied (com.karumi.dexter.listener.PermissionDeniedResponse p0);


	public void onPermissionGranted (com.karumi.dexter.listener.PermissionGrantedResponse p0)
	{
		n_onPermissionGranted (p0);
	}

	private native void n_onPermissionGranted (com.karumi.dexter.listener.PermissionGrantedResponse p0);


	public void onPermissionRationaleShouldBeShown (com.karumi.dexter.listener.PermissionRequest p0, com.karumi.dexter.PermissionToken p1)
	{
		n_onPermissionRationaleShouldBeShown (p0, p1);
	}

	private native void n_onPermissionRationaleShouldBeShown (com.karumi.dexter.listener.PermissionRequest p0, com.karumi.dexter.PermissionToken p1);

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
