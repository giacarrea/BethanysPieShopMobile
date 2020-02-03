using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BethanysPieShopMobile
{
    [Activity(Label = "AboutActivity")]
    public class AboutActivity : Activity
    {
        private Button _phoneButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.about);
            // Create your application here
            FindViews();
            LinkEventHandlers();
        }

        private void LinkEventHandlers()
        {
            _phoneButton.Click += _phoneButton_Click;
        }

        private void _phoneButton_Click(object sender, EventArgs e)
        {
            string[] PermissionsLocation = {
        Android.Manifest.Permission.CallPhone
    };
            RequestPermissions(PermissionsLocation, 0);

            Toast.MakeText(this, "mlem", ToastLength.Short);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            if (grantResults[0] == Permission.Granted) 
            {
                var intent = new Intent(Intent.ActionCall);
                intent.SetData(Android.Net.Uri.Parse("tel:+1555779933"));
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            }
            
        }

        private void FindViews()
        {
            _phoneButton = FindViewById<Button>(Resource.Id.phoneButton);

        }
    }
}