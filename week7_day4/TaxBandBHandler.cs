using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxBandBHandler : IBandHandler
    {
        private IBandHandler NextBandHandler;
        private double MinLimit = 250000;
        private double MaxLimit = 325000;

        private double TaxRate = 0.05;
        private double TaxBand = 75000;

        public void SetSuccessor(IBandHandler h)
        {
            NextBandHandler = h;
        }

        public double CalculateTax(double price, double sum)
        {
            if (price > MinLimit && price < MaxLimit) {
                return sum + TaxRate * (price - MinLimit);
            }

            double cumulativeTax = sum + MaxTax();
            return NextBandHandler.CalculateTax(price, cumulativeTax);
        }

        private double MaxTax()
        {
            return TaxRate * TaxBand;
        }
    }
}
