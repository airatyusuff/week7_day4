
namespace week7_day4
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        private void Run()
        {
            //ResidentialTaxBands TaxBands = new ResidentialTaxBands();

            TaxBands TaxBands = new NonResidentialTaxBands().Create();

            double pptyPrice = 465000;
            double tax = TaxBands.CalculateTax(pptyPrice);

            Console.WriteLine(TaxBands.GetBandType() + " TAX CALCULATOR");
            Console.WriteLine("The total tax for property of price " + pptyPrice + " is: " + tax);
        }
    }
}
