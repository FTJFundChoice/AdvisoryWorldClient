using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using FTJFundChoice.AdvisoryWorldClient.Interfaces;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;
using FTJFundChoice.AdvisoryWorldClient.Model.Security;

namespace FTJFundChoice.AdvisoryWorldClient.Compositions
{
    public class UserModule : IUserModule
    {
        private readonly IClient _client;

        public UserModule(IClient client)
        {
            _client = client;
        }

        public async Task<EditedUserCredentialWrapper> UpdateExistingUserCredentials(UserCredentialWrapper parameters)
        {
            var relativeUrl = "usercredential/editUserCredential";
            return await SubmitUserCredentialData<EditedUserCredentialWrapper>(relativeUrl, parameters);

        }

        public async Task<CreatedUserCredentialWrapper> CreateNewUserCredentials(UserCredentialWrapper parameters)
        {
            var relativeUrl = "usercredential/createUserCredential";
            return await SubmitUserCredentialData<CreatedUserCredentialWrapper>(relativeUrl, parameters);

        }

        public async Task<T> SubmitUserCredentialData<T>(string relativeUrl, UserCredentialWrapper parameters)
        {
            if (!_client.IsAuthenticated())
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate with Advisory World");
                }
            }

            var results = await _client.GetDataAsync<T>(relativeUrl, RestHelpers.CreateStringContent(parameters));

            return results;
        }

        public async Task<UserCredentials> GetUserCredentialList(string criteriaValue)
        {
            if (!_client.IsAuthenticated())
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate with Advisory World");
                }
            }

            var parameters = new UserCriteriaWrapper()
            {
                userCriteria = new UserCriteria()
                {
                    Name = criteriaValue
                }
            };

            var relativeUrl = "/usercredential/userCredentialList";
            var results = await _client.GetDataAsync<UserCredentialsWrapper>(relativeUrl, RestHelpers.CreateStringContent(parameters));

            return results.userCredentials;
        }

    }
}
