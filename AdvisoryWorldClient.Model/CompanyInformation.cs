using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.Model {
    public class CompanyInformation {
        [JsonProperty("aboutCompany")]
        public string AboutCompany { get; set; }
        [JsonProperty("companyDisclosure")]
        public string CompanyDisclosure { get; set; }
        [JsonProperty("firmLogo")]
        public byte [] FirmLogo { get; set; }
        [JsonProperty("thumbnail")]
        public byte[] Thumbnail { get; set; }

        // REMOVED FROM THE API PER ADVISORY WORLD CHANGES, BMS 12/05/2017
        //[JsonProperty("userImage")]
        //public byte[] UserImage { get; set; }
    }
}
