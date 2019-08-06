using System.Threading.Tasks;
using Gw2Sharp.WebApi.V2.Clients;
using Xunit;

namespace Gw2Sharp.Tests.WebApi.V2.Clients
{
    public class CharactersIdHeroPointsClientTests : BaseCharactersSubEndpointClientTests<ICharactersIdHeroPointsClient>
    {
        protected override bool IsAuthenticated => true;

        protected override ICharactersIdHeroPointsClient CreateClient(IGw2Client gw2Client) =>
            gw2Client.WebApi.V2.Characters["Bob"].HeroPoints;

        [Theory]
        [InlineData("TestFiles.Characters.CharactersIdHeroPoints.json")]
        public Task BlobTest(string file) => this.AssertBlobDataAsync(this.Client, file);
    }
}
