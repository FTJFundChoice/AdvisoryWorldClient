using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvisoryWorldClient.Model.Proposal
{
    public class ProposalItems: Base.BaseResponse {
        [JsonProperty("items")]
        public List<ProposalItem> items { get; set; }
    }
}
