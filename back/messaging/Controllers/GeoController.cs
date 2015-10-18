namespace messaging.Controllers
{
    using System.Web.Http;
    using HereIYam.Models;

    public class GeoController : ApiController
    {
        // POST api/geo
        /// <summary>
        /// Log current location, and share it
        /// </summary>
        /// <param name="location">Client Location</param>
        /// <returns>none</returns>
        /// <remarks>Multi-casts location to all listeners</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
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