using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxCalculator
    {
        private TaxBandsFactory bandsFactory;

        public TaxCalculator(TaxBandsFactory factory) {
            bandsFactory = factory;
        }

        public double CalculateTax(double price)
        {
            double totalTax = 0;
            List<ITaxBand> bands = bandsFactory.GetBands();

            foreach (ITaxBand band in bands) {
                totalTax += band.Calculate(price);
            }

            return totalTax;
        }
    }
}
