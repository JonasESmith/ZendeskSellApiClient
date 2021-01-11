using System.Threading.Tasks;
using RestSharp;
using ZendeskSell.Models;

namespace ZendeskSell.Products
{
    public class ProductActions : IProductActions
    {
        private RestClient _client;

        public ProductActions(RestClient client)
        {
            _client = client;
        }

        public async Task<ZendeskSellCollectionResponse<ProductResponse>> GetAsync(int pageNumber, int numPerPage)
        {
            var request = new RestRequest("products")
                              .AddParameter("page", pageNumber)
                              .AddParameter("per_page", numPerPage);
            return (await _client.ExecuteGetTaskAsync<ZendeskSellCollectionResponse<ProductResponse>>(request)).Data;
        }

        /// <summary>
        /// Creates a product associate with the object passed withit.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<ProductResponse>> CreateAsync(ProductRequest product)
        {
            var request = new RestRequest("products") { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(product);
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<ProductResponse>>(request)).Data;
        }
    }
}