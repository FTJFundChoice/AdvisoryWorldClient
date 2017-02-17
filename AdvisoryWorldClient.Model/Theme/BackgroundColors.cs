using Newtonsoft.Json;

namespace AdvisoryWorldClient.Model.Theme
{
    public class BackgroundColors {
        [JsonProperty("coverPage")]
        public string CoverPage { get; set; }
        [JsonProperty("gradient")]
        public string Gradient { get; set; }
        [JsonProperty("level1")]
        public string Level1 { get; set; }
        [JsonProperty("level2")]
        public string Level2 { get; set; }
        [JsonProperty("level3")]
        public string Level3 { get; set; }
        [JsonProperty("tableHeader")]
        public string TableHeader { get; set; }
    }
}
