using AdvisoryWorldClient.Model;
using System.Collections.Generic;

namespace AdvisoryWorldClient.Interfaces {

    public interface IProposalModule {

        List<Proposal> List(AWRequest parameters);
    }
}