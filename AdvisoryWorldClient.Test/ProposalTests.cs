using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdvisoryWorldClient.Test {

    [TestClass]
    public class ProposalTests : BaseTest {

        [TestMethod]
        public void List() {
            var result = Client.Proposal.List();
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
        }
    }
}