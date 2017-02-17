using Newtonsoft.Json;

namespace AdvisoryWorldClient.Model.Theme
{
    public class Colors {
        public Colors() {
            Theme = new ThemeColors();
            Text = new TextColors();
            BarChart = new BarChartColors();
            Background = new BackgroundColors();
        }
        [JsonProperty("theme")]
        public ThemeColors Theme { get; set; }
        [JsonProperty("text")]
        public TextColors Text { get; set; }
        [JsonProperty("barChart")]
        public BarChartColors BarChart { get; set; }
        [JsonProperty("background")]
        public BackgroundColors Background { get; set; }
    }
}
