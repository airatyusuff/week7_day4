
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
            ResidentialTaxBands TaxBands = new ResidentialTaxBands();
            //NonResidentialTaxBands TaxBands = new NonResidentialTaxBands();

            TaxCalculator calculator = new TaxCalculator(TaxBands);

            double pptyPrice = 465000;
            double tax = calculator.CalculateTax(pptyPrice);

            Console.WriteLine(TaxBands.GetBandsType() + " TAX CALCULATOR");
            Console.WriteLine("The total tax for property of price " + pptyPrice + " is: " + tax);
        }
    }
}
