using NUnit.Framework;
using VendingMachine;
using VendingMachineMSTest;

namespace VendingMachineTests
{
    [TestFixture]
    public class ProductCollectionTests
    {
        [Test]
        public void adding_a_product_to_collection_is_successfull()
        {
            var products = new ProductCollection();
            var product = new Product();
            products.Add(product);
        }
    }
}
