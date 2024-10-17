using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxNoBandHandler : IBandHandler
    {
        private IBandHandler NextBandHandler;
        private double MaxLimit = 145000;

        public void SetSuccessor(IBandHandler successor)
        {
            NextBandHandler = successor;
        }

        public double CalculateTax(double price, double _)
        {
            if (price < MaxLimit) {
                return 0;
            }

            return NextBandHandler.CalculateTax(price, 0);
        }
    }
}
