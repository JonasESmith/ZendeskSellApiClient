using RestSharp;
using Zendesk.LineItems;

namespace Zendesk.Orders
{
    public class OrderActions : IOrderActions
    {
        private RestClient _client;

        public OrderActions(RestClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Gets the order associated with the Deal ID passed and returns a json string
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        public string GetByDealID(string dealID)
        {
            var request = new RestRequest("orders", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("deal_id", dealID);
            var response = _client.Execute(request);
            return response.Content;
        }

        /// <summary>
        /// Creates order based on the newOrderObject passed with the a dealID
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public string Create(NewOrderObject order)
        {
            var request = new RestRequest("orders", Method.POST) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(order);
            var response = _client.Execute(request);
            return response.Content;
        }


        /// <summary>
        /// Takes a lineItem object and will add it to an order with the corresponding orderId passed returns json string of the results
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="lineItem"></param>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public string AddLineItem(LineItemObject lineItem, string orderID)
        {
            var request = new RestRequest($"orders/{orderID}/line_items", Method.POST)
            { RequestFormat = DataFormat.Json, JsonSerializer = new RestSharpJsonNetSerializer() };
            request.AddJsonBody(lineItem);

            var response = _client.Execute(request);
            return response.Content;
        }
    }
}