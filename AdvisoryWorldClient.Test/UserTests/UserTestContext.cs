using FTJFundChoice.AdvisoryWorldClient.Compositions;
using FTJFundChoice.AdvisoryWorldClient.Model.Security;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;
using FTJFundChoice.AdvisoryWorldClient.Test._base;
using System.Configuration;
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
            var testedValue = ConfigurationManager.AppSettings["UserId"];
            var derp = new UserCredentialWrapper()
            {
                userCredential = new UserCredential
                {
                    UserId = testedValue,
                    Name = ConfigurationManager.AppSettings["Name"],
                    Value = ConfigurationManager.AppSettings["Value"],
                    UserCredentialId= ConfigurationManager.AppSettings["UserCredentialId"]
                }
            };

            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var um = new UserModule(client);
            var result = await um.UpdateExistingUserCredentials(derp);
            Assert.NotNull(result);
            Assert.NotNull(result.editedUserCredential);
            Assert.Equal(result.editedUserCredential.UserId, testedValue);

        }

        [Fact]
        public async void ShouldCreateUsersSixDigitAdvisorCode()
        {

            var testedValue = ConfigurationManager.AppSettings["UserId"];
            var derp = new UserCredentialWrapper()
            {
                userCredential = new UserCredential
                {
                    UserId = testedValue,
                    Name = ConfigurationManager.AppSettings["Name"],
                    Value = ConfigurationManager.AppSettings["Value"]
                }
            };

            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var um = new UserModule(client);
            var result = await um.CreateNewUserCredentials(derp);
            Assert.NotNull(result);
            Assert.NotNull(result.createdUserCredential);
            Assert.Equal(result.createdUserCredential.UserId, testedValue);

        }


        [Fact]
        public async void GetAllUsersBasedOnAdvisorCode()
        {
            var name = ConfigurationManager.AppSettings["Name"];

            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var um = new UserModule(client);
            var result = await um.GetUserCredentialList(name);
            Assert.NotNull(result);

        }

        [Theory]
        [InlineData("userId=1234")]
        public async void GetUserContextBecauseSeaboltIsAmazing(string usrId)
        {
            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var um = new UserModule(client);
            var result = await um.GetUserCredentialList(usrId);
            Assert.NotNull(result);
            Assert.NotEmpty(result.Credentials);
        }

    }
}
