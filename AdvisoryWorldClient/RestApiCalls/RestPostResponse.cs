using Newtonsoft.Json;

namespace AdvisoryWorldClient.RestApiCalls
{
    public class RestPostResponse
    {
        [JsonProperty("success")]
        public string Success { get; set; }
    }
}
