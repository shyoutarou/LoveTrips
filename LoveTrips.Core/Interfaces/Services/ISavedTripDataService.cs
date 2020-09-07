using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface ISavedTripDataService
    {
        Task<IEnumerable<SavedTrip>> GetSavedTripForUser(int userId);

        Task AddSavedTrip(int userId, int tripId, int numberOfTravellers);
    }
}