using AdvisoryWorldClient.RestApiCalls;
using AdvisoryWorldClient.Test._base;
using Xunit;

namespace AdvisoryWorldClient.Test.ResApiCalls
{
    [Collection("Authentication")]
    public class RestApiCallsTestContext : TestBase
    {
        [Fact]
        public async void ShouldGetResponseAsync()
        {
            var viewModel = await RestHelpers.SubmitPostRequestWithCookiesAsync($"{BaseUrl}/auth?login={Username}&password={Password}",null);
            Assert.True(viewModel.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async void ShouldGetAuthCookie()
        {
            var viewModel = await RestHelpers.SubmitPostRequestWithCookiesAsync($"{BaseUrl}/auth?login={Username}&password={Password}",null);
            var cookie = RestHelpers.GetCookieValue(viewModel, "JSESSIONID");
            Assert.NotNull(cookie);
            Assert.Equal("JSESSIONID", cookie.Name);
        }

    }
}
