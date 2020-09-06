using LoveTrips.Core.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoveTrips.Core.Services
{
    public class TipService : ITipService
    {
        public double NormalTipAmount(Tip tip)
        {
            return tip.subTotal * tip.generosity / 100.0;
        }

        public Task<List<Tip>> GetAllTips()
        {
            throw new NotImplementedException();
        }

        public Task<Tip> GetTipById(int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
