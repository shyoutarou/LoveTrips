using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Model.App;
using LoveTrips.Core.Utility;
using LoveTrips.Core.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.ObjectModel;

namespace LoveTrips.Core.ViewModel
{
    public class MenuViewModel: BaseViewModel
    {
        public MvxCommand<MenuItem> MenuItemSelectCommand => new MvxCommand<MenuItem>(OnMenuEntrySelect);
        public ObservableCollection<MenuItem> MenuItems { get; }

        public event EventHandler CloseMenu;

        public MenuViewModel(IMvxNavigationService mvxNavigationService)
            : base(mvxNavigationService)
        {
            MenuItems = new ObservableCollection<MenuItem>();
            CreateMenuItems();
        }

        private void CreateMenuItems()
        {
            MenuItems.Add(new MenuItem
            {
                Title = "Search Journey",
                ViewModelType = typeof(SearchTripViewModel),
                Option = MenuOption.SearchJourney,
                IsSelected = true
            });

            MenuItems.Add(new MenuItem
            {
                Title = "My Saved Journeys",
                ViewModelType = typeof(SavedTripViewModel),
                Option = MenuOption.SavedJourneys,
                IsSelected = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Settings",
                ViewModelType = typeof(SettingsViewModel),
                Option = MenuOption.Settings,
                IsSelected = false
            });
        }

        private void OnMenuEntrySelect(MenuItem item)
        {
            var viewmodel = item.ViewModelType;
            //NavigationService.Navigate<viewmodel>();
            RaiseCloseMenu();
        }

        private void RaiseCloseMenu()
        {
            CloseMenu?.Invoke(this, EventArgs.Empty);
        }
    }
}