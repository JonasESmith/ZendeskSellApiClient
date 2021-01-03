using NUnit.Framework;
using ZendeskSell;
using System.Threading.Tasks;

namespace ZendeskSell.Tests
{
    public class ContactTests
    {
        private IZendeskSellClient Client;

        [SetUp]
        public void Setup()
        {
            Client = new ZendeskSellClient(Constants.AccessToken);
        }

        [Test]
        public async Task Test_CreateContact()
        {
            var dummyContact = new Contacts.ContactRequest()
            {
                LastName = "Howarth",
                ProspectStatus = "current",
                CustomerStatus = "none"
            };
            var response = await Client.Contacts.CreateAsync(dummyContact);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
        }

        [Test]
        public async Task Test_GetContacts()
        {
            var response = await Client.Contacts.GetAsync(1, 100);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotEmpty(response.Items);
            Assert.IsNotNull(response.Meta);
        }
    }
}