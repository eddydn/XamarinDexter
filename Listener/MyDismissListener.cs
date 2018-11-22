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

namespace testDexter.Listener
{
    class MyDismissListener : Java.Lang.Object, IDialogInterfaceOnDismissListener
    {
        IPermissionToken token;

        public MyDismissListener(IPermissionToken token)
        {
            this.token = token;
        }




        public void OnDismiss(IDialogInterface dialog)
        {
            token.CancelPermissionRequest();
        }
    }
}