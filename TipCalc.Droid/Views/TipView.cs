using Android.App;
using Android.OS;
using LoveTrips.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
//using TipCalc.Core.ViewModels;

namespace TipCalc.UI.Droid.Views
{
    [Activity(Label = "Tip Calculator", MainLauncher = true)]
    public class TipView : MvxActivity<TipViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TipView);
        }
    }
}