﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalsagovUA.Sprint1.Task4.V22.Lib
{
    public class DataService : ISprint1Task4V22
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Sqrt(x * y)) / (1 + (x + 2 * y) * (x + 2 * y));
            return res;
        }
    }
}