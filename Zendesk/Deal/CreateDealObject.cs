using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.Deal
{
  /// <summary>
  /// A simple object for the information needed to create a new Deal in Zendesk
  /// </summary>
  public class CreateDealObject
  {
    public CreateDealObject()
    {
      data = new AddDealData();
      meta = new AddDealMeta();
    }

    public AddDealData data { get; set; }
    public AddDealMeta meta { get; set; }
  }

  public class AddDealData
  {
    public AddDealData()
    {
      custom_fields = new Add_Custom_Fields();
    }

    public string name { get; set; }
    public string value { get; set; }
    public bool hot { get; set; }

    public int stage_id { get; set; }
    public int source_id { get; set; }
    public int contact_id { get; set; }
    public string[] tags { get; set; }
    public Add_Custom_Fields custom_fields { get; set; }
  }

  public class Add_Custom_Fields
  {
    public string website { get; set; }
  }

  public class AddDealMeta
  {
    public string type { get; set; }
  }
}