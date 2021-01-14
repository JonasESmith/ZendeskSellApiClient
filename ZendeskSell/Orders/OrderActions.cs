using System.Threading.Tasks;
using RestSharp;
using ZendeskSell.LineItems;
using ZendeskSell.Models;

namespace ZendeskSell.Orders
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
        public async Task<ZendeskSellObjectResponse<OrderResponse>> GetByDealIDAsync(int dealID)
        {
            var request = new RestRequest("orders") { RequestFormat = DataFormat.Json };
            request.AddParameter("deal_id", dealID);
            return (await _client.ExecuteGetTaskAsync<ZendeskSellObjectResponse<OrderResponse>>(request)).Data;
        }

        /// <summary>
        /// Creates order based on the newOrderObject passed with the a dealID
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<OrderResponse>> CreateAsync(OrderRequest order)
        {
            var request = new RestRequest("orders") { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(new ZendeskSellRequest<OrderRequest>(order));
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<OrderResponse>>(request)).Data;
        }


        /// <summary>
        /// Takes a lineItem object and will add it to an order with the corresponding orderId passed returns json string of the results
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="lineItem"></param>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<OrderResponse>> AddLineItemAsync(LineItemData lineItem, int orderID)
        {
            var request = new RestRequest($"orders/{orderID}/line_items")
            { RequestFormat = DataFormat.Json, JsonSerializer = new RestSharpJsonNetSerializer() };
            request.AddJsonBody(lineItem);
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<OrderResponse>>(request)).Data;
        }
    }
}