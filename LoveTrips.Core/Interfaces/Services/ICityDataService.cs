using System.Collections.Generic;
using System.Threading.Tasks;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface ICityDataService
    {
        Task<List<City>> GetAllCities();

        Task<City> GetCityById(int cityId);
    }
}