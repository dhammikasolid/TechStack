using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/action-results")]
    public class ValuesController : ApiController
    {
        [Route("collection")]
        public IEnumerable<string> GetIEnumerable()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("scalar")]
        public string GetScalar()
        {
            return " value";
        }

        [Route("empty")]
        public void GetVoid()
        {
        }

        // IHttpActionResult types 

        [Route("NotFound")]
        public IHttpActionResult GetNotFound()
        {
            return NotFound();
        }

        [Route("Ok")]
        public IHttpActionResult GetOk()
        {
            return Ok(new { X = "x" });
        }

        [Route("BadRequest")]
        public IHttpActionResult GetBadRequest()
        {
            return BadRequest();
        }
    }
}
