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
        private CalculatorTypes calculatorType;

        public TaxCalculator() {
            bandsFactory = new ResidentialTaxBands();
            calculatorType = CalculatorTypes.RESIDENTIAL;
        }
        public TaxCalculator(CalculatorTypes type)
        {
            switch (type)
            {
                case CalculatorTypes.NON_RESIDENTIAL:
                    bandsFactory = new NonResidentialTaxBands();
                    calculatorType = CalculatorTypes.NON_RESIDENTIAL;
                    break;
                default:
                    bandsFactory = new ResidentialTaxBands();
                    calculatorType = CalculatorTypes.RESIDENTIAL;
                    break;
            }
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

        public CalculatorTypes GetCalcType()
        {
            return calculatorType;
        }
    }
}
