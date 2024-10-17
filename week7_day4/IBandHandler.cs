using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public interface IBandHandler
    {
        public void SetSuccessor(IBandHandler h);
        public double CalculateTax(double price, double cumulativeTax);
    }
}
