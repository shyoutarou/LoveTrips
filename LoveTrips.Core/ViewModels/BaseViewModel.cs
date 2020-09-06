using LoveTrips.Core.Interfaces.Services;
using MvvmCross.Localization;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;


namespace LoveTrips.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel, IDisposable
    {
        protected IMvxNavigationService NavigationService;
        protected IDialogService DialogService;

         

        public BaseViewModel(IMvxNavigationService navigator,
                             IDialogService dialog)
        {
            NavigationService = navigator;
            DialogService = dialog;
        }

        public void Dispose()
        {
            NavigationService = null;
        }
    }
}
