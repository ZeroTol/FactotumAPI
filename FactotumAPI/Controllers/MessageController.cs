using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactotumAPI.Repository;
using FactotumModels;
using Microsoft.AspNetCore.Mvc;

namespace FactotumAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MMessage>> Get()
        {
            var msgs = FakeMessages.GetMessages();
            var sorted = msgs.OrderByDescending((arg) => arg.Rating);
            return sorted.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MMessage> Get(int id)
        {
            return new MMessage();
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
