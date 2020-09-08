using LoveTrips.Core.Services;
using LoveTrips.Core.ViewModels;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;

namespace LoveTrips.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            try
            {
                CreatableTypes().EndingWith("Repository")
                    .AsInterfaces().RegisterAsLazySingleton();

                CreatableTypes().EndingWith("Service")
                    .AsInterfaces().RegisterAsLazySingleton();

                RegisterCustomAppStart<AppStart>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
