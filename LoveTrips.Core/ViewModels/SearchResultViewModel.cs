using LoveTrips.Core.Extensions;
using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Interfaces.ViewModel;
using LoveTrips.Core.Model;
using LoveTrips.Core.Model.App;
using LoveTrips.Core.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.ObjectModel;

namespace LoveTrips.Core.ViewModel
{
    public class SearchResultViewModel : BaseViewModel, ISearchResultViewModel
    {
        private readonly ITripDataService _tripDataService;
        private int _fromCityId;
        private int _toCityId;
        private DateTime _tripDate;
        private string _departureTime;
        private ObservableCollection<Trip> _trips;

        public ObservableCollection<Trip> Trips
        {
            get { return _trips; }
            set
            {
                _trips = value;
                RaisePropertyChanged(() => Trips);
            }
        }

        public MvxCommand<Trip> ShowJourneyDetailsCommand
        {
            get
            {
                return new MvxCommand<Trip>(selectedJourney =>
                {
                    var parameter = new DataParameter
                    {
                        journeyId = 1,
                        Name = "Alex"
                    };

                    NavigationService.Navigate<TripDetailViewModel, DataParameter>(parameter);
                });
            }
        }

        public MvxCommand ReloadDataCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    Trips = (await _tripDataService.SearchTrip(_fromCityId, _toCityId, _tripDate, DateTime.Parse(_departureTime))).ToObservableCollection();
                });
            }
        }


        public SearchResultViewModel(ITripDataService tripDataService,
            IMvxNavigationService mvxNavigationService) : base(mvxNavigationService)
        {
            _tripDataService = tripDataService;

            //InitializeMessenger();
        }

        //private void InitializeMessenger()
        //{
        //    Messenger.Subscribe<CurrencyChangedMessage>
        //        (async message => await ReloadDataAsync());
        //}

        //public override async void Start()
        //{
        //    base.Start();

        //    await ReloadDataAsync();
        //}

        //protected override async Task InitializeAsync()
        //{
        //    Journeys = (await _journeyDataService.SearchTrip(_fromCityId, _toCityId, _tripDate, DateTime.Parse(_departureTime))).ToObservableCollection();
        //}



        public void Init(SearchParameters parameters)
        {
            _fromCityId = parameters.FromCityId;
            _toCityId = parameters.ToCityId;
            _tripDate = parameters.TripDate;
            _departureTime = parameters.DepartureTime;
        }
    }
}