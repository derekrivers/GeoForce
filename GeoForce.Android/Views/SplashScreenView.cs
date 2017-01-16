using Android.App;
using MvvmCross.Droid.Views;
using Android.OS;
using Android.Widget;

namespace GeoForce.Android.Views
{
    [Activity(Label = "GeoForce", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenView  
        : MvxSplashScreenActivity
    {

        private ImageView imageView;

        public SplashScreenView()
            : base(Resource.Layout.SplashScreen)
        {
           
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //imageView = FindViewById<ImageView>(Resource.Id.imageView);
           
         
        }

        protected override void OnStart()
        {
            base.OnStart();

        }

        protected override void OnStop()
        {
            base.OnStop();

        }

    }
}