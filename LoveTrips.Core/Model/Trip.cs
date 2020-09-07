using System;

namespace LoveTrips.Core.Model
{
    public class Trip: BaseModel
    {
        public int TripId { get; set; }

        public int FromCityId{ get; set; }

        public int ToCityId { get; set; }

        public City FromCity { get; set; }

        public City ToCity { get; set; }

        public DateTime TripDate { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public double Price { get; set; }

        public string Platform { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}