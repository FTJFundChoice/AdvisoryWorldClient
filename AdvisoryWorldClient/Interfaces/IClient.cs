using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.AdvisoryWorldClient.Interfaces
{
    public interface IClient
    {
        Task<bool> AuthenticateAsync();
        Task<T> GetDataAsync<T>(string relativeUrl, StringContent stringContent);

        bool IsAuthenticated();
    }
}
