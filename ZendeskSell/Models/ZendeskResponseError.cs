using System;
using Newtonsoft.Json;

namespace ZendeskSell.Models
{
    public class ZendeskResponseError
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("error_description")]
        public string Description { get; set; }
        [JsonProperty("error_uri")]
        public Uri Uri { get; set; }
    }

}