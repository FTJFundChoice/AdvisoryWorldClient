
using Newtonsoft.Json;

namespace AdvisoryWorldClient.Model.Security
{
    public class UserCredentialWrapper
    {
        public UserCredential userCredential { get; set; }

        public UserCredentialWrapper()
        {
            userCredential = new UserCredential();
        }
       
    }

    public class  EditedUserCredentialWrapper
    {
        public UserCredential editedUserCredential { get; set; }

        public EditedUserCredentialWrapper()
        {
            editedUserCredential = new UserCredential();
        }
    }

    public class CreatedUserCredentialWrapper
    {
        public UserCredential createdUserCredential { get; set; }

        public CreatedUserCredentialWrapper()
        {
            createdUserCredential = new UserCredential();
        }
    }

    public class UserCredential
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("userCredentialId")]
        public string UserCredentialId { get; set; }
    }

}
