using System;
using System.Text;
using Newtonsoft.Json;

namespace ZendeskSell.Deals
{

    public class DealCustomFields
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }

    }
}