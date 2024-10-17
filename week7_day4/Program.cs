
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
            TaxCalculator calculator = new TaxCalculator();

            double pptyPrice = 875000;
            double tax = calculator.CalculateTax(pptyPrice);

            Console.WriteLine("The total tax for property of price " + pptyPrice + " is: " + tax );
        }
    }
}
