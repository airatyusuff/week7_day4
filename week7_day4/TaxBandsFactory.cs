using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day4
{
    public abstract class TaxBandsFactory
    {
        private List<ITaxBand> TaxBands;

        public TaxBandsFactory() {
            TaxBands = CreateTaxBands();
        }

        public List<ITaxBand> GetBands()
        {
            return TaxBands;
        }

        public abstract List<ITaxBand> CreateTaxBands();
    }
}
