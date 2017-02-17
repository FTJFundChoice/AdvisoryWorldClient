using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvisoryWorldClient.Model {
    public class ModelSaveAll {
        [JsonProperty("default")]
        public bool Default { get; set; }
        [JsonProperty("id")]
        public int ModelSaveAllId { get; set; }
        [JsonProperty("name")]
        public string ModelSaveAllName { get; set; }
        [JsonProperty("parentId")]
        public int ParentId { get; set; }
        [JsonProperty("platformGroupId")]
        public int PlatformGroupId { get; set; }
        [JsonProperty("targetRiskScoreMax")]
        public int TargetRiskScoreMax { get; set; }
        [JsonProperty("targetRiskScoreMin")]
        public int TargetRiskScoreMin { get; set; }
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }
        [JsonProperty("type")]
        public bool Type { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("assets")]
        public List<ModelSaveAllAssets> Assets;
    }
}
