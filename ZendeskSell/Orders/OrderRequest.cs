using Newtonsoft.Json;

namespace ZendeskSell.Orders
{
    public class OrderRequest
    {
        [JsonProperty("owner_id")]
        public int OwnerID { get; set; }
        [JsonProperty("deal_id")]
        public int DealID { get; set; }
        [JsonProperty("discount")]

        public int Discount { get; set; }
    }
}
