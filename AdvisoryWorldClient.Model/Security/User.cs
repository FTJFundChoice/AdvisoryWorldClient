using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.Model.Security {
    public class User : Base.BaseResponse {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

    }
}
