using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace FTJFundChoice.AdvisoryWorldClient.RestApiCalls
{
    public class RestCallResultsViewModel
    {
        public HttpResponseMessage Response { get; set; }
        public IEnumerable<Cookie> Cookies { get; set; }
    }
}