using System.Collections.Generic;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Repository
{
    public interface ISettingsRepository
    {
        List<Currency> GetAvailableCurrencies();
        Currency GetCurrencyById(int currencyId);

        string GetAboutContent();
    }
}