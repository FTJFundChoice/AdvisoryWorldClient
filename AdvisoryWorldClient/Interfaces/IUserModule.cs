using FTJFundChoice.AdvisoryWorldClient.Model.Security;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.AdvisoryWorldClient.Interfaces
{
    public interface IUserModule
    {
        Task<EditedUserCredentialWrapper> UpdateExistingUserCredentials(UserCredentialWrapper parameters);
        Task<CreatedUserCredentialWrapper> CreateNewUserCredentials(UserCredentialWrapper parameters);
        Task<T> SubmitUserCredentialData<T>(string relativeUrl, UserCredentialWrapper parameters);
    }
}
