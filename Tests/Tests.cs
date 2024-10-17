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
        public void Test_PropertyHasNoTax()
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

            Assert.That(taxPrice, Is.EqualTo(1100));
        }

        [Test]
        public void Test_PropertyHasTaxBandB()
        {
            var calculator = new TaxCalculator();
            double taxPrice = calculator.CalculateTax(302000);

            Assert.That(taxPrice, Is.EqualTo(4700));
        }

        [Test]
        public void Test_PropertyHasTaxBandC()
        {
            var calculator = new TaxCalculator();
            double taxPrice = calculator.CalculateTax(750000);

            Assert.That(taxPrice, Is.EqualTo(48350));
        }

        [Test]
        public void Test_PropertyHasTaxBandD()
        {
            var calculator = new TaxCalculator();
            double taxPrice = calculator.CalculateTax(875000);

            Assert.That(taxPrice, Is.EqualTo(63350));
        }
    }
}