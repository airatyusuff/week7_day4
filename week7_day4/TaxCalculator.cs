using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxCalculator
    {
        private IBandHandler NoTaxBand;
        private IBandHandler TaxBandA;
        private IBandHandler TaxBandB;
        private IBandHandler TaxBandC;
        private IBandHandler TaxBandD;

        public TaxCalculator() {
            NoTaxBand = new TaxNoBandHandler();
            TaxBandA = new TaxBandAHandler();
            TaxBandB = new TaxBandBHandler();
            TaxBandC = new TaxBandCHandler();
            TaxBandD = new TaxBandDHandler();

            NoTaxBand.SetSuccessor(TaxBandA);
            TaxBandA.SetSuccessor(TaxBandB);
            TaxBandB.SetSuccessor(TaxBandC);
            TaxBandC.SetSuccessor(TaxBandD);
        }

        public double CalculateTax(double price)
        {
            return NoTaxBand.CalculateTax(price, 0);
        }
    }
}
