using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxCalculator
    {
        private IBandHandler StarterTaxBand;

        public TaxCalculator() {
            StarterTaxBand = new TaxNoBandHandler();
            IBandHandler TaxBandD = new TaxBandDHandler();

            TaxBandWithLimitsHandler TaxBandA = new TaxBandWithLimitsHandler(145000, 250000, 0.02);
            TaxBandWithLimitsHandler TaxBandB = new TaxBandWithLimitsHandler(250000, 325000, 0.05);
            TaxBandWithLimitsHandler TaxBandC = new TaxBandWithLimitsHandler(325000, 750000, 0.1);

            StarterTaxBand.SetSuccessor(TaxBandA);
            TaxBandA.SetSuccessor(TaxBandB);
            TaxBandB.SetSuccessor(TaxBandC);
            TaxBandC.SetSuccessor(TaxBandD);
        }

        public double CalculateTax(double price)
        {
            return StarterTaxBand.CalculateTax(price, 0);
        }
    }
}
