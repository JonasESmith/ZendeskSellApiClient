using RestSharp;

namespace Zendesk.Leads
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
        public string Create(CreateLeadObject lead)
        {
            var request = new RestRequest("leads", Method.POST) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(lead);
            var response = _client.Execute(request);
            return response.Content;
        }
    }
}