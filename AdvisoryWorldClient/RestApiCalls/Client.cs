using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdvisoryWorldClient.RestApiCalls
{
    public class Client
    {
        public readonly string BaseUrl;
        public readonly string Username;
        public readonly string Password;
        public Cookie Cookie;

        public Client(string baseUrl, string username, string password)
        {
            BaseUrl = baseUrl;
            Username = username;
            Password = password;
        }

        public async Task<bool> AuthenticateAsync()
        {
            var viewModel = await RestHelpers.SubmitPostRequestWithCookiesAsync(
                $"{BaseUrl}/auth?login={Username}&password={Password}", null);
            Cookie = RestHelpers.GetCookieValue(viewModel, "JSESSIONID");
            return Cookie != null;
        }

        public async Task<T> GetDataAsync<T>(string relativeUrl, StringContent stringContent)
        {
            var viewModel = await RestHelpers.SubmitPostRequestWithCookiesAsync(
                $"{BaseUrl}{relativeUrl}", stringContent, this);
            return JsonConvert.DeserializeObject<T>(
                await viewModel.Response.Content.ReadAsStringAsync());

        }
        public bool IsAuthenticated => Cookie != null;

    }
}