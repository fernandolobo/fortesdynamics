using Mensageria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Mensageria.Controllers
{
    public class OpportunityController : ApiController
    {
        // GET: api/Opportunity
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Opportunity/5
        public string Get(int id)
        {
            return "value";
        }

        //POST: api/Opportunity
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT: api/Opportunity/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Opportunity/5
        public void Delete(int id)
        {
        }
    }
}
