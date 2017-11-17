using System;
using System.Threading.Tasks;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;

using FTJFundChoice.AdvisoryWorldClient.Interfaces;
using FTJFundChoice.AdvisoryWorldClient.Model.Theme;

namespace FTJFundChoice.AdvisoryWorldClient.Compositions
{
    public class PrivateLabelModule : IPrivateLabelModule
    {
        private readonly IClient _client;

        public PrivateLabelModule(IClient client)
        {
            _client = client;
        }

        public async Task<RestPostResponse> SubmitPrivateLabelData(PrivateLabel parameters)
        {
            if (!_client.IsAuthenticated())
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate with Advisory World");
                }
            }

            try
            {
                var results = await _client.GetDataAsync<RestPostResponse>("user/private-label/save", RestHelpers.CreateStringContent(parameters));
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RestGetResponse> DeleteLogo(int userId)
        {
            if (!_client.IsAuthenticated())
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate with Advisory World");
                }
            }

            try
            {
                var results = await _client.GetDataAsync<RestGetResponse>($"user/{userId}/private-label/company-image/delete", RestHelpers.CreateStringContent(string.Empty));
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RestGetResponse> DeleteColors(int userId)
        {
            if (!_client.IsAuthenticated())
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate with Advisory World");
                }
            }

            try
            {
                var results = await _client.GetDataAsync<RestGetResponse>($"user/{userId}/private-label/colors/delete", RestHelpers.CreateStringContent(string.Empty));
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RestGetResponse> DeleteThumbnail(int userId)
        {
            if (!_client.IsAuthenticated())
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate with Advisory World");
                }
            }

            try
            {
                var results = await _client.GetDataAsync<RestGetResponse>($"user/{userId}/companyInfo/remove-thumbnail", RestHelpers.CreateStringContent(string.Empty));
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
