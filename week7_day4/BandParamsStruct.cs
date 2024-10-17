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
        public double CumulativeTax;

        public BandParamsStruct(double min, double max, double rate, double maxTax, double cTax)
        {
            MinLimit = min;
            MaxLimit = max;
            TaxRate = rate;
            MaxTax = maxTax;
            CumulativeTax = cTax;
        }
    }
}
