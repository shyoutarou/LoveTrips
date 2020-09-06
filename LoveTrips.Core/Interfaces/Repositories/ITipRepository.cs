using LoveTrips.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoveTrips.Core.Repositories
{
    public interface ITipRepository
    {
        Task<List<Tip>> GetAllTips();

        Task<Tip> GetTipBySubTotal(float subtotal);
    }
}
