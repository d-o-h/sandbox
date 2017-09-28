using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sandbox.Controllers
{
    [Route("api/[controller]")]
    public class StoreController : Controller
    {
        // GET api/store
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/store/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/store
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/store/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/store/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
