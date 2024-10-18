using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class HighestTaxBand : ITaxBand
    {
        private double MinLimit;
        private double TaxRate;

        public HighestTaxBand(double minLimit, double taxRate) {
            MinLimit = minLimit;
            TaxRate = taxRate;
        }

        public double Calculate(double price)
        {
            if (IsPptyWithinBand(price))
            {
                return TaxRate * (price - MinLimit);
            }
            return 0;
        }

        private bool IsPptyWithinBand(double pptyPrice)
        {
            return pptyPrice > MinLimit;
        }

    }
}
