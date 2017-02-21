using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.Model {
    public class ModelSaveAllAssets {
        [JsonProperty("id")]
        public int ModelSaveAllAssetsId { get; set; }
        [JsonProperty("name")]
        public string ModelSaveAllAssetsName { get; set; }
        [JsonProperty("ratio")]
        public decimal Ratio { get; set; }
    }
}
