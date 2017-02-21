using System;
using System.Configuration;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;

namespace FTJFundChoice.AdvisoryWorldClient.Test._base
{
    public abstract class TestBase : IDisposable
    {
        protected string BaseUrl;
        protected string Username;
        protected string Password;

        public TestBase()
        {
            BaseUrl = ConfigurationManager.AppSettings["apiUrl"];
            Username = ConfigurationManager.AppSettings["username"];
            Password = ConfigurationManager.AppSettings["password"];
        }

        public virtual void Dispose()
        {
            //Client.Dispose();
        }
    }
}