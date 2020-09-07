using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Interfaces.Repository;
using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Model;

namespace MyTrains.Core.Services.Data
{
    public class SavedTripDataService: ISavedTripDataService
    {
        private readonly ISavedTripRepository _savedTripRepository;
        private readonly ITripDataService _tripDataService;
        private readonly ICityDataService _cityDataService;

        public SavedTripDataService(ISavedTripRepository savedTripRepository, ITripDataService tripDataService, ICityDataService cityDataService)
        {
            _savedTripRepository = savedTripRepository;
            _tripDataService = tripDataService;
            _cityDataService = cityDataService;
        }

        public async Task<IEnumerable<SavedTrip>> GetSavedTripForUser(int userId)
        {

            var list = await _savedTripRepository.GetSavedTripForUser(userId);
            foreach (var savedJourney in list)
            {
                var journey = await _tripDataService.GetTripDetails(savedJourney.TripId);
                journey.FromCity = await _cityDataService.GetCityById(journey.FromCityId);
                journey.ToCity = await _cityDataService.GetCityById(journey.ToCityId);

                savedJourney.Trip = journey;
                savedJourney.TripId = journey.TripId;
            }

            return list;
        }

        public async Task AddSavedTrip(int userId, int tripId, int numberOfTravellers)
        {
            await _savedTripRepository.AddSavedTrip(userId, tripId, numberOfTravellers);
        }
    }
}