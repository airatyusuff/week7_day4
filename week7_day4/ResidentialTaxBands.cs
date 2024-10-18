using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public class ResidentialTaxBands : ITaxBandsRegime
    {
        public List<ITaxBand> CreateTaxBands()
        {
            ITaxBand HighestTaxBand = new HighestTaxBand(750000, 0.12);
            ITaxBand TaxBandA = new TaxBandWithLimits(145000, 250000, 0.02);
            ITaxBand TaxBandB = new TaxBandWithLimits(250000, 325000, 0.05);
            ITaxBand TaxBandC = new TaxBandWithLimits(325000, 750000, 0.1);

            return [TaxBandA, TaxBandB, TaxBandC, HighestTaxBand];
        }
    }
}
