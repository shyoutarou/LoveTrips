using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoveTrips.Core.Interfaces.Repository;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Repositories
{
    public class SavedTripRepository : BaseRepository, ISavedTripRepository
    {

        private static readonly List<SavedTrip> AllSavedTrips = new List<SavedTrip>
        {
            new SavedTrip {TripId = 1, NumberOfTravellers = 3, UserId = 1},
            new SavedTrip {TripId = 2, NumberOfTravellers = 2, UserId = 1},
            new SavedTrip {TripId = 3, NumberOfTravellers = 3, UserId = 1},
            new SavedTrip {TripId = 4, NumberOfTravellers = 2, UserId = 1},
            new SavedTrip {TripId = 1, NumberOfTravellers = 3, UserId = 2},
            new SavedTrip {TripId = 2, NumberOfTravellers = 3, UserId = 2}
        };

        public async Task<IEnumerable<SavedTrip>> GetSavedTripForUser(int userId)
        {
            return await Task.FromResult(AllSavedTrips.Where(j => j.UserId == userId));
        }

        public async Task AddSavedTrip(int userId, int tripId, int numberOfTravellers)
        {
            await
                Task.Run(
                    () =>
                        AllSavedTrips.Add(new SavedTrip
                        {
                            TripId = tripId,
                            NumberOfTravellers = numberOfTravellers,
                            UserId = userId
                        }));
        }

    }
}