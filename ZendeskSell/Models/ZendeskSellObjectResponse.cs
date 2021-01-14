using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZendeskSell.Models
{
    public class ZendeskSellObjectResponse<T>
        where T : class
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("meta")]
        public ZendeskResponseMetadata Meta { get; set; }

        [JsonProperty("errors")]
        public IEnumerable<ZendeskResponseError> Errors { get; set; }
    }
}
