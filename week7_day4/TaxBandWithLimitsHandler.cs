using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class TaxBandWithLimitsHandler : IBandHandler
    {
        private BandParamsStruct BandDetails;
        private IBandHandler NextBandHandler;

        public TaxBandWithLimitsHandler(double minLimit, double maxLimit, double taxRate)
        {
            BandDetails = new BandParamsStruct(minLimit, maxLimit, taxRate);
        }

        public void SetSuccessor(IBandHandler successor)
        {
            NextBandHandler = successor;
        }

        public double CalculateTax(double price, double cumulativeTax)
        {
            if (IsPptyWithinBand(price)) {
                return CalculateBandTax(price, cumulativeTax);
            }

            double nextCumulativeTax = cumulativeTax + MaxBandTax();
            return NextBandHandler.CalculateTax(price, nextCumulativeTax);
        }

        private double MaxBandTax()
        {
            return BandDetails.TaxRate * BandDetails.TaxBand;
        }

        private bool IsPptyWithinBand(double pptyPrice)
        {
            return pptyPrice > BandDetails.MinLimit && pptyPrice < BandDetails.MaxLimit;
        }

        private double CalculateBandTax(double pptyPrice, double cumulativeTax)
        {
            return cumulativeTax + BandDetails.TaxRate * (pptyPrice - BandDetails.MinLimit);
        }
    }
}
