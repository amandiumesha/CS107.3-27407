﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertkm02
{
    internal class ConvertValues
    {
        public void KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            Console.WriteLine(kilometers + " kilometers is equal to " + meters + " meters.");
        }
    }
}