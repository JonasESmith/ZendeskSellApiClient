using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.Order
{
  public class ReturnOrderObject
  {
    public OrderObject[] items { get; set; }
    public ReturnOrderMeta meta { get; set; }
  }

  public class ReturnOrderMeta
  {
    public int count { get; set; }
    public string type { get; set; }
    public ReturnOrderLinks links { get; set; }
  }

  public class ReturnOrderLinks
  {
    public string self { get; set; }
  }

  public class ReturnOrderItem
  {
    public ReturnOrderMeta1 meta { get; set; }
    public ReturnOrderData data { get; set; }
  }

  public class ReturnOrderMeta1
  {
    public string type { get; set; }
  }

  public class ReturnOrderData
  {
    public int id { get; set; }
    public int deal_id { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime created_at { get; set; }
    public int discount { get; set; }
  }

}
