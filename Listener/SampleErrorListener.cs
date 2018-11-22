using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Karumi.Dexter.Listener;

namespace testDexter.Listener
{
    public class SampleErrorListener : Java.Lang.Object,IPermissionRequestErrorListener
    {
       

        public void OnError(DexterError error)
        {
            Log.Error("Dexter", "There was an error: " + error.ToString());
        }
    }
}