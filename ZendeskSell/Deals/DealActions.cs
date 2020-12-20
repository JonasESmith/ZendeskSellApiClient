using RestSharp;
using Zendesk.Deal;

namespace Zendesk.Deals
{
    public class DealActions : IDealActions
    {
        private RestClient _client;

        public DealActions(RestClient client)
        {
            _client = client;
        }

        public string Get(string dealID)
        {
            var request = new RestRequest($"deals/{dealID}", Method.GET);
            var response = _client.Execute(request);
            return response.Content;
        }


        public string GetByName(string dealName)
        {
            var request = new RestRequest($"deals?name={dealName}", Method.GET);
            var response = _client.Execute(request);
            return response.Content;
        }

        /// <summary>
        /// Takes a CreateDealObject  Object and Posts it to Zendesk will return a json String
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="deal"></param>
        /// <returns></returns>
        public string Create(CreateDealObject deal)
        {
            var request = new RestRequest("deals", Method.POST) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(deal);
            var reponse = _client.Execute(request);
            return reponse.Content;
        }


        /// <summary>
        /// Takes an ojbect CreateDealObjectWOwner that allows us to use an Owner Id for the deal created.
        /// </summary>
        /// <param name="deal"></param>
        /// <returns></returns>
        public string Create(CreateDealObjectWOwner deal)
        {
            var request = new RestRequest("deals", Method.POST) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(deal);
            var reponse = _client.Execute(request);
            return reponse.Content;
        }

        /// <summary>
        /// Create a UpdateDealObject and pass it all the variables from the original deal only updating the values you want to update form the original
        /// this will return a json String
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="updatedDeal"></param>
        /// <param name="dealID"></param>
        /// <returns></returns>
        public string Update(UpdateDealObject updatedDeal, string dealID)
        {
            var request = new RestRequest($"deals/{dealID}", Method.PUT) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(updatedDeal);
            var response = _client.Execute(request);
            return response.Content;
        }
    }
}