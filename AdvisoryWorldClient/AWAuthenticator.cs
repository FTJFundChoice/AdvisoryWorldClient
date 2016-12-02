using RestSharp;
using RestSharp.Authenticators;

namespace AdvisoryWorldClient {
    /// <summary>
    /// Custom AdvisoryWorld Cookie Authenticator.
    /// </summary>
    internal class AWAuthenticator : IAuthenticator {
        private string username = null;
        private string password = null;
        private string authPath = "/auth?login={username}&password={password}";

        public AWAuthenticator(string username, string password) {
            this.username = username;
            this.password = password;
        }

        public void Authenticate(IRestClient client, IRestRequest request) {
            if (!IsAuthenticated(client)) {
                if (request.Resource != authPath) {
                    var authRequest = new RestRequest(authPath, Method.POST);
                    authRequest.AddUrlSegment("username", username);
                    authRequest.AddUrlSegment("password", password);
                    var response = client.Execute(authRequest);
                    SetAuthentication(client, response);
                }
            }
        }

        private void SetAuthentication(IRestClient client, IRestResponse response) {
            if (client.CookieContainer == null) {
                client.CookieContainer = new System.Net.CookieContainer();
            }
            foreach (var cookie in response.Cookies) {
                if (cookie.Name == "JSESSIONID") {
                    client.CookieContainer.Add(new System.Net.Cookie {
                        Comment = cookie.Comment,
                        CommentUri = cookie.CommentUri,
                        Discard = cookie.Discard,
                        Domain = cookie.Domain,
                        Expired = cookie.Expired,
                        Expires = cookie.Expires,
                        HttpOnly = cookie.HttpOnly,
                        Name = cookie.Name,
                        Path = cookie.Path,
                        Port = cookie.Port,
                        Secure = cookie.Secure,
                        Value = cookie.Value,
                        Version = cookie.Version
                    });
                }
            }
        }

        private bool IsAuthenticated(IRestClient client) {
            if (client.CookieContainer == null)
                return false;
            return true;
        }
    }
}