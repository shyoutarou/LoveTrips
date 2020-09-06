
using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace LoveTrips.UI.Droid
{
    [Activity(
        MainLauncher = true,
        Label = "@string/app_name",
        Theme = "@style/Theme.Splash", NoHistory = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity  
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}