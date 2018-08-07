namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 continents id endpoint.
    /// </summary>
    [EndpointPath("continents/:continent_id")]
    public class ContinentsIdClient : BaseClient, IContinentsIdClient
    {
        /// <summary>
        /// Creates a new <see cref="ContinentsIdClient"/> that is used for the API v2 continents id endpoint.
        /// </summary>
        /// <param name="connection">The connection used to make requests, see <see cref="IConnection"/>.</param>
        /// <param name="continentId">The continent id.</param>
        public ContinentsIdClient(IConnection connection, int continentId) : base(connection)
        {
            this.ContinentId = continentId;
            this.Floors = new ContinentsFloorsClient(connection, continentId);
        }

        /// <inheritdoc />
        public int ContinentId { get; protected set; }

        /// <inheritdoc />
        public IContinentsFloorsClient Floors { get; protected set; }
    }
}