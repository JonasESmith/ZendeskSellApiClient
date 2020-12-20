using System;
using RestSharp;
using Zendesk.Contacts;
using Zendesk.Deals;
using Zendesk.Leads;
using Zendesk.LineItems;
using Zendesk.Orders;
using Zendesk.Products;
using Zendesk.Tasks;

namespace Zendesk
{
    public class ZendeskSellClient : IZendeskSellClient
  {
        private readonly string _authorizationString;
        private readonly string _baseUrl = "https://api.getbase.com/v2";
        private readonly RestClient _client;

        /// <summary>
        /// Object Constructor for Zendesk Item!
        /// </summary>
        public ZendeskSellClient(string accessToken)
        {
            _client = new RestClient(_baseUrl);
            _client
                .AddDefaultHeader("Authorization", $"Bearer {accessToken}")
                .AddDefaultHeader("Accept", "application/json")
                .AddDefaultHeader("Content-Type", "application/json");
        }

        public IContactActions Contacts => new ContactActions(_client);

        public IDealActions Deals => new DealActions(_client);

        public ILeadActions Leads => new LeadActions(_client);

        public ILineItemActions LineItems => new LineItemActions(_client);

        public IOrderActions Orders => new OrderActions(_client);

        public IProductActions Products => new ProductActions(_client);

        public ITaskActions Tasks => new TaskActions(_client);
  }
}
