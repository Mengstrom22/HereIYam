namespace HereIYam.Core
{
    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNet.SignalR.Hubs;

    [HubName("geo")]
    public class GeoHub : Hub
    {
        public void MultiCast(string value)
        {
            Clients.All.multicast(value);
        }
    }
}