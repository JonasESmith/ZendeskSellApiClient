using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.LineItem
{
  /// <summary>
  /// The information pulled from Zendesk about a line item
  /// </summary>
  public class LineItemObject
  {
    public LineItemObject() {
      data = new LineItemData();
      meta = new LineItemMeta();
    }
    public LineItemData data { get; set; }
    public LineItemMeta meta { get; set; }
  }

  public class LineItemData
  {
    public int    product_id { get; set; }
    public string value      { get; set; }
    public string currency   { get; set; }
    public string variation  { get; set; }
    public int    quantity   { get; set; }
  }

  public class LineItemMeta
  {
    public string type { get; set; }
  }
}
