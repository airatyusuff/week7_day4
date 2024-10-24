using week7_day4;

namespace Tests
{
    public class NonResidentialTests
    {
        TaxBands calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new NonResidentialTaxBands().Create();
        }

        [Test]
        public void Test_NonResidentialPropertyHasTaxBandA()
        {
            double taxPrice = calculator.CalculateTax(250000);

            Assert.That(taxPrice, Is.EqualTo(1000));
        }

        [Test]
        public void Test_NonResidentialPropertyHasHighestTaxBand()
        {
            double taxPrice = calculator.CalculateTax(465000);

            Assert.That(taxPrice, Is.EqualTo(11750));
        }
    }
}