namespace messaging.Controllers
{
    using System.Web.Http;
    using HereIYam.Models;

    public class GeoController : ApiController
    {
        // POST api/geo
        [HttpPost]
        public IHttpActionResult Post(ClientLocation cl)
        {
            if (null == cl)
            {
                return base.BadRequest("unknown lat/long");
            }
            if (0 >= cl.latitude)
            {
                return base.BadRequest("unknown latitude");
            }
            if (0 >= cl.longitude)
            {
                return base.BadRequest("unknown longitude");
            }

            //Push to SignalR

            return base.Ok();
        }
    }
}