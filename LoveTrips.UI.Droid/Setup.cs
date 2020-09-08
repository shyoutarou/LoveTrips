using LoveTrips.Core;
using LoveTrips.Core.Interfaces.Services;
using LoveTrips.UI.Droid.Services;
using MvvmCross;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters;
using System.Collections.Generic;
using System.Reflection;

namespace LoveTrips.UI.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            Mvx.IoCProvider.RegisterSingleton<IDialogService>(() => new DialogService());
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            return new MvxAppCompatViewPresenter(AndroidViewAssemblies);
        }

        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            typeof(Android.Support.Design.Widget.NavigationView).Assembly,
            typeof(Android.Support.Design.Widget.FloatingActionButton).Assembly,
            typeof(Android.Support.V7.Widget.Toolbar).Assembly,
            typeof(Android.Support.V4.Widget.DrawerLayout).Assembly,
            typeof(Android.Support.V4.View.ViewPager).Assembly,
            //typeof(MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerView).Assembly
        };

        /// <summary>
        /// This is very important to override. The default view presenter does not know how to show fragments!
        /// </summary>
        //protected override IMvxAndroidViewPresenter CreateViewPresenter()
        //{
        //    var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
        //    Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);

        //    //add a presentation hint handler to listen for pop to root
        //    mvxFragmentsPresenter.AddPresentationHintHandler<MvxPanelPopToRootPresentationHint>(hint =>
        //    {
        //        var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
        //        var fragmentActivity = activity as Android.Support.V4.App.FragmentActivity;

        //        for (int i = 0; i < fragmentActivity.SupportFragmentManager.BackStackEntryCount; i++)
        //        {
        //            fragmentActivity.SupportFragmentManager.PopBackStack();
        //        }
        //        return true;
        //    });
        //    //register the presentation hint to pop to root
        //    //picked up in the third view model
        //    Mvx.RegisterSingleton<MvxPresentationHint>(() => new MvxPanelPopToRootPresentationHint());
        //    return mvxFragmentsPresenter;
        //}


    }
}