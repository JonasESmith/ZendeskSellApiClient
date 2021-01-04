using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZendeskSell.Deals
{
    public class DealRequest
    {
        public DealRequest()
        {
            Tags = new string[] { };
        }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public float Value { get; set; }
        [JsonProperty("hot")]
        public bool Hot { get; set; }
        [JsonProperty("stage_id")]
        public int StageID { get; set; }
        [JsonProperty("source_id")]
        public int SourceID { get; set; }
        [JsonProperty("contact_id")]
        public int ContactID { get; set; }
        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}