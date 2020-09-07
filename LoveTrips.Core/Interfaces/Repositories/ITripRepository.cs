using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Repository
{
    public  interface ITripRepository
    {
        Task<IEnumerable<Trip>> SearchTrip(int fromCity, int toCity, DateTime tripDate, DateTime departureTime);

        Task<Trip> GetTripDetails(int tripId);
    }
}
