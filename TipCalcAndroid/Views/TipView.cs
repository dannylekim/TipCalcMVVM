﻿using Android.App;
using MvvmCross.Droid.Views;
using TipCalcAndroid;

namespace TipCalcAndroid
{
    [Activity(Label = "Tip")]
    public class TipView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Tip);
        }
    }
}