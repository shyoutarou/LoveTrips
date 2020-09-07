using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface ITripDataService
    {
        Task<IEnumerable<Trip>> SearchTrip(int fromCity, int toCity, DateTime journeyDate, DateTime departureTime);

        Task<Trip> GetTripDetails(int journeyId);
    }
}