namespace messaging.Controllers
{
    using System.Web.Http;
    using HereIYam.Core;
    using HereIYam.Models;
    using Newtonsoft.Json;

    public class GeoController : ApiController
    {
        private readonly GeoHub hub = new GeoHub();

        // PUT api/geo
        [HttpPut]
        public IHttpActionResult Put(ClientLocation location)
        {
            if (null == location)
            {
                return base.BadRequest("unknown lat/long");
            }
            if (0 >= location.latitude)
            {
                return base.BadRequest("unknown latitude");
            }
            if (0 >= location.longitude)
            {
                return base.BadRequest("unknown longitude");
            }
            
            hub.SendToAll(JsonConvert.SerializeObject(location));

            return base.Ok();
        }
    }
}