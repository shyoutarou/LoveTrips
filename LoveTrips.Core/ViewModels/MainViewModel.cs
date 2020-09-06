using LoveTrips.Core.Interfaces.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;
using System;

namespace LoveTrips.Core.ViewModels
{
    public class MainViewModel : MvxViewModel, IMainViewModel
    {
        private readonly Lazy<TipViewModel> _tipViewModel;

        public TipViewModel TipViewModel => _tipViewModel.Value;

        public MainViewModel()
        {
            _tipViewModel = new Lazy<TipViewModel>(Mvx.IoCProvider.IoCConstruct<TipViewModel>);
        }
    }
}
