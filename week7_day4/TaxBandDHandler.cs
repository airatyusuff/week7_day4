using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxBandDHandler : IBandHandler
    {
        private IBandHandler NextBandHandler;
        private double MinLimit = 750000;
        private double TaxRate = 0.12;

        public void SetSuccessor(IBandHandler h)
        {
            NextBandHandler = h;
        }

        public double CalculateTax(double price, double sum)
        {
            return sum + TaxRate * (price - MinLimit);
        }
    }
}
