using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FTJFundChoice.AdvisoryWorldClient.Model.Security
{
    public class UserCredentials
    {
        [JsonProperty("userCredential")]
        public List<UserCredential> Credentials { get; set; }

        public UserCredentials()
        {
            Credentials = new List<UserCredential>();
        }
    }
}
