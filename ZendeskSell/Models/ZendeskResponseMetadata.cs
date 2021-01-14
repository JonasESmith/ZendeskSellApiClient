using Newtonsoft.Json;

namespace ZendeskSell.Models
{
    public class ZendeskResponseMetadata
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("links")]
        public ZendeskResponseLinkMetadata Links { get; set; }

    }

    public class ZendeskResponseLinkMetadata
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
