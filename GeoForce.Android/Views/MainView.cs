using Android.App;
using Android.OS;
using GeoForce.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace GeoForce.Android.Views
{
    [Activity(Label = "MainView", MainLauncher =true)]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.MainView);
        }
    }
}