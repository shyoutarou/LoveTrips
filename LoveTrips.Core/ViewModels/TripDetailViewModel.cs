using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Interfaces.ViewModel;
using LoveTrips.Core.Model;
using LoveTrips.Core.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MyTrains.Core.ViewModel
{
    public class TripDetailViewModel : BaseViewModel, ITripDetailViewModel
    {
        private readonly ITripDataService _tripDataService;
        private readonly ISavedTripDataService _savedTripDataService;
        private readonly IDialogService _dialogService;
        private readonly IUserDataService _userDataService;
        private Trip _selectedTrip;
        private int _journeyId;
        private int _numberOfTravellers;

        public MvxCommand AddToSavedJourneysCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    await _savedTripDataService.AddSavedTrip
                    (_userDataService.GetActiveUser().UserId, SelectedJourney.TripId, NumberOfTravellers);

                    //Hardcoded text, better with resx translations
                    //await
                    //    _dialogService.ShowAlertAsync("This journey is now in your Saved Journeys!", "My Trains says...", "OK");

                    //await
                    //    _dialogService.ShowAlertAsync
                    //    (TextSource.GetText("AddedToSavedJourneysMessage"), 
                    //     TextSource.GetText("AddedToSavedJourneysTitle"), 
                    //     TextSource.GetText("AddedToSavedJourneysButton"));
                });
            }
        }

        //public MvxCommand CloseCommand
        //{ get { return new MvxCommand(() => Close(this)); } }

        public Trip SelectedJourney
        {
            get { return _selectedTrip; }
            set
            {
                _selectedTrip = value;
                RaisePropertyChanged(() => SelectedJourney);
            }
        }

        public int NumberOfTravellers
        {
            get { return _numberOfTravellers; }
            set
            {
                _numberOfTravellers = value;
                RaisePropertyChanged(() => NumberOfTravellers);
            }
        }

        public TripDetailViewModel(ITripDataService journeyDataService,
            ISavedTripDataService savedJourneyDataService,
            IDialogService dialogService,
            IMvxNavigationService mvxNavigationService)
            : base(mvxNavigationService)
        {
            _tripDataService = journeyDataService;
            _savedTripDataService = savedJourneyDataService;
            _dialogService = dialogService;
            _userDataService = null;
        }

        public void Init(int journeyId)
        {
            _journeyId = journeyId;
        }

        //public override async void Start()
        //{
        //    base.Start();
        //    await ReloadDataAsync();
        //}

        //protected override async Task InitializeAsync()
        //{
        //    SelectedJourney = await _tripDataService.GetTripDetails(_journeyId);
        //}

        //public class SavedState
        //{
        //    public int JourneyId { get; set; }
        //}

        //public SavedState SaveState()
        //{
        //    MvxTrace.Trace("SaveState called");
        //    return new SavedState { JourneyId = _journeyId };
        //}

        //public void ReloadState(SavedState savedState)
        //{
        //    MvxTrace.Trace("ReloadState called with {0}", 
        //        savedState.JourneyId);
        //    _journeyId = savedState.JourneyId;
        //}
    }
}