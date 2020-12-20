using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.Orders
{
  public class NewOrderObject
  {
    public NewOrderObject()
    {
      data = new AddZendeskData();
      meta = new AddZendeskMeta();
    }

    public AddZendeskData data { get; set; }
    public AddZendeskMeta meta { get; set; }
  }

  public class AddZendeskData
  {
    public int deal_id { get; set; }
    public int discount { get; set; }
  }

  public class AddZendeskMeta
  {
    public string type { get; set; }
  }
}
