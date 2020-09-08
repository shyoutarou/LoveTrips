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
using LoveTrips.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace LoveTrips.UI.Droid.Views
{
    [Activity(Label = "Login", Icon = "@drawable/app_icon")]
    public class LoginView : MvxActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginView);

            int count = 0;
            Button button = FindViewById<Button>(Resource.Id.btnLogin);
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}