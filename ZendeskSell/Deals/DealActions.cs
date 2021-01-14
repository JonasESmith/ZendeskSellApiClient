using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Validation;
using ZendeskSell.Models;

namespace ZendeskSell.Deals
{
    public class DealActions : IDealActions
    {
        private RestClient _client;

        public DealActions(RestClient client)
        {
            _client = client;
        }

        public async Task<ZendeskSellObjectResponse<DealResponse>> GetAsync(int dealID)
        {
            var request = new RestRequest($"deals/{dealID}");
            return (await _client.ExecuteGetTaskAsync<ZendeskSellObjectResponse<DealResponse>>(request)).Data;
        }


        public async Task<ZendeskSellCollectionResponse<DealResponse>> GetByNameAsync(string dealName)
        {
            var request = new RestRequest($"deals?name={dealName}");
            return (await _client.ExecuteGetTaskAsync<ZendeskSellCollectionResponse<DealResponse>>(request)).Data;
        }

        /// <summary>
        /// Takes a CreateDealObject  Object and Posts it to Zendesk will return a json String
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="deal"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<DealResponse>> CreateAsync(DealRequest deal)
        {
            Require.Argument("ContactID", deal.ContactID);
            Require.Argument("Hot", deal.Hot);
            Require.Argument("Name", deal.Name);
            Require.Argument("Value", deal.Value);
            Require.Argument("StageID", deal.StageID);
            var request = new RestRequest("deals") { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(new ZendeskSellRequest<DealRequest>(deal));
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<DealResponse>>(request)).Data;
        }


        /// <summary>
        /// Takes an ojbect CreateDealObjectWOwner that allows us to use an Owner Id for the deal created.
        /// </summary>
        /// <param name="deal"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<DealResponse>> CreateAsync(DealByOwnerRequest deal)
        {
            Require.Argument("ContactID", deal.ContactID);
            Require.Argument("OwnerID", deal.OwnerID);
            Require.Argument("Hot", deal.Hot);
            Require.Argument("Name", deal.Name);
            Require.Argument("Value", deal.Value);
            Require.Argument("StageID", deal.StageID);
            var request = new RestRequest("deals") { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(new ZendeskSellRequest<DealByOwnerRequest>(deal));
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<DealResponse>>(request)).Data;
        }

        /// <summary>
        /// Create a UpdateDealObject and pass it all the variables from the original deal only updating the values you want to update form the original
        /// this will return a json String
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="updatedDeal"></param>
        /// <param name="dealID"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<DealResponse>> UpdateAsync(int dealID, DealResponse updatedDeal)
        {
            // BH: Needed to convert to base class: https://stackoverflow.com/a/20557095/418297
            var updatedDealAsBase = JsonConvert.DeserializeObject<CoreDealResponse>(JsonConvert.SerializeObject(updatedDeal));
            var request = new RestRequest($"deals/{dealID}", Method.PUT) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(new ZendeskSellRequest<CoreDealResponse>(updatedDealAsBase));
            return (await _client.ExecuteTaskAsync< ZendeskSellObjectResponse<DealResponse>>(request)).Data;
        }
    }
}