using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Model.App;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;

namespace LoveTrips.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel<DataParameter>, IDisposable
    {
        protected IMvxNavigationService NavigationService;
        protected DataParameter Parameters;

        public BaseViewModel(IMvxNavigationService navigator)
        {
            NavigationService = navigator;
        }

        public override void Prepare(DataParameter parameter)
        {
            Parameters = parameter;
        }

        public void Dispose()
        {
            NavigationService = null;
        }
    }
}
