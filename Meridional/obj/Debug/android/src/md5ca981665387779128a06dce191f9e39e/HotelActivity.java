package md5ca981665387779128a06dce191f9e39e;


public class HotelActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Meridional.HotelActivity, Meridional, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HotelActivity.class, __md_methods);
	}


	public HotelActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HotelActivity.class)
			mono.android.TypeManager.Activate ("Meridional.HotelActivity, Meridional, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
