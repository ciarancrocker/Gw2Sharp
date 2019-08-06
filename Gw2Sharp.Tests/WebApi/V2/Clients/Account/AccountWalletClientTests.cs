using System.Threading.Tasks;
using Gw2Sharp.WebApi.V2.Clients;
using Xunit;

namespace Gw2Sharp.Tests.WebApi.V2.Clients
{
    public class AccountWalletClientTests : BaseEndpointClientTests<IAccountWalletClient>
    {
        protected override bool IsAuthenticated => true;

        protected override IAccountWalletClient CreateClient(IGw2Client gw2Client) =>
            gw2Client.WebApi.V2.Account.Wallet;

        [Theory]
        [InlineData("TestFiles.Account.AccountWallet.json")]
        public Task BlobTest(string file) => this.AssertBlobDataAsync(this.Client, file);
    }
}
