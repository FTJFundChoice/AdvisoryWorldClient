using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvisoryWorldClient.Model.Base
{
    public class BaseResponse {
        [JsonProperty("time")]
        public long time { get; set; }
        [JsonProperty("paging")]
        public Paging paging { get; set; }
    }
}
