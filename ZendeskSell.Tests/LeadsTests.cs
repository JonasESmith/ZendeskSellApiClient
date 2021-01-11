using System.Threading.Tasks;
using NUnit.Framework;
using ZendeskSell.Leads;

namespace ZendeskSell.Tests
{
    public class LeadsTests
    {
        private IZendeskSellClient Client;

        [SetUp]
        public void Setup()
        {
            Client = new ZendeskSellClient(Constants.AccessToken);
        }

        [Test]
        public async Task Test_CreateLead()
        {
            var testLead = new LeadRequest()
            {
                OwnerID = Constants.OwnerID,
                FirstName = "Jamie",
                LastName = "Howarth",
                Email = "hello@jamiehowarth.me"
            };
            var response = await Client.Leads.CreateAsync(testLead);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }
    }
}
