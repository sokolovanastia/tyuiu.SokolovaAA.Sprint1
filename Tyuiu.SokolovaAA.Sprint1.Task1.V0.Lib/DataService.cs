﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SokolovaAA.Sprint1.Task1.V0.Lib
{
    public class DataService : ISprint1Task1V28
    {
        public double Calculate(double x)
        {
            return (x * 2) / (1 + x);
        }
    }
}
