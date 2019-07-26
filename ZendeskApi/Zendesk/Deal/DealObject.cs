using System;

namespace Zendesk.Deal
{
  /// <summary>
  /// Deal object that will contain all information that Zendesk will keep on the object
  /// </summary>
  public class DealObject
  {
    public DealData data { get; set; }
    public DealMeta meta { get; set; }
  }

  public class DealData
  {
    public string id { get; set; }
    public string creator_id { get; set; }
    public string owner_id { get; set; }
    public string name { get; set; }
    public string value { get; set; }
    public string currency { get; set; }
    public bool hot { get; set; }
    public string stage_id { get; set; }
    public DateTime last_stage_change_at { get; set; }
    public string last_stage_change_by_id { get; set; }
    public DateTime last_activity_at { get; set; }
    public string source_id { get; set; }
    public object loss_reason_id { get; set; }
    public object unqualified_reason_id { get; set; }
    public string dropbox_email { get; set; }
    public string contact_id { get; set; }
    public string organization_id { get; set; }
    public object estimated_close_date { get; set; }
    public string[] tags { get; set; }
    public DealCustom_Fields custom_fields { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
  }

  public class DealCustom_Fields
  {
    public string website { get; set; }
  }

  public class DealMeta
  {
    public string type { get; set; }
  }
}
