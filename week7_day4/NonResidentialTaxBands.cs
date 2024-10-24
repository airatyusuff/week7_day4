using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class NonResidentialTaxBands : ITaxBandsFactory
    {
        public TaxBands Create()
        {
            ITaxBand HighestTaxBand = new HighestTaxBand(250000, 0.05);
            ITaxBand TaxBandA = new TaxBandWithLimits(150000, 250000, 0.01);

            return new TaxBands(
                [TaxBandA, HighestTaxBand],
                BandsTypes.NON_RESIDENTIAL);
        }
    }
}
