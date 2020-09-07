namespace LoveTrips.Core.Model
{
    public class SavedTrip: BaseModel
    {
        public int TripId { get; set; }

        public Trip Trip { get; set; }

        public int UserId { get; set; }

        public int NumberOfTravellers { get; set; }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}