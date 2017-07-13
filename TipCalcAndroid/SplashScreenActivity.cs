using Android.App;
using MvvmCross.Droid.Views;


namespace TipCalcAndroid
{
    [Activity(Label = "SplashScreen", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
       public SplashScreenActivity() : base(Resource.Layout.SplashScreen)
        {

        }
    }
}