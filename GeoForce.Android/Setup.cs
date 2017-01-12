using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace GeoForce.Android
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) 
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}