namespace messaging.Controllers
{
    using System.Web.Http;

    public class GeoController : ApiController
    {
        // POST api/geo
        [HttpPost]
        public IHttpActionResult Post(double lat, double lng)
        {
            if (0 >= lat)
            {
                return base.BadRequest("unknown latitude");
            }
            if (0 >= lng)
            {
                return base.BadRequest("unknown longitude");
            }

            //Push to SignalR

            return base.Ok();
        }
    }
}