using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SimpleControls;

namespace SimpleControls.ImageDialog.Tests.Droid
{
    [Activity(Label = "SimpleControls.ImageDialog.Tests", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            SimpleControls.ImageDialog.Droid.ImageDialogImplementation.Init();
            LoadApplication(new App());
        }
    }
}

