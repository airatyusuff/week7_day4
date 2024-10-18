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
        private CalculatorTypes calculatorType;

        public TaxCalculator() {
            bands = new ResidentialTaxBands().CreateTaxBands();
            calculatorType = CalculatorTypes.RESIDENTIAL;
        }
        public TaxCalculator(CalculatorTypes type)
        {
            switch (type)
            {
                case CalculatorTypes.NON_RESIDENTIAL:
                    bands = new NonResidentialTaxBands().CreateTaxBands();
                    calculatorType = CalculatorTypes.NON_RESIDENTIAL;
                    break;
                default:
                    bands = new ResidentialTaxBands().CreateTaxBands();
                    calculatorType = CalculatorTypes.RESIDENTIAL;
                    break;
            }
        }

        public double CalculateTax(double price)
        {
            double totalTax = 0;

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
