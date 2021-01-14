using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZendeskSell.Orders;

namespace ZendeskSell.Tests
{
    public class OrdersTests
    {
        private IZendeskSellClient Client;

        [SetUp]
        public void Setup()
        {
            Client = new ZendeskSellClient(Constants.AccessToken);
        }

        [Test, Explicit("Needs testing against an Enterprise subscription")]
        public async Task Test_GetOrderByDealID()
        {
            var dealId = 81434754;
            var response = await Client.Orders.GetByDealIDAsync(dealId);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }

        [Test, Explicit("Needs testing against an Enterprise subscription")]
        public async Task Test_CreateOrder()
        {
            var order = new OrderRequest()
            {
                Discount = 5,
                DealID = 81434754,
                OwnerID = Constants.OwnerID
            };
            var response = await Client.Orders.CreateAsync(order);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }
    }
}
