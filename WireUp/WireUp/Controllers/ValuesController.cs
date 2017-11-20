using DomainServices;
using System.Collections.Generic;
using System.Web.Http;

namespace WireUp.Controllers
{
    public class ValuesController : ApiController
    {
        IService service;

        public ValuesController(IService service)
        {
            this.service = service;
        }

        // GET api/<controller>
        public IEnumerable<int> Get()
        {
            return new int[] { service.Add1000(1) };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}