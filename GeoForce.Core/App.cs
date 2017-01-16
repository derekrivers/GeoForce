using GeoForce.Core.Services;
using GeoForce.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace GeoForce.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            //Register Ioc Dependencie && AppStart.

            Mvx.ConstructAndRegisterSingleton<ILocationService, LocationService>();

            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}
