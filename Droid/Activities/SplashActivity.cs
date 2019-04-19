// SplashActivity.cs
// Created by Deepak Rao on 17-04-2019
// Copyright © 2018 Sasken. All rights reserved.
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;

namespace VLCSample.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/SplashTheme", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var newIntent = new Intent(this, typeof(MainActivity));
            newIntent.AddFlags(ActivityFlags.ClearTop);
            newIntent.AddFlags(ActivityFlags.SingleTop);

            StartActivity(newIntent);
            Finish();
        }
    }
}
