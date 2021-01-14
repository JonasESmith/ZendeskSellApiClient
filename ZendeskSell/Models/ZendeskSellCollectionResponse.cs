using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZendeskSell.Models
{
    public class ZendeskSellCollectionResponse<T>
        where T : class
    {
        [JsonProperty("items")]
        public IEnumerable<ZendeskSellObjectResponse<T>> Items { get; set; }

        [JsonProperty("meta")]
        public ZendeskResponseMetadata Meta { get; set; }

        [JsonProperty("errors")]
        public IEnumerable<ZendeskResponseError> Errors { get; set; }
    }
}
