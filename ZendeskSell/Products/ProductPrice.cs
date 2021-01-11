using Newtonsoft.Json;

namespace ZendeskSell.Products
{
    public class ProductPrice
    {

        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
