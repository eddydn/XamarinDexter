using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Karumi.Dexter;
using Com.Karumi.Dexter.Listener;
using Com.Karumi.Dexter.Listener.Single;

namespace testDexter.Listener
{
    public class SamplePermissionListener : Java.Lang.Object, IPermissionListener
    {

        private MainActivity activity;

        public SamplePermissionListener(MainActivity activity)
        {
            this.activity = activity;
        }


        public void OnPermissionDenied(PermissionDeniedResponse response)
        {
            activity.ShowPermissionDenied(response.PermissionName, response.IsPermanentlyDenied);
        }

        public void OnPermissionGranted(PermissionGrantedResponse response)
        {
            activity.ShowPermissionGranted(response.PermissionName);
        }

        public void OnPermissionRationaleShouldBeShown(PermissionRequest p0, IPermissionToken token)
        {
            activity.ShowPermissionRationale(token);
        }
    }
}