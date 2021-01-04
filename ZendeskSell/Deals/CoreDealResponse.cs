using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ZendeskSell.Deals
{
    public class CoreDealResponse : DealByOwnerRequest
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        [JsonProperty("loss_reason_id")]
        public object LossReasonID { get; set; }
        [JsonProperty("unqualified_reason_id")]
        public object UnqualifiedReasonID { get; set; }
        [JsonProperty("estimated_close_date")]
        public DateTimeOffset EstimatedCloseDate { get; set; }
        [JsonProperty("custom_fields")]
        public DealCustomFields CustomFields { get; set; }
    }
}
