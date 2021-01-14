/// Simple Product class to make it easy to import products from zendesk when the application is ran.

using System;
using Newtonsoft.Json;
using ZendeskSell.Models;

namespace ZendeskSell.Products
{
    public class ProductResponse : ProductRequest
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
        [JsonProperty("max_markup")]
        public string MaxMarkup { get; set; }
    }
}