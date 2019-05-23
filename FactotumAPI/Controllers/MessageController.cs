using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FactotumAPI.Helpers;
using FactotumAPI.Repository;
using FactotumModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FactotumAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        // GET api/message
        [HttpGet]
        public ActionResult<IEnumerable<EMessage>> Get()
        {
            var headers = Request.Headers;
            var key = headers.FirstOrDefault(x => x.Key == "Authorization");
            var result = SecurityHelper.Instance.CheckSecurityKey(key.Value);
            if (result)
            {
                return new UnauthorizedResult();
            }

            var msgs = Core.Instance.MessageService.GetMessages();

            var sorted = msgs.OrderByDescending((arg) => arg.Rating);
            return sorted.ToArray();
        }

        // GET api/message/5
        [HttpGet("{id}")]
        public ActionResult<EMessage> Get(int id)
        {
            var msgs = Core.Instance.MessageService.GetMessages();
            return new EMessage();
        }

        // GET api/message/user/5
        [HttpGet("user/{id}")]
        public ActionResult<EUser> GetUser(int id)
        {
            var user = Core.Instance.MessageService.GetUser(id);

            return user;
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
