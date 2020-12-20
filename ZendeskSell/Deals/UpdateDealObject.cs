using System;

namespace Zendesk.Deal
{
  public class UpdateDealObject {
    public UpdateDealObject() {
      data = new UpdateDealData();
    }
    public UpdateDealData data { get; set; }
  }

  public class UpdateDealData
  {
    public string   name                         { get; set; }
    public string   value                        { get; set; }
    public string   currency                     { get; set; }
    public int      owner_id                     { get; set; }
    public bool     hot                          { get; set; }
    public int      stage_id                     { get; set; }
    public DateTime last_stage_change_at         { get; set; }
    public int      source_id                    { get; set; }
    public object   loss_reason_id               { get; set; }
    public object   unqualified_reason_id        { get; set; }
    public int      contact_id                   { get; set; }
    public object   estimated_close_date         { get; set; }
    public string[] tags                         { get; set; }
    public DealCustom_Fields custom_fields       { get; set; }
  }
}