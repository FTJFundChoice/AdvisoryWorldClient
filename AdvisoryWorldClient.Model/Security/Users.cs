using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvisoryWorldClient.Model.Security
{
    public class Users {
        [JsonProperty("items")]
        public List<User> items { get; set; }
    }
}
