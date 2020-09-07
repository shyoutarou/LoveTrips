using System;

namespace LoveTrips.Core.Model.App
{
    public class SearchParameters
    {
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
        public DateTime TripDate { get; set; }
        public string DepartureTime { get; set; }
    }
}