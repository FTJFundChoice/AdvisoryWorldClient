
using AdvisoryWorldClient.Compositions;
using AdvisoryWorldClient.Model;
using AdvisoryWorldClient.RestApiCalls;
using AdvisoryWorldClient.Test._base;
using Xunit;

namespace AdvisoryWorldClient.Test.ProposalTests
{
    [Collection("Proposals")]
    public class ProposalsTestContext : TestBase
    {
        [Fact]
        public async void ShouldGetProposalList()
        {
            AWRequest awr = new AWRequest
            {
                Paging = new Paging
                {
                    ItemsOnPage = 10,
                    Page = 1
                }
            };
            var client = new Client(BaseUrl,Username,Password);
            Assert.True(await client.AuthenticateAsync());
            var prop = new ProposaleModule(client);
            var result = await prop.GetListAsync(awr);
            Assert.NotNull(result);
            Assert.Equal(10, result.Count);
        }

    }
}
