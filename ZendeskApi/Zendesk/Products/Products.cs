/// Simple Product class to make it easy to import products from zendesk when the application is ran.

using System;

namespace Zendesk.Products
{
  public class Products
  {
    public ProductItem[] items { get; set; }
    public ProductMeta meta { get; set; }
  }

  public class ProductMeta
  {
    public int count { get; set; }
    public string type { get; set; }
    public ProductLinks links { get; set; }
  }

  public class ProductLinks
  {
    public string self { get; set; }
    public string next_page { get; set; }
  }

  public class ProductItem
  {
    public ProductMeta1 meta { get; set; }
    public ProductData data { get; set; }
  }

  public class ProductMeta1
  {
    public string type { get; set; }
  }

  public class ProductData
  {
    public int id { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime created_at { get; set; }
    public bool active { get; set; }
    public string description { get; set; }
    public string name { get; set; }
    public string sku { get; set; }
    public ProductPrice[] prices { get; set; }
    public object max_discount { get; set; }
    public object max_markup { get; set; }
    public object cost { get; set; }
    public object cost_currency { get; set; }
  }

  public class ProductPrice
  {
    public string currency { get; set; }
    public string amount { get; set; }
  }
}