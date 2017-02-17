using System;
using System.Threading.Tasks;
using AdvisoryWorldClient.RestApiCalls;

using AdvisoryWorldClient.Interfaces;
using AdvisoryWorldClient.Model.Theme;

namespace AdvisoryWorldClient.Compositions
{
    public class PrivateLabelModule : IPrivateLabelModule
    {
        private readonly Client _client;

        public PrivateLabelModule(Client client)
        {
            _client = client;
        }

        public async Task<RestPostResponse> SubmitPrivateLabelData(PrivateLabel parameters)
        {
            if (!_client.IsAuthenticated)
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate with Advisory World");
                }
            }

            var results =  await _client.GetDataAsync<RestPostResponse>("user/private-label/save", RestHelpers.CreateStringContent(parameters));

            return results;
        }
    }
}
