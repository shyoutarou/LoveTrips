using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.Model.App;
using LoveTrips.Core.ViewModels;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace LoveTrips.Core
{
    public class AppStart : MvxAppStart
    {
        private readonly ILoginService _loginService;

        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
                : base(app, mvxNavigationService)
        {
            _loginService = Mvx.IoCProvider.Resolve<ILoginService>();
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            try
            {
                if (_loginService.Login("shyo", "123"))
                {
                    var parameter = new DataParameter
                    {
                        journeyId = 1,
                        Name = "Alex"
                    };

                    return NavigationService.Navigate<TipViewModel>();
                }
                else
                {
                    return NavigationService.Navigate<LoginViewModel>();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
