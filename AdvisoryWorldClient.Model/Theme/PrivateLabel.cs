using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.Model.Theme {
    public class PrivateLabel {
        public PrivateLabel() {
            Colors = new Colors();
            Info = new CompanyInformation();
        }
        [JsonProperty("colors")]
        public Colors Colors { get; set; }
        [JsonProperty("info")]
        public CompanyInformation Info { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
    }
}
