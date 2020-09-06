using LoveTrips.Core.Interfaces.Services;
using System;

namespace LoveTrips.Core.Services
{
    public class LoginService : ILoginService
    {
        public bool IsAuthenticated { get; private set; }
        public string ErrorMessage { get; private set; }

        public bool Login()
        {
            // get the stored username from previous sessions
            // var username = Settings.UserName;
            // var username = _settingsService.GetValue<string>(Constants.UserNameKey);

            // force return of false just for demo purposes
            IsAuthenticated = false;
            return IsAuthenticated;
        }

        public bool Login(string userName, string password, string scope)
        {
            try
            {
                //IsAuthenticated = _apiClient.ExchangeUserCredentialsForTokens(userName, password, scope);
                return IsAuthenticated;
            }
            catch (ArgumentException argex)
            {
                ErrorMessage = argex.Message;
                IsAuthenticated = false;
                return IsAuthenticated;
            }
        }

        public bool Login(string userName, string password)
        {
            // this simply returns true to mock a real login service call
            return true;
        }
    }
}
