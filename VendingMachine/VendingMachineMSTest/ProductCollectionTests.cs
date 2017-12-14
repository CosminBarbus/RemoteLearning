using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingMachineMSTest
{
    [TestClass]
    public class ProductCollectionTests
    {
        [TestMethod]
        public void adding_a_product_to_collection_is_successfull()
        {
            var products = new ProductCollection();
            var product = new Product();
            products.Add(product);
        }

        [TestMethod]
        public void adding_8_products_to_collection_count_is_returning_8()
        {
            var products = new ProductCollection();
            var product = new Product();
            products.Add(product);
            products.Add(product);
            products.Add(product);
            products.Add(product);
            products.Add(product);
            products.Add(product);
            products.Add(product);
            products.Add(product);


            Assert.AreEqual(8, products.Count());
        }
    }
}
