using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZendeskSell.Models;

namespace ZendeskSell.Leads
{
    public class LeadRequest
    {
        public LeadRequest()
        {
            Tags = new string[] { };
            Address = new Address();
        }
        [JsonProperty("owner_id")]
        public int OwnerID { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("source_id")]
        public int SourceID { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("industry")]
        public string Industry { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        [JsonProperty("fax")]
        public string Fax { get; set; }
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
        [JsonProperty("facebook")]
        public string Facebook { get; set; }
        [JsonProperty("linkedin")]
        public string LinkedIn { get; set; }
        [JsonProperty("skype")]
        public string Skype { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }   
    }
}
