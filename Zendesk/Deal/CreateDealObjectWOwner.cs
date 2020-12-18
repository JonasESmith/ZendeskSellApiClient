using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.Deal
{
  /// <summary>
  /// A simple object for the information needed to create a new Deal in Zendesk
  /// </summary>
  public class CreateDealObjectWOwner
  {
    public CreateDealObjectWOwner()
    {
      data = new AddDealOwnerData();
      meta = new AddDealMeta();
    }

    public AddDealOwnerData data { get; set; }
    public AddDealMeta meta { get; set; }
  }

  public class AddDealOwnerData
  {
    public AddDealOwnerData()
    {
      custom_fields = new Add_Custom_Fields();
    }

    public int    owner_id { get; set; }
    public string name     { get; set; }
    public string value    { get; set; }
    public bool   hot      { get; set; }

    public int      stage_id   { get; set; }
    public int      source_id  { get; set; }
    public int      contact_id { get; set; }
    public string[] tags       { get; set; }

    public Add_Custom_Fields custom_fields { get; set; }
  }
}