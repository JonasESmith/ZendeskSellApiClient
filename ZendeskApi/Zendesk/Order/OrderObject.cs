using System;

namespace Zendesk.Order
{
  /// <summary>
  /// All the information returned from zendesk about an order
  /// </summary>
  public class OrderObject
  {
    public OrderMeta meta { get; set; }
    public OrderData data { get; set; }
  }

  public class OrderMeta
  {
    public string type { get; set; }
  }

  public class OrderData
  {
    public int id { get; set; }
    public int deal_id { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime created_at { get; set; }
    public int discount { get; set; }
  }
}
