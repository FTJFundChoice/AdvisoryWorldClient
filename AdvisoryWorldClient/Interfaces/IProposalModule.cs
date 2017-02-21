using FTJFundChoice.AdvisoryWorldClient.Model;
using FTJFundChoice.AdvisoryWorldClient.Model.Proposal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.AdvisoryWorldClient.Interfaces
{
    public interface IProposalModule
    {
        Task<IList<Proposal>> GetListAsync(AWRequest parameters);
    }
}