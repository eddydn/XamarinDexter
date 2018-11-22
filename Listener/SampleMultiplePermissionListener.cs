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
using Com.Karumi.Dexter.Listener.Multi;

namespace testDexter.Listener
{
    public class SampleMultiplePermissionListener : Java.Lang.Object,IMultiplePermissionsListener
    {
        private  MainActivity activity;

    public SampleMultiplePermissionListener(MainActivity activity)
        {
            this.activity = activity;
        }

        public void OnPermissionRationaleShouldBeShown(IList<PermissionRequest> permissions, IPermissionToken token)
        {
            activity.ShowPermissionRationale(token);
        }

        public void OnPermissionsChecked(MultiplePermissionsReport report)
        {

            foreach (var response in report.GrantedPermissionResponses)
                activity.ShowPermissionGranted(response.PermissionName);
            foreach (var response in report.DeniedPermissionResponses)
                activity.ShowPermissionDenied(response.PermissionName,response.IsPermanentlyDenied);

        }
    }
}