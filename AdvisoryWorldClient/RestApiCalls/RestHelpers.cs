using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FTJFundChoice.AdvisoryWorldClient.Model;
using Newtonsoft.Json;
using FTJFundChoice.AdvisoryWorldClient.Model.Theme;

namespace FTJFundChoice.AdvisoryWorldClient.RestApiCalls
{
    public static class RestHelpers
    {

        public static async Task<RestCallResultsViewModel> SubmitPostRequestWithCookiesAsync(
            string url, StringContent content, Client client = null)
        {
            CookieContainer cookies = new CookieContainer();
            using (var handler = new HttpClientHandler { CookieContainer = cookies })
            {
                if (client != null)
                {
                    cookies.Add(new Uri(client.BaseUrl), client.Cookie);
                }
                HttpResponseMessage response;
                using (var restClient = new HttpClient(handler))
                {
                    response = await restClient.PostAsync(url, content);
                }
                return new RestCallResultsViewModel { Response = response, Cookies = cookies.GetCookies(new Uri(url)).Cast<Cookie>() };
            }
        }

        public static Cookie GetCookieValue(RestCallResultsViewModel viewModel, string cookieName)
        {
            return viewModel.Cookies.FirstOrDefault(x => x.Name.Equals(cookieName, StringComparison.OrdinalIgnoreCase));
        }
        public static StringContent CreateStringContent(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        public static StringContent CreateStringContent<T>(T parameters)
        {
            return new StringContent(JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}), Encoding.UTF8, "application/json");
        }

    }
}
