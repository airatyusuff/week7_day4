using week7_day4;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_PropertyShouldReturnPrice()
        {
            var ppty = new Property(130000);
            double price = ppty.GetPrice();

            Assert.IsTrue(price == 130000);
        }

        [Test]
        public void Test_HasNoTax()
        {
            var calculator = new TaxCalculator();
            double taxPrice = calculator.CalculateTax(130000);

            Assert.IsTrue(taxPrice == 0);
        }

        [Test]
        public void Test_PropertyHasTaxBandA()
        {
            var calculator = new TaxCalculator();
            double taxPrice = calculator.CalculateTax(200000);

            Console.WriteLine(taxPrice);
            Assert.That(taxPrice, Is.EqualTo(1100));
        }
    }
}