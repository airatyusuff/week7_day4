using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxCalculator
    {
        public TaxCalculator() {
        }

        public double CalculateTax(double price)
        {
            double p = price / 1000;

            Console.WriteLine(p);

            if(p > 145 && p < 250)
            {
                return 0.02 * (p - 145) * 1000;
            }
            return 0;
        }
    }
}
