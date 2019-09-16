using Newtonsoft.Json;
using Sample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace Sample.Controllers
{
    [RoutePrefix("api/GetAddress")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AddressController : ApiController
    {
        GetAddress data = new GetAddress();

        [Route("Country")]
        [HttpGet]
        public IHttpActionResult GetCountries()
        {
            return Ok(JsonConvert.SerializeObject(data.GetCountries()));
        }
        [Route("state")]
        [HttpGet]
        public IHttpActionResult GetStates(string Country)
        {
            return Ok(JsonConvert.SerializeObject(data.GetState(Country)));
        }
        [Route("city")]
        [HttpGet]
        public IHttpActionResult GetCities(string State)
        {
            return Ok(JsonConvert.SerializeObject(data.GetCities(State)));
        }
        [Route("area")]
        [HttpGet]
        public IHttpActionResult GetArea(string City)
        {
            return Ok(JsonConvert.SerializeObject(data.GetArea(City)));
        }
    }
}
