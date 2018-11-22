using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using Com.Karumi.Dexter;
using Android;
using Com.Karumi.Dexter.Listener.Multi;
using Android.Content;
using System;
using testDexter.Listener;
using Java.Lang;
using Android.Support.V4.Content;
using Android.Graphics;
using Com.Karumi.Dexter.Listener.Single;

namespace testDexter
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        Button btn_all_permission, btn_camera_permission, btn_contact_permission, btn_audio_permission;
        TextView txt_audio_permission, txt_camera_permission, txt_contact_permission;

        internal void ShowPermissionDenied(string permissionName, bool isPermanentlyDenied)
        {
            TextView feedbackView = GetFeedbackViewForPermission(permissionName);
            feedbackView.Text = (isPermanentlyDenied ? Resources.GetString(Resource.String.permission_permanently_denied_feedback)
        : Resources.GetString(Resource.String.permission_denied_feedback));
            int color = ContextCompat.GetColor(this, Resource.Color.permission_denied);
            feedbackView.SetTextColor(Color.ParseColor(Java.Lang.String.Format("#%06X", 0xFFFFFF & color)));
        }

       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btn_all_permission = FindViewById<Button>(Resource.Id.all_permissions_button);
            btn_camera_permission = FindViewById<Button>(Resource.Id.camera_permission_button);
            btn_contact_permission = FindViewById<Button>(Resource.Id.contacts_permission_button);
            btn_audio_permission = FindViewById<Button>(Resource.Id.audio_permission_button);

            txt_audio_permission = FindViewById<TextView>(Resource.Id.audio_permission_feedback);
            txt_camera_permission = FindViewById<TextView>(Resource.Id.camera_permission_feedback);
            txt_contact_permission = FindViewById<TextView>(Resource.Id.contacts_permission_feedback);


            btn_all_permission.Click += delegate
            {
                Dexter.WithActivity(this)
                    .WithPermissions(Manifest.Permission.Camera, 
                                     Manifest.Permission.ReadContacts,
                                     Manifest.Permission.RecordAudio)
                    .WithListener(new CompositeMultiplePermissionsListener(new SampleMultiplePermissionListener(this)))
                    .WithErrorListener(new SampleErrorListener())
                    .Check();

            };

            btn_contact_permission.Click += delegate
            {
                Dexter.WithActivity(this)
                    .WithPermission(Manifest.Permission.ReadContacts)
                    .WithListener(new CompositePermissionListener(new SamplePermissionListener(this)))
                    .Check();

            };

            btn_camera_permission.Click += delegate
            {
                Dexter.WithActivity(this)
                    .WithPermission(Manifest.Permission.Camera)
                    .WithListener(new CompositePermissionListener(new SamplePermissionListener(this)))
                    .Check();

            };

            btn_audio_permission.Click += delegate
            {
                Dexter.WithActivity(this)
                    .WithPermission(Manifest.Permission.RecordAudio)
                    .WithListener(new CompositePermissionListener(new SamplePermissionListener(this)))
                    .Check();

            };

        }

        internal void ShowPermissionGranted(string permissionName)
        {
            TextView feedbackView = GetFeedbackViewForPermission(permissionName);
            feedbackView.Text = Resources.GetString(Resource.String.permission_granted_feedback);
            int color = ContextCompat.GetColor(this, Resource.Color.permission_granted);
            feedbackView.SetTextColor(Color.ParseColor(Java.Lang.String.Format("#%06X", 0xFFFFFF & color)));
        }

        private TextView GetFeedbackViewForPermission(string name)
        {
            TextView feedbackView;
            switch (name)
            {
                case Manifest.Permission.Camera:
                    feedbackView = txt_camera_permission;
                    break;
                case Manifest.Permission.ReadContacts:
                    feedbackView = txt_contact_permission;
                    break;
                case Manifest.Permission.RecordAudio:
                    feedbackView = txt_audio_permission;
                    break;
                default:
                    throw new RuntimeException("No feedback view for this permission");
            }
            return feedbackView;
        }

        public void ShowPermissionRationale(IPermissionToken token)
        {
            new Android.Support.V7.App.AlertDialog.Builder(this).SetTitle(Resource.String.permission_rationale_title)
       .SetMessage(Resource.String.permission_rationale_message)
       .SetNegativeButton(Android.Resource.String.Cancel, delegate
       {

           token.ContinuePermissionRequest();

       })
       .SetPositiveButton(Android.Resource.String.Ok, delegate
       {
           token.ContinuePermissionRequest();
       })
       .SetOnDismissListener(new MyDismissListener(token))
        .Show();
        }


    }
}