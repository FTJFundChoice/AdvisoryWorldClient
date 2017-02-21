using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.RestApiCalls
{
    public class RestPostResponse
    {
        [JsonProperty("success")]
        public string Success { get; set; }
    }
}
