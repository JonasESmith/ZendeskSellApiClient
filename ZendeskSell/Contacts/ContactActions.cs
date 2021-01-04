using System.Threading.Tasks;
using RestSharp;
using RestSharp.Validation;
using ZendeskSell.Models;

namespace ZendeskSell.Contacts
{
    public class ContactActions : IContactActions
    {
        private readonly RestClient _client;

        public ContactActions(RestClient client)
        {
            _client = client;
        }

        public async Task<ZendeskSellObjectResponse<ContactResponse>> CreateAsync(ContactRequest contact)
        {
            Require.Argument("LastName", contact.ProspectStatus);
            Require.Argument("CustomerStatus", contact.CustomerStatus);
            Require.Argument("ProspectStatus", contact.ProspectStatus);
            var request = new RestRequest("contacts", Method.POST) { RequestFormat = DataFormat.Json };
            var body = new ZendeskSellRequest<ContactRequest>() { Data = contact };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(body);
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<ContactResponse>>(request)).Data;
        }

        public async Task<ZendeskSellCollectionResponse<ContactResponse>> GetAsync(int pageNumber, int numPerPage)
        {
            var request = new RestRequest("https://api.getbase.com/v2/contacts", Method.GET)
                              .AddParameter("page", pageNumber)
                              .AddParameter("per_page", numPerPage);
            return (await _client.ExecuteGetTaskAsync<ZendeskSellCollectionResponse<ContactResponse>>(request)).Data;
        }
    }
}
