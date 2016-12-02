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

        public List<Proposal> List(AWRequest parameters) {
            var request = new RestRequest("/proposal/list ", Method.POST);
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", SimpleJson.SerializeObject(parameters, SimpleJson.DataContractJsonSerializerStrategy), ParameterType.RequestBody);

            var result = client.Execute<AWRequest<Proposal>>(request);
            return result.Data.Items;
        }
    }
}