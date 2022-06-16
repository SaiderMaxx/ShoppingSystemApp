using ShoppingSystemApp;

namespace ShoppingSystemTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ProductNameLenghtMustBeBetweenTheRangeOf3to30()
        {
            string name = "Dress";
            double price = 15; 

            Product product = new Product(name, price);

            Assert.IsTrue(name.Length > 3 && name.Length < 30);
        }
        [Test]
        public void ProductPriceMustBeZeroOrPossitive()
        {
            string name = "Dress";
            double price = 100;
            Product product = new Product(name, price);
            
            Assert.IsTrue(price > 0);
        }
    }
}