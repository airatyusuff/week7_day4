using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class ResidentialTaxBands : ITaxBandsFactory
    {
        public TaxBands Create()
        {
            ITaxBand HighestTaxBand = new HighestTaxBand(750000, 0.12);
            ITaxBand TaxBandA = new TaxBandWithLimits(145000, 250000, 0.02);
            ITaxBand TaxBandB = new TaxBandWithLimits(250000, 325000, 0.05);
            ITaxBand TaxBandC = new TaxBandWithLimits(325000, 750000, 0.1);


            return new TaxBands(
                [TaxBandA, TaxBandB, TaxBandC, HighestTaxBand], 
                BandsTypes.RESIDENTIAL);
        }
    }
}
