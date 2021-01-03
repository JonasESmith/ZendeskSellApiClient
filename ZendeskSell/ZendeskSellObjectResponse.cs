using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ZendeskSell.Models;

namespace ZendeskSell
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
