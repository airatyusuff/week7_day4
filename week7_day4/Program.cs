
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
            //TaxCalculator calculator = new TaxCalculator(CalculatorTypes.NON_RESIDENTIAL);

            double pptyPrice = 465000;
            double tax = calculator.CalculateTax(pptyPrice);

            Console.WriteLine(calculator.GetCalcType() + " TAX CALCULATOR");
            Console.WriteLine("The total tax for property of price " + pptyPrice + " is: " + tax);
        }
    }
}
