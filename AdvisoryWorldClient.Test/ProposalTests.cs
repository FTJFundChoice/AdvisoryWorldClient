using AdvisoryWorldClient.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdvisoryWorldClient.Test {

    [TestClass]
    public class ProposalTests : BaseTest {

        [TestMethod]
        public void List() {
            AWRequest awr = new AWRequest();
            awr.Paging = new Paging {
                ItemsOnPage = 10,
                Page = 1
            };

            var result = Client.Proposal.List(awr);
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Count);
        }
    }
}