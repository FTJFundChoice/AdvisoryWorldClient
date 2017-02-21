using FTJFundChoice.AdvisoryWorldClient.Compositions;
using FTJFundChoice.AdvisoryWorldClient.Model.Security;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;
using FTJFundChoice.AdvisoryWorldClient.Test._base;
using System.IO;
using Xunit;


namespace AdvisoryWorldClient.Test.UserTests
{
    [Collection("Users")]
    public class UserTestContext : TestBase
    {

        [Fact]
        public async void ShouldUpdateUsersSixDigitAdvisorCode()
        {
            var derp = new UserCredentialWrapper()
            {
                userCredential = new UserCredential
                {
                    UserId = "18849",
                    UserCredentialId = "14646",
                    Name = "FTJ.advisorCode",
                    Value = "123456"
                }
            };

            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var um = new UserModule(client);
            var result = await um.UpdateExistingUserCredentials(derp);
            Assert.NotNull(result);
            Assert.NotNull(result.editedUserCredential);
            Assert.Equal(result.editedUserCredential.UserId, "18849");

        }

    }
}
