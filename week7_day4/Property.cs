using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class Property
    {
        private double Price;
        public Property(double price) { 
            Price = price;
        }

        public double GetPrice() { return Price; }
    }
}
