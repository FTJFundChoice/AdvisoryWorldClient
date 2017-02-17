using Newtonsoft.Json;

namespace AdvisoryWorldClient.Model.Theme
{
    public class BarChartColors {
        [JsonProperty("color1")]
        public string Color1 { get; set; }
        [JsonProperty("color2")]
        public string Color2 { get; set; }
        [JsonProperty("color3")]
        public string Color3 { get; set; }
        [JsonProperty("color4")]
        public string Color4 { get; set; }
        [JsonProperty("color5")]
        public string Color5 { get; set; }

    }
}
