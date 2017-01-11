using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdvisoryWorldClient.Interfaces;
using AdvisoryWorldClient.Model;
using AdvisoryWorldClient.RestApiCalls;

namespace AdvisoryWorldClient.Compositions
{
    public class ProposaleModule : IProposalModule
    {
        private readonly Client _client;
        public ProposaleModule(Client client)
        {
            _client = client;
        }

        public async Task<IList<Proposal>> GetListAsync(AWRequest parameters)
        {
            if (!_client.IsAuthenticated)
            {
                if (!await _client.AuthenticateAsync())
                {
                    throw new Exception("Unable to authenticate");
                }
            }
            var result = await _client.GetDataAsync<AWRequest<Proposal>>
                ("/proposal/list", RestHelpers.CreateStringContent(parameters));
            return result.Items;
        }
    }
}