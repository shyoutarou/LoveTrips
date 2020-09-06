using LoveTrips.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveTrips.Core.Repositories
{
    class TipRepository : ITipRepository
    {
        private static readonly List<Tip> AllTips = new List<Tip>
        {
            new Tip
            {
                subTotal = 10,
                generosity = 2
            },
            new Tip
            {
                subTotal = 11000,
                generosity = 50
            },
        };

        public async Task<List<Tip>> GetAllTips()
        {
            return await Task.FromResult(AllTips);
        }

        public async Task<Tip> GetTipBySubTotal(float subtotal)
        {
            return await Task.FromResult(AllTips.FirstOrDefault(c => c.subTotal == subtotal));
        }
    }
}
