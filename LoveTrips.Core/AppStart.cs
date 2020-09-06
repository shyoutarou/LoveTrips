using LoveTrips.Core.Interfaces.Services;
using LoveTrips.Core.ViewModels;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
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
            if (_loginService.Login("shyo", "123"))
            {
                return NavigationService.Navigate<TipViewModel>();
            }
            else
            {
                return NavigationService.Navigate<LoginViewModel>();
            }
        }
    }
}
