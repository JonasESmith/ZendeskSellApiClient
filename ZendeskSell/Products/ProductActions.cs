using RestSharp;

namespace Zendesk.Products
{
    public class ProductActions : IProductActions
    {
        private RestClient _client;

        public ProductActions(RestClient client)
        {
            _client = client;
        }

        public string Get(int pageNumber, int numPerPage)
        {
            var request = new RestRequest("products", Method.GET)
                              .AddParameter("page", pageNumber)
                              .AddParameter("per_page", numPerPage);
            var response = _client.Execute(request);
            return response.Content;
        }

        /// <summary>
        /// Creates a product associate with the object passed withit.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public string Create(NewProductObject product)
        {

            var request = new RestRequest("products", Method.POST) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(product);
            var response = _client.Execute(request);
            return response.Content;
        }
    }
}