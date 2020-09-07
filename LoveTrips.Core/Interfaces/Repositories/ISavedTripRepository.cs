using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Repository
{
    public interface ISavedTripRepository
    {
        Task<IEnumerable<SavedTrip>> GetSavedTripForUser(int userId);

        Task AddSavedTrip(int userId, int tripId, int numberOfTravellers);
    }
}