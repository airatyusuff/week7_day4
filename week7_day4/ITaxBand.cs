﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public interface ITaxBand
    {
        public double Calculate(double price);
        // get band type from here
    }
}
