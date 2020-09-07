using LoveTrips.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface ITipService
    {
        double NormalTipAmount(Tip tip);
        Task<List<Tip>> GetAllTips();
        Task<Tip> GetTipById(int cityId);
    }
}
