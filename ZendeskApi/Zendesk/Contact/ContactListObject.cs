using System;

namespace Zendesk.Contact
{

  public class ContactListObject
  {
    public ContactListItem[] items { get; set; }
    public ContactListMeta meta { get; set; }
  }

  public class ContactListMeta
  {
    public string type { get; set; }
    public int count { get; set; }
    public ContactListLinks links { get; set; }
  }

  public class ContactListLinks
  {
    public string self { get; set; }
  }

  public class ContactListItem
  {
    public ContactListData data { get; set; }
    public ConstactListMeta1 meta { get; set; }
  }

  public class ContactListData
  {
    public int id { get; set; }
    public int creator_id { get; set; }
    public int owner_id { get; set; }
    public bool is_organization { get; set; }
    public int? contact_id { get; set; }
    public int? parent_organization_id { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string customer_status { get; set; }
    public string prospect_status { get; set; }
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
    public ContactListAddress address { get; set; }
    public object billing_address { get; set; }
    public object shipping_address { get; set; }
    public string[] tags { get; set; }
    public ContactListCustom_Fields custom_fields { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
  }

  public class ContactListAddress
  {
    public string line1 { get; set; }
    public string city { get; set; }
    public string postal_code { get; set; }
    public string state { get; set; }
    public string country { get; set; }
  }

  public class ContactListCustom_Fields
  {
    public string known_via { get; set; }
  }

  public class ConstactListMeta1
  {
    public string type { get; set; }
  }

}
