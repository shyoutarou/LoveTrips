using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using LoveTrips.Core.ViewModels;
using Android.Widget;

namespace LoveTrips.UI.Droid.Views
{
    [Activity(Label = "Tip", MainLauncher = true, Icon ="@drawable/app_icon")]
    public class TipView : MvxActivity<TipViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Tip);

            int count = 0;
            Button button = FindViewById<Button>(Resource.Id.MyButton); 
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}