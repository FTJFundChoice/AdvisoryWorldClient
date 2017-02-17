using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvisoryWorldClient.Model {
    public class SleeveStrategySaveAll {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("default")]
        public bool Default { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("targetRiskScoreMin")]
        public decimal TargetRiskScoreMin { get; set; }
        [JsonProperty("targetRiskScoreMax")]
        public decimal TargetRiskScoreMax { get; set; }
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("assets")]
        public List<SleeveStrategySaveAllAssets> Assets { get; set; }
    }
}
