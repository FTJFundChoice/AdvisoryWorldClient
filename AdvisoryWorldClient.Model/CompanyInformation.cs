using Newtonsoft.Json;

namespace AdvisoryWorldClient.Model {
    public class CompanyInformation {
        [JsonProperty("aboutCompany")]
        public string AboutCompany { get; set; }
        [JsonProperty("companyDisclosure")]
        public string CompanyDisclosure { get; set; }
        [JsonProperty("firmLogo")]
        public byte [] FirmLogo { get; set; }
        [JsonProperty("thumbnail")]
        public byte[] Thumbnail { get; set; }
        [JsonProperty("userImage")]
        public byte[] UserImage { get; set; }
    }
}
