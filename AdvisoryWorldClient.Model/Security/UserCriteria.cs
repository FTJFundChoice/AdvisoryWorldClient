using System;
using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.Model.Security
{
    public class UserCriteria
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UserCriteriaWrapper
    {
        [JsonProperty("criteria")]
        public UserCriteria userCriteria { get; set; }
    }
}
