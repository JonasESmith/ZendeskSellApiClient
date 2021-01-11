using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZendeskSell.Products;

namespace ZendeskSell.Tests
{
    public class ProductsTests
    {
        private IZendeskSellClient Client;

        [SetUp]
        public void Setup()
        {
            Client = new ZendeskSellClient(Constants.AccessToken);
        }

        [Test, Explicit("Needs testing against an Enterprise subscription")]
        public async Task Test_CreateProduct()
        {
            var product = new ProductRequest()
            {

            };
            var response = await Client.Products.CreateAsync(product);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }

        [Test, Explicit("Needs testing against an Enterprise subscription")]
        public async Task Test_GetProducts()
        {
            var response = await Client.Products.GetAsync(1, 100);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Items);
            Assert.IsNotEmpty(response.Items);
        }

    }
}
