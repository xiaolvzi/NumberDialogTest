package md515b0a8b47e2d212d2d645f4be20db9d6;


public class IDisplayDialogImpl
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App79.Droid.IDisplayDialogImpl, App79.Android", IDisplayDialogImpl.class, __md_methods);
	}


	public IDisplayDialogImpl ()
	{
		super ();
		if (getClass () == IDisplayDialogImpl.class)
			mono.android.TypeManager.Activate ("App79.Droid.IDisplayDialogImpl, App79.Android", "", this, new java.lang.Object[] {  });
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
