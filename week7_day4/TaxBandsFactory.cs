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
        private BandsTypes bandsType;

        public TaxBandsFactory() {
            TaxBands = CreateTaxBands();
            bandsType = SetBandsType();
        }

        public List<ITaxBand> GetBands()
        {
            return TaxBands;
        }

        public BandsTypes GetBandsType()
        {
            return bandsType;
        }

        public abstract List<ITaxBand> CreateTaxBands();
        public abstract BandsTypes SetBandsType();
    }
}
