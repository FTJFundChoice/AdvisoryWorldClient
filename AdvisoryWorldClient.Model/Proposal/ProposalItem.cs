using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvisoryWorldClient.Model.Proposal
{
    public class ProposalItem {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("accounts")]
        public int Accounts { get; set; }
        [JsonProperty("value")]
        public long Value { get; set; }
        [JsonProperty("dateCreated")]
        public DateTime? DateCreated { get; set; }
        [JsonProperty("dateUpdated")]
        public DateTime? DateUpdated { get; set; }
    }
}
