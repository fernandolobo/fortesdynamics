using Mensageria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Mensageria.Queue;
using Newtonsoft.Json;

namespace Mensageria.Controllers
{
    public class MensageriaController : ApiController
    {
        // GET: api/Mensageria
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Mensageria/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mensageria
        public string Post([FromBody]Opportunity value)
        {
            //return await Task.Run(() => teste = value);
            MSMQ.SendPrivate(JsonConvert.SerializeObject(value));
            return string.Empty;

        }

        // PUT: api/Mensageria/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mensageria/5
        public void Delete(int id)
        {
        }
    }
}
