using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk.Products
{
  public class NewProductObject
  {
    public NewProductObject()
    {
      data = new NewProductData();
      meta = new NewProductMeta();
    }

    public NewProductData data { get; set; }
    public NewProductMeta meta { get; set; }
  }

  public class NewProductData
  {

    public string name { get; set; }
    public string sku { get; set; }
    public string description { get; set; }
    public bool active { get; set; }
    public NewProductPrice[] prices { get; set; }
    public string cost { get; set; }
    public string cost_currency { get; set; }
    public int max_discount { get; set; }
  }

  public class NewProductPrice
  {
    public NewProductPrice(string passed_amount, string passed_currency)
    {
      amount = passed_amount;
      currency = passed_currency;
    }

    public string amount { get; set; }
    public string currency { get; set; }
  }

  public class NewProductMeta
  {
    public string type { get; set; }
  }
}
