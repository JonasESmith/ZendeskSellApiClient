using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.Contacts
{
    public class ContactActions : IContactActions
    {
        private readonly RestClient _client;

        public ContactActions(RestClient client)
        {
            _client = client;
        }

        public string Create(CreateContactObject contact)
        {
            var request = new RestRequest("contacts", Method.POST) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(contact);
            var response = _client.Execute(request);
            return response.Content;
        }

        public string Get(int pageNumber, int numPerPage)
        {
            var request = new RestRequest("https://api.getbase.com/v2/contacts", Method.GET)
                              .AddParameter("page", pageNumber)
                              .AddParameter("per_page", numPerPage);
            var response = _client.Execute(request);
            return response.Content;
        }
    }
}
