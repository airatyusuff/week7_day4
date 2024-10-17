using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxBandCHandler : IBandHandler
    {
        private IBandHandler NextBandHandler;
        private double MinLimit = 325000;
        private double MaxLimit = 750000;

        private double TaxRate = 0.1;
        private double TaxBand = 425000;

        public void SetSuccessor(IBandHandler h)
        {
            NextBandHandler = h;
        }

        public double CalculateTax(double price, double cumulativeTax)
        {
            CalculatorHelper helper = new CalculatorHelper(MinLimit, MaxLimit, TaxRate, cumulativeTax, MaxBandTax());

            if (helper.IsPptyWithinBand(price))
            {
                return helper.CalculateCurrentTax(price);
            }

            double nextCumulativeTax = cumulativeTax + MaxBandTax();
            return NextBandHandler.CalculateTax(price, nextCumulativeTax);
        }

        private double MaxBandTax()
        {
            return TaxRate * TaxBand;
        }
    }
}
