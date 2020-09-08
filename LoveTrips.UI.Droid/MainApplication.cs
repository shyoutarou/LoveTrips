using Android.App;
using Android.Runtime;
using LoveTrips.Core;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;

namespace LoveTrips.UI.Droid
{
    [Application]
    //public class MainApplication : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    public class MainApplication : MvxAppCompatApplication<Setup, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
                : base(javaReference, transfer)
        {
        }
    }
}