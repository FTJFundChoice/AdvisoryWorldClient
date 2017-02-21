using System.Threading.Tasks;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;

using FTJFundChoice.AdvisoryWorldClient.Model.Theme;

namespace FTJFundChoice.AdvisoryWorldClient.Interfaces
{
    public interface IPrivateLabelModule
    {
        Task<RestPostResponse> SubmitPrivateLabelData(PrivateLabel parameters);
    }
}
