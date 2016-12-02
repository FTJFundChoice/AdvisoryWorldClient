using AdvisoryWorldClient.Compositions;
using AdvisoryWorldClient.Interfaces;
using RestSharp;

namespace AdvisoryWorldClient {

    public class Client {
        private IRestClient client = null;
        private IProposalModule proposal = null;

        public Client(string baseUrl, string username, string password) {
            client = new RestClient(baseUrl);
            client.Authenticator = new AWAuthenticator(username, password);

            Proposal = new ProposalModule(client);
        }

        public IProposalModule Proposal {
            private set {
                proposal = value;
            }
            get {
                return proposal;
            }
        }
    }
}