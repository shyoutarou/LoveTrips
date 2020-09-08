using LoveTrips.Core.Extensions;
using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Interfaces.ViewModel;
using LoveTrips.Core.Model;
using LoveTrips.Core.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using System.Collections.ObjectModel;

namespace LoveTrips.Core.ViewModel
{
    public class SavedTripViewModel : BaseViewModel, ISavedTripViewModel
    {
        private readonly ISavedTripDataService _savedTripDataService;
        private readonly IUserDataService _userDataService;

        private ObservableCollection<SavedTrip> _savedTrips;

        public MvxCommand ReloadDataCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    var user = _userDataService.GetActiveUser();
                    SavedJourneys = (await _savedTripDataService.GetSavedTripForUser(user.UserId)).ToObservableCollection();
                });
            }
        }

        public ObservableCollection<SavedTrip> SavedJourneys
        {
            get
            {
                return _savedTrips;
            }
            set
            {
                _savedTrips = value;
                RaisePropertyChanged(() => SavedJourneys);
            }
        }

        public SavedTripViewModel(IMvxNavigationService mvxNavigationService)
            : base(mvxNavigationService)
        {
            _savedTripDataService = null;
            _userDataService = null;

            //InitializeMessenger();
        }

        //private void InitializeMessenger()
        //{
        //    Messenger.Subscribe<CurrencyChangedMessage>(async message => await ReloadDataAsync());
        //}

      
        //public override async void Start()
        //{
        //    base.Start();
        //    await ReloadDataAsync();
        //}

        //protected override async Task InitializeAsync()
        //{
        //    var user = _userDataService.GetActiveUser();
        //    SavedJourneys = (await _savedTripDataService.GetSavedTripForUser(user.UserId)).ToObservableCollection();
        //}
    }
}