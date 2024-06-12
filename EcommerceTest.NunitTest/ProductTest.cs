using Ecommerce;

namespace EcommerceTest.NunitTest
{
    public class Tests
    {
        private Product product;

        [SetUp]
        public void Setup()
        {
            product = new Product(50, "Test Product", 100.77, 10);
        }

        [TestCase(1)]
        [TestCase(5000)]
        [TestCase(9999)]
        public void ProductId_Test(int value)
        {
            Assert.That(product.ProductID, Is.InRange(1, 10000));
        }

        [TestCase(1)]
        [TestCase(2405.9)]
        [TestCase(4500)]
        public void ProductPrice_Test(double value)
        {
            Assert.That(product.Price, Is.InRange(1, 5000));
        }

        [TestCase(" ")]
        [TestCase("Mobile")]
        [TestCase("Hair Drier")]
        public void ProductName_Test(string value)
        {
            Assert.NotNull(product.ProductName);
        }

        [TestCase(1)]
        [TestCase(5000)]
        [TestCase(9999)]
        public void ProductStock_Test(int value)
        {
            Assert.That(product.Stock, Is.InRange(1, 100000));
        }

        [TestCase(1)]
        [TestCase(5500)]
        [TestCase(9870)]
        public void IncreaseStock_Test(int value)
        {
            product.IncreaseStock(value);
            Assert.That(product.Stock, Is.InRange(1, 100000));
        }

        [TestCase(1)]
        [TestCase(580)]
        [TestCase(800)]
        public void DecreaseStock_Test(int value)
        {
            product = new Product(50, "Test Product", 100.77, 1000);
            product.DecreaseStock(value);
            Assert.That(product.Stock, Is.InRange(1, 100000));
        }
    }
}