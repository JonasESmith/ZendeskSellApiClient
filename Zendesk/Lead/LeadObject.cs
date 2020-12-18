using System;

namespace Zendesk.Lead
{
  public class LeadObject
  {
    public class ZenLeadItem
    {
      public ZenLeadData data { get; set; }
      public ZenLeadMeta1 meta { get; set; }
    }

    public class ZenLeadData
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
      public ZenLeadAddress address { get; set; }
      public string[] tags { get; set; }
      public ZenLeadCustomFields custom_fields { get; set; }
      public DateTime created_at { get; set; }
      public DateTime updated_at { get; set; }
    }

    public class ZenLeadAddress
    {
      public string line1 { get; set; }
      public string city { get; set; }
      public string postal_code { get; set; }
      public string state { get; set; }
      public string country { get; set; }
    }

    public class ZenLeadCustomFields
    {
      public string known_via { get; set; }
    }

    public class ZenLeadMeta1
    {
      public string type { get; set; }
    }

  }
}
