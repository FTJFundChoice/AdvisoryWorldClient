using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.Model.Theme
{
    public class TextColors {
        [JsonProperty("coverPage")]
        public string CoverPage { get; set; }
        [JsonProperty("level1Header")]
        public string Level1Header { get; set; }
        [JsonProperty("level2Header")]
        public string Level2Header { get; set; }
        [JsonProperty("level3Header")]
        public string Level3Header { get; set; }
        [JsonProperty("tableHeader")]
        public string TableHeader { get; set; }

    }
}
