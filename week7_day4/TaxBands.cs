using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxBands
    {
        private List<ITaxBand> taxBands;
        private BandsTypes bandType;

        public TaxBands(List<ITaxBand> taxBands, BandsTypes bandType)
        {
            this.taxBands = taxBands;
            this.bandType = bandType;
        }

        public double CalculateTax(double price)
        {
            double totalTax = 0;

            foreach (ITaxBand band in taxBands)
            {
                totalTax += band.Calculate(price);
            }

            return totalTax;
        }

        public BandsTypes GetBandType() { return bandType; }
    }
}
