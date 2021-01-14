using System;
using Newtonsoft.Json;

namespace ZendeskSell.Orders
{

    public class OrderResponse : OrderRequest
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
