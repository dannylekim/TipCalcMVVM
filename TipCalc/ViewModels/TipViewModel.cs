﻿
using System;
using System.Windows.Input;
using MvvmCross.Core.Platform;
using MvvmCross.Core.ViewModels;
using TipCalc.Services;

namespace TipCalc.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        readonly ICalculation _calculation;

        public TipViewModel(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            Recalculate();
            base.Start();
        }

        double _subTotal;

        public double SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; RaisePropertyChanged(() => SubTotal); Recalculate(); }
        }

        int _generosity;

        public int Generosity
        {
            get { return _generosity; }
            set { _generosity = value; RaisePropertyChanged(() => Generosity); }

        }

        double _tip;
        public double Tip
        {
            get { return _tip;}
            set { _tip = value; RaisePropertyChanged(() => Tip); }
        }

        void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Generosity);
        }

        public ICommand GoCommand => new MvxCommand(() => ShowViewModel<SecondViewModel>());

    }
  
}
