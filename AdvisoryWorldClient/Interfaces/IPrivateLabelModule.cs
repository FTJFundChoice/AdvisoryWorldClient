using System.Threading.Tasks;
using AdvisoryWorldClient.RestApiCalls;

using AdvisoryWorldClient.Model.Theme;

namespace AdvisoryWorldClient.Interfaces
{
    public interface IPrivateLabelModule
    {
        Task<RestPostResponse> SubmitPrivateLabelData(PrivateLabel parameters);
    }
}
