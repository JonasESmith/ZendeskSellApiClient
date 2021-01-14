using System;
using Newtonsoft.Json;

namespace ZendeskSell.Tasks
{

  public class TaskRequest
  {
        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }
        [JsonProperty("resource_id")]
        public int ResourceID { get; set; }
        [JsonProperty("owner_id")]
        public int OwnerID { get; set; }
        [JsonProperty("due_date")]
        public DateTimeOffset DueDate { get; set; }
        [JsonProperty("remind_at")]
        public DateTimeOffset RemindAt { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
  }
}
