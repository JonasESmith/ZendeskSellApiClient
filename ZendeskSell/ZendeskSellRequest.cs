using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ZendeskSell
{
    public class ZendeskSellRequest<T>
        where T : class
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
