using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using ZendeskSell.Deals;

namespace ZendeskSell.Tests
{
    public class DealsTests
    {
        private IZendeskSellClient Client;
        private int testContactID;

        [SetUp]
        public async Task Setup()
        {
            Client = new ZendeskSellClient(Constants.AccessToken);
            testContactID = (await Client.Contacts.GetAsync(1, 100)).Items.First().Data.ID;
        }

        [Test]
        public async Task Test_CreateDeal()
        {
            var newDeal = new DealRequest()
            {
                ContactID = testContactID,
                Hot = true,
                Name = "Test deal",
                Value = 100.00f,
                StageID = 10557469
            };
            var response = await Client.Deals.CreateAsync(newDeal);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        public async Task Test_CreateDealByOwner()
        {
            var newDeal = new DealByOwnerRequest()
            {
                OwnerID = 2051801,
                ContactID = testContactID,
                Hot = true,
                Name = "Test deal with owner",
                Value = 100.00f,
                StageID = 10557469
            };
            var response = await Client.Deals.CreateAsync(newDeal);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        public async Task Test_GetDeal()
        {
            var response = await Client.Deals.GetAsync(81434754);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        public async Task Test_GetDealByName()
        {
            var response = await Client.Deals.GetByNameAsync("Acme Co Sales Opportunity");
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Items);
            Assert.IsNotEmpty(response.Items);
        }
        
        [Test]
        public async Task Test_UpdateDeal()
        {
            var existingDeal = (await Client.Deals.GetByNameAsync("Acme Co Sales Opportunity")).Items.First().Data;
            existingDeal.Value = 50.0f;
            var response = await Client.Deals.UpdateAsync(existingDeal.ID, existingDeal);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }
    }
}
