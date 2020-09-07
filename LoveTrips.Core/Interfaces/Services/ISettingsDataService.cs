using System.Collections.Generic;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface ISettingsDataService
    {
        List<Currency> GetCurrencies();
        Currency GetActiveCurrency();
        void SetActiveCurrency(Currency currency);
        string GetAboutContent();
    }
}