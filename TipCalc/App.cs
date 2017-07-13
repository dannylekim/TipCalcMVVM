using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using TipCalc.Services;
using TipCalc.ViewModels;

namespace TipCalc
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
        }
    }
}
