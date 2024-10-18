using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxBandWithLimits : ITaxBand
    {
        private BandParamsStruct BandDetails;

        public TaxBandWithLimits(double minLimit, double maxLimit, double taxRate)
        {
            BandDetails = new BandParamsStruct(minLimit, maxLimit, taxRate);
        }

        public double Calculate(double price)
        {
            if (IsPptyWithinBand(price)) {
                return CalculateBandTax(price);
            }

            if (PptyExceedsCurrentBand(price)) {
                return MaxBandTax(); 
            }

            return 0;
        }

        private double MaxBandTax()
        {
            return BandDetails.TaxRate * BandDetails.TaxBand;
        }

        private bool IsPptyWithinBand(double pptyPrice)
        {
            return pptyPrice > BandDetails.MinLimit && pptyPrice <= BandDetails.MaxLimit;
        }

        private bool PptyExceedsCurrentBand(double pptyPrice)
        {
            return pptyPrice > BandDetails.MaxLimit;
        }

        private double CalculateBandTax(double pptyPrice)
        {
            return BandDetails.TaxRate * (pptyPrice - BandDetails.MinLimit);
        }
    }
}
