﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalc.Services
{
    public interface ICalculation
    {
        double TipAmount(double subTotal, int generosity);
    }
}
