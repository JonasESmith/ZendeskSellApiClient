using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.Contacts
{
  public class ContactObject
  {
    public Contact_Data data { get; set; }
  }

  public class Contact_Data
  {
    public int contact_id { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
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
    public Contact_Address address { get; set; }
    public string[] tags { get; set; }
    public Contact_Custom_Fields custom_fields { get; set; }
  }

  public class Contact_Address
  {
    public string line1 { get; set; }
    public string city { get; set; }
    public string postal_code { get; set; }
    public string state { get; set; }
    public string country { get; set; }
  }

  public class Contact_Custom_Fields
  {
    public string referral_website { get; set; }
  }

}
