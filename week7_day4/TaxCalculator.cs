using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxCalculator
    {
        private List<ITaxBand> bands;

        public TaxCalculator() {
            bands = new ResidentialTaxBands().CreateTaxBands();
        }

        // need to add a factory method to create different bands

        public double CalculateTax(double price)
        {
            double totalTax = 0;

            foreach (ITaxBand band in bands) {
                totalTax += band.Calculate(price);
            }

            return totalTax;
        }

        public double CalculateTax(double price, List<ITaxBand> bands)
        {
            double totalTax = 0;
            foreach (ITaxBand band in bands)
            {
                totalTax += band.Calculate(price);
            }

            return totalTax;
        }
    }

    public enum CalculatorTypes { NON_RESIDENTIAL, RESIDENTIAL_WITH_DWELLING };
}
