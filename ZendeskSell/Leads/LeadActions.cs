using System.Threading.Tasks;
using RestSharp;
using ZendeskSell.Models;

namespace ZendeskSell.Leads
{
    public class LeadActions : ILeadActions
    {
        private RestClient _client;

        public LeadActions(RestClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates a new lead with the passed CreateLeadObject associated with this method and returns a json string
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<LeadResponse>> CreateAsync(LeadRequest lead)
        {
            var request = new RestRequest("leads") { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(new ZendeskSellRequest<LeadRequest>(lead));
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<LeadResponse>>(request)).Data;
        }
    }
}