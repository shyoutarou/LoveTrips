using System.Collections.Generic;
using LoveTrips.Core.Interfaces.Repository;
using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Model;

namespace LoveTrips.Core.Services.Data
{
    public class SettingsDataService : ISettingsDataService
    {
        private readonly ISettingsRepository _settingsRepository;
        private Currency _activeCurrency;

        public SettingsDataService(ISettingsRepository settingsRepository)
        {
            _settingsRepository = settingsRepository;
        }

        public List<Currency> GetCurrencies()
        {
            return _settingsRepository.GetAvailableCurrencies();
        }

        public Currency GetActiveCurrency()
        {
            return _activeCurrency ?? (_activeCurrency = _settingsRepository.GetCurrencyById(1));
        }

        public void SetActiveCurrency(Currency currency)
        {
            _activeCurrency = currency;
        }

        public string GetAboutContent()
        {
            return _settingsRepository.GetAboutContent();
        }
    }
}