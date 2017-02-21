using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTJFundChoice.AdvisoryWorldClient.Interfaces;
using FTJFundChoice.AdvisoryWorldClient.Model;
using FTJFundChoice.AdvisoryWorldClient.Model.Proposal;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;

namespace FTJFundChoice.AdvisoryWorldClient.Compositions
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
            if (!_client.IsAuthenticated())
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