using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Repository
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCities();

        Task<City> GetCityById(int cityId);
    }
}
