using AdvisoryWorldClient.Interfaces;
using AdvisoryWorldClient.Model;
using RestSharp;
using System.Collections.Generic;

namespace AdvisoryWorldClient.Compositions {

    internal class ProposalModule : IProposalModule {
        private IRestClient client = null;

        public ProposalModule(IRestClient client) {
            this.client = client;
        }

        public List<Proposal> List() {
            AWRequest req = new AWRequest();
            req.Paging = new Paging {
                Items = 100,
                ItemsOnPage = 10,
                Page = 1
            };

            var request = new RestRequest("/proposal/list ", Method.POST);
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", SimpleJson.SerializeObject(req), ParameterType.RequestBody);

            var result = client.Execute<AWRequest<Proposal>>(request);
            return result.Data.Items;
        }
    }
}