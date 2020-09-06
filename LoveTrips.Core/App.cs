using MvvmCross;
using MvvmCross.ViewModels;
using LoveTrips.Core.Services;
using LoveTrips.Core.ViewModels;
using MvvmCross.IoC;

namespace LoveTrips.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //// Construct custom application start object
            //Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();

            //// request a reference to the constructed appstart object 
            //var appStart = Mvx.IoCProvider.Resolve<IMvxAppStart>();

            //// register the appstart object
            //RegisterAppStart(appStart);

            //RegisterAppStart<TipViewModel>();


            // register the appstart object
            RegisterCustomAppStart<AppStart>();
        }
    }
}
