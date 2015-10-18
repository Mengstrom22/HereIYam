namespace HereIYam.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNet.SignalR;

    public class GeoHub : Hub
    {
        public void SendToAll(string value)
        {
            Clients.All.hubMessage(value);
        }
    }
}