namespace messaging.Controllers
{
    using System.Web.Http;
    using HereIYam.Core;
    using HereIYam.Models;
    using Microsoft.AspNet.SignalR;
    using Newtonsoft.Json;

    public class GeoController : ApiController
    {
        // PUT api/geo
        [HttpPut]
        public IHttpActionResult Put(ClientLocation location)
        {
            if (null == location)
            {
                return base.BadRequest("send lat/long");
            }
            if (0 >= location.latitude)
            {
                return base.BadRequest("unknown latitude");
            }
            if (0 >= location.longitude)
            {
                return base.BadRequest("unknown longitude");
            }

            var hub = GlobalHost.ConnectionManager.GetHubContext<GeoHub>();
            hub.Clients.All.multicast(JsonConvert.SerializeObject(location));

            return base.Ok();
        }
    }
}