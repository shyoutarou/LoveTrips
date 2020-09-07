using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Interfaces.Repository;
using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Model;

namespace MyTrains.Core.Services.Data
{
    public class TripDataService: ITripDataService
    {
        private readonly ITripRepository _tripRepository;
        private readonly ICityRepository _cityRepository;


        public TripDataService(ITripRepository tripRepository, 
            ICityRepository cityRepository)
        {
            _tripRepository = tripRepository;
            _cityRepository = cityRepository;
        }

        public async Task<IEnumerable<Trip>> SearchTrip(int fromCity, int toCity, DateTime journeyDate, DateTime departureTime)
        {
            var journeys = await _tripRepository.SearchTrip(fromCity, toCity, journeyDate, departureTime);
            foreach (var journey in journeys)
            {
                journey.FromCity =  await _cityRepository.GetCityById(journey.FromCityId);
                journey.ToCity = await _cityRepository.GetCityById(journey.ToCityId);
            }
            return journeys;
        }

        public async Task<Trip> GetTripDetails(int journeyId)
        {
            return await _tripRepository.GetTripDetails(journeyId);
        }
    }
}