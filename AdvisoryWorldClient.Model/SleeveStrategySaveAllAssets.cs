
using Newtonsoft.Json;

namespace AdvisoryWorldClient.Model {
    public class SleeveStrategySaveAllAssets {
        [JsonProperty("allocation")]
        public decimal Allocation { get; set; }
        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }
}
