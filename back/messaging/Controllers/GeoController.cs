namespace messaging.Controllers
{
    using System.Web.Http;
    using HereIYam.Models;

    public class GeoController : ApiController
    {
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

            //Push to SignalR

            return base.Ok();
        }
    }
}