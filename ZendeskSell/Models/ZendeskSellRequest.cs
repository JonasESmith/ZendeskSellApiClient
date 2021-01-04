using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ZendeskSell.Models
{
    public class ZendeskSellRequest<T>
        where T : class
    {
        public ZendeskSellRequest()
        {

        }

        public ZendeskSellRequest(T data) {
            Data = data;
        }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
