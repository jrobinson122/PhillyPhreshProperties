using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhillyPhreshPropertiesAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Properties")]
    public class PhillyPhreshPropertiesController : Controller
    {
        // GET api/values
        [HttpGet("CalculateHomeSize/{x}/{y}/{z}")]
        public double CalculateHomeSize(double x, double y, double z)
        {
            double sum = x + y;
            double totalSize = sum * z;
            return totalSize;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
