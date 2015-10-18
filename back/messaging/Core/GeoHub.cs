namespace HereIYam.Core
{
    using Microsoft.AspNet.SignalR;

    public class GeoHub : Hub
    {
        public void SendToAll(string value)
        {
            Clients.All.hubMessage(value);
        }
    }
}