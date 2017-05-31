using Newtonsoft.Json;


namespace FTJFundChoice.AdvisoryWorldClient.RestApiCalls
{
    public class RestGetResponse
    {
        [JsonProperty("success")]
        public string Success { get; set; }
    }
}
