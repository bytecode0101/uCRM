using NUnit.Framework;
using System;
using Ucrm;

namespace TestUcrm
{
    [TestFixture]
    public class TestCart
    {
        [Test]
        public void TestAddProduct()
        {
            var userId = Guid.NewGuid();
            Product p = new Product();
            Cart cart = new Cart(userId);

            cart.AddProduct(p, 10);

            Assert.AreEqual(10, cart.Items[p.Id]);
        }
    }
}
