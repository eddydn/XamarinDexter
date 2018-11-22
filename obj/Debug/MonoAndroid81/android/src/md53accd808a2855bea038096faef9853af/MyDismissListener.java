package md53accd808a2855bea038096faef9853af;


public class MyDismissListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.content.DialogInterface.OnDismissListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDismiss:(Landroid/content/DialogInterface;)V:GetOnDismiss_Landroid_content_DialogInterface_Handler:Android.Content.IDialogInterfaceOnDismissListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("testDexter.Listener.MyDismissListener, testDexter", MyDismissListener.class, __md_methods);
	}


	public MyDismissListener ()
	{
		super ();
		if (getClass () == MyDismissListener.class)
			mono.android.TypeManager.Activate ("testDexter.Listener.MyDismissListener, testDexter", "", this, new java.lang.Object[] {  });
	}

	public MyDismissListener (com.karumi.dexter.PermissionToken p0)
	{
		super ();
		if (getClass () == MyDismissListener.class)
			mono.android.TypeManager.Activate ("testDexter.Listener.MyDismissListener, testDexter", "Com.Karumi.Dexter.IPermissionToken, EDMTBinding", this, new java.lang.Object[] { p0 });
	}


	public void onDismiss (android.content.DialogInterface p0)
	{
		n_onDismiss (p0);
	}

	private native void n_onDismiss (android.content.DialogInterface p0);

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
