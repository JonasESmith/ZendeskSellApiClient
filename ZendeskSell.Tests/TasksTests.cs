using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZendeskSell.Models;
using ZendeskSell.Tasks;

namespace ZendeskSell.Tests
{
    public class TasksTests
    {
        private IZendeskSellClient Client;

        [SetUp]
        public void Setup()
        {
            Client = new ZendeskSellClient(Constants.AccessToken);
        }

        [Test]
        public async Task Test_CreateTask()
        {
            var testTaskData = new TaskRequest()
            {
                ResourceID = 283694398,
                ResourceType = "contact",
                OwnerID = Constants.OwnerID,
                Content = "Test task",
                DueDate = DateTimeOffset.UtcNow.AddDays(7),
                RemindAt = DateTimeOffset.UtcNow.AddDays(3)
            };
            var response = await Client.Tasks.CreateAsync(testTaskData);
            Assert.IsNotNull(response);
            Assert.IsNull(response.Errors);
            Assert.IsNotNull(response.Data);
        }
    }
}
