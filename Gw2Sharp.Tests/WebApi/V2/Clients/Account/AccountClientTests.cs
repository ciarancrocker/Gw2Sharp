using System.Threading.Tasks;
using Gw2Sharp.WebApi.V2.Clients;
using Xunit;

namespace Gw2Sharp.Tests.WebApi.V2.Clients
{
    public class AccountClientTests : BaseEndpointClientTests<IAccountClient>
    {
        protected override bool IsAuthenticated => true;

        protected override IAccountClient CreateClient(IGw2Client gw2Client) =>
            gw2Client.WebApi.V2.Account;

        [Theory]
        [InlineData("TestFiles.Account.Account.1.json")]
        [InlineData("TestFiles.Account.Account.2.json")]
        public Task BlobTest(string file) => this.AssertBlobDataAsync(this.Client, file);
    }
}
