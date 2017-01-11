using AdvisoryWorldClient.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvisoryWorldClient.Interfaces
{
    public interface IProposalModule
    {
        Task<IList<Proposal>> GetListAsync(AWRequest parameters);
    }
}