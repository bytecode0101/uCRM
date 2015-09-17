using NUnit.Framework;
using System;
using Ucrm;

namespace TestUcrm
{
    [TestFixture]
    public class TestOrder
    {
        [Test]
        public void TestSubmitOrder()
        {
            var userId = Guid.NewGuid();
            Product q = new Product();
            Cart cart = new Cart(userId);

            cart.AddProduct(q, 7);
            Order order = new Order(userId, cart.Items);
            Assert.AreEqual(7, order.Items[q.Id]);
        }
    }
}