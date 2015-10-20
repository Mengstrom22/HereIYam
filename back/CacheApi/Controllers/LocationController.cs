namespace CacheApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using Models;

    public class LocationController : ApiController
    {
        // GET api/values
        public IEnumerable<ClientLocation> Get()
        {
            var r = new Random();
            var locations = new List<ClientLocation>();
            locations.Add(new ClientLocation { Latitude = r.Next(), Longitude = r.Next() });
            locations.Add(new ClientLocation { Latitude = r.Next(), Longitude = r.Next() });
            locations.Add(new ClientLocation { Latitude = r.Next(), Longitude = r.Next() });
            locations.Add(new ClientLocation { Latitude = r.Next(), Longitude = r.Next() });

            return locations;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}