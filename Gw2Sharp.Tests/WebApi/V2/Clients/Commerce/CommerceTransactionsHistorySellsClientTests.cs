using System.Threading.Tasks;
using Gw2Sharp.WebApi.V2.Clients;
using Xunit;

namespace Gw2Sharp.Tests.WebApi.V2.Clients
{
    public class CommerceTransactionsHistorySellsClientTests : BaseEndpointClientTests<ICommerceTransactionsHistorySellsClient>
    {
        protected override bool IsAuthenticated => true;

        protected override ICommerceTransactionsHistorySellsClient CreateClient(IGw2Client gw2Client) =>
            gw2Client.WebApi.V2.Commerce.Transactions.History.Sells;

        [Theory]
        [InlineData("TestFiles.Commerce.CommerceTransactionsHistory.json")]
        public Task BlobTest(string file) => this.AssertBlobDataAsync(this.Client, file);

        [Theory]
        [InlineData("TestFiles.Commerce.CommerceTransactionsHistory.json")]
        public Task PaginatedTestAsync(string file) => this.AssertPaginatedDataAsync(this.Client, file);
    }
}
