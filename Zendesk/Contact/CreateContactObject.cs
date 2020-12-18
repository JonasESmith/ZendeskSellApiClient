namespace Zendesk.Contact
{
  /// <summary>
  /// Simples object that is used to pass important information to zendesk
  /// </summary>
  public class CreateContactObject
  {
    public CreateContactObject()
    {
      data = new CreateObjcetData();
    }
    public CreateObjcetData data { get; set; }
  }

  public class CreateObjcetData
  {
    public CreateObjcetData()
    {
      address = new CreateObjcetAddress();
      custom_fields = new CreateObjcetCustom_Fields();
    }

    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string industry { get; set; }
    public string website { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public CreateObjcetAddress address { get; set; }
    public string[] tags { get; set; }
    public CreateObjcetCustom_Fields custom_fields { get; set; }
  }

  public class CreateObjcetAddress
  {
    public string line1 { get; set; }
    public string city { get; set; }
    public string postal_code { get; set; }
    public string state { get; set; }
    public string country { get; set; }
  }

  public class CreateObjcetCustom_Fields
  {
    public string referral_website { get; set; }
  }
}
