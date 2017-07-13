using Android.App;
using MvvmCross.Droid.Views;
using TipCalcAndroid;

namespace TipCalcAndroid
{
    [Activity(Label = "Second")]
    public class SecondModel : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.SecondViewModel);
        }
    }
}