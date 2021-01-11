using System;
using Newtonsoft.Json;

namespace ZendeskSell.Leads
{
    public class LeadResponse : LeadRequest
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("creator_id")]
        public int CreatorID { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("custom_fields")]
        public ZenLeadCustomFields CustomFields { get; set; }
    }

    public class ZenLeadCustomFields
    {
        [JsonProperty("known_via")]
        public string KnownVia { get; set; }
    }
}
