using MvvmCross;
using MvvmCross.ViewModels;
using LoveTrips.Core.Services;
using LoveTrips.Core.ViewModels;

namespace LoveTrips.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();
            RegisterAppStart<TipViewModel>();
        }
    }
}
