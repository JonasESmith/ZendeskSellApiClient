using System;

namespace Zendesk.Lead
{
  /// <summary>
  /// Simple object for Created leads to be posted to Zendesk
  /// </summary>
  public class CreateLeadObject
  {
    public CreateLeadObject()
    {
      meta = new CreateLead_Meta();
    }

    public CreateLead_Item[] items { get; set; }
    public CreateLead_Meta meta { get; set; }
  }

  public class CreateLead_Meta
  {
    public CreateLead_Meta()
    {
      links = new CreateLead_links();
    }

    public string type { get; set; }
    public int count { get; set; }
    public CreateLead_links links { get; set; }
  }

  public class CreateLead_links
  {
    public string self { get; set; }
  }

  public class CreateLead_Item
  {
    public CreateLead_Data data { get; set; }
    public CreateLead_Meta1 meta { get; set; }
  }

  public class CreateLead_Data
  {
    public int id { get; set; }
    public int creator_id { get; set; }
    public int owner_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string organization_name { get; set; }
    public string status { get; set; }
    public int source_id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string industry { get; set; }
    public string website { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string mobile { get; set; }
    public string fax { get; set; }
    public string twitter { get; set; }
    public string facebook { get; set; }
    public string linkedin { get; set; }
    public string skype { get; set; }
    public CreateLead_Address address { get; set; }
    public string[] tags { get; set; }
    public CreateLeadCustom_Fields custom_fields { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
  }

  public class CreateLead_Address
  {
    public string line1 { get; set; }
    public string city { get; set; }
    public string postal_code { get; set; }
    public string state { get; set; }
    public string country { get; set; }
  }

  public class CreateLeadCustom_Fields
  {
    public string known_via { get; set; }
  }

  public class CreateLead_Meta1
  {
    public string type { get; set; }
  }
}