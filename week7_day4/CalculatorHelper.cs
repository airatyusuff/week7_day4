using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace week7_day4
{
    public class CalculatorHelper
    {
        private BandParamsStruct args;

        public CalculatorHelper(double minLimit, double maxLimit, double taxRate, double cumulativeTax, double maxTax)
        {
            args = new BandParamsStruct(minLimit, maxLimit, taxRate, maxTax, cumulativeTax);
        }

        public bool IsPptyWithinBand(double pptyPrice)
        {
            return pptyPrice > args.MinLimit && pptyPrice < args.MaxLimit;
        }

        public double CalculateCurrentTax(double pptyPrice)
        {
            return args.CumulativeTax + args.TaxRate * (pptyPrice - args.MinLimit);
        }
    }
}
