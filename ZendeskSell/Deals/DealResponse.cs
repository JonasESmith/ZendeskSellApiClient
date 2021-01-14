using System;
using Newtonsoft.Json;

namespace ZendeskSell.Deals
{
    public class DealResponse : CoreDealResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("creator_id")]
        public int CreatorID { get; set; }
        [JsonProperty("organization_id")]
        public int OrganizationID { get; set; }
        [JsonProperty("last_stage_change_at")]
        public DateTimeOffset LastStageChangeAt { get; set; }
        [JsonProperty("last_stage_change_by_id")]
        public string LastStageChangeByID { get; set; }
        [JsonProperty("dropbox_email")]
        public string DropboxEmail { get; set; }
        [JsonProperty("last_activity_at")]
        public DateTimeOffset LastActivityAt { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
  }
}
