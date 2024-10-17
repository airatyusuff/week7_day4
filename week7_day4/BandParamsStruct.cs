using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public struct BandParamsStruct
    {
        public double MinLimit;
        public double MaxLimit;
        public double TaxRate;
        public double MaxTax;
        public double TaxBand;

        public BandParamsStruct(double min, double max, double rate)
        {
            MinLimit = min;
            MaxLimit = max;
            TaxRate = rate;
            TaxBand = max - min;
            MaxTax = TaxRate * TaxBand;
        }
    }
}
