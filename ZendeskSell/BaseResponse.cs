using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zendesk
{
    public class BaseResponse<T, T1>
        where T : class
        where T1 : class
    {
        [JsonProperty("base")]
        public T Base { get; set; }

        [JsonProperty("meta")]
        public T1 Meta { get; set; }
    }
}
