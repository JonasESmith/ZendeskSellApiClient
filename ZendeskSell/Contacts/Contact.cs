using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZendeskSell.Models;

namespace ZendeskSell.Contacts
{
    public class ContactRequest
    {
        public ContactRequest()
        {
            Tags = new string[] { };
            Address = ShippingAddress = BillingAddress = new Address();
            CustomFields = new ContactCustomFields();
        }
		[JsonProperty("owner_id")]
		public int? OwnerID { get; set; }
		[JsonProperty("is_organization")]
		public bool IsOrganization { get; set; }
        [JsonProperty("contact_id")]
        public int ContactID { get; set; }
		[JsonProperty("parent_organization_id")]
		public int? ParentOrganizationID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
		[JsonProperty("customer_status")]
		public string CustomerStatus { get; set; }
		[JsonProperty("prospect_status")]					   
		public string ProspectStatus { get; set; }
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
        public string Linkedin { get; set; }
        [JsonProperty("skype")]
        public string Skype { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
		[JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }
		[JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }
        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
        [JsonProperty("custom_fields")]
        public ContactCustomFields CustomFields { get; set; }
    }

    public class ContactResponse : ContactRequest
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("creator_id")]
        public int CreatorID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public class ContactCustomFields
    {
        [JsonProperty("referral_website")]
        public string ReferralWebsite { get; set; }
		[JsonProperty("known_via")]
		public string KnownVia { get; set; }
    }
}
