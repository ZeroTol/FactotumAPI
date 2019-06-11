using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FactotumAPI.Helpers;
using FactotumAPI.Repository;
using FactotumModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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

        // GET api/message/dashboardmessages
        [HttpGet("dashboardmessages")]
        public ActionResult<IEnumerable<MDashBoardFact>> GetDashBoardMessages()
        {
            //var user = Core.Instance.MessageService.GetUser(id);
            var msgs = FakeMessages.GetDashBoardFacts();

            return msgs.ToArray();
        }

        // GET api/message/dashboard/byrating
        [HttpGet("dashboard/{order}")]
        public ActionResult<IEnumerable<EDashBoardFact>> GetDashBoardMessages(string order)
        {

            //var user = Core.Instance.MessageService.GetUser(id);
            //var msgs = FakeMessages.GetDashBoardMessages();


            return Core.Instance.MessageService.GetDashBoardFacts(order).ToArray();

        }

        // GET api/message/user/5
        [HttpGet("user/{id}")]
        public ActionResult<EUser> GetUser(int id)
        {
            var user = Core.Instance.MessageService.GetUser(id);

            return user;
        }


        // GET api/message/fakeget
        [HttpGet("fakeget")]
        public IActionResult FakeGet()
        {
            var fact_id = "1";

            Core.Instance.MessageService.DislikeFact(fact_id);

            //MDashBoardFact fact = new MDashBoardFact()
            //{
            //    FactTitle = "aaa",
            //    FactLink = "www.google.com",
            //    FactCreateDate = DateTime.Now,
            //    FactHashTags = "#aaa",
            //    FactLastRateDate = DateTime.Now,
            //    FactRating = 1,
            //    FactId = 1
            //};
            //var user = Core.Instance.MessageService.GetUser(id);
            //var msgs = FakeMessages.GetDashBoardFacts();
            //var fact_entity = Core.Instance.MessageService.AppendFact(fact);

            return Ok(true);
        }

        [HttpPost]
        [Route("AppendFact")]
        public IActionResult AppendFact([FromBody] MDashBoardFact fact)
        {
            return Ok(Core.Instance.MessageService.AppendFact(fact));
        }

        [HttpPost]
        [Route("LikeFact")]
        public IActionResult LikeFact([FromBody] string fact_id)
        {
            return Ok(Core.Instance.MessageService.LikeFact(fact_id));
            //return Ok(fact_id);
        }

        [HttpPost]
        [Route("DislikeFact")]
        public IActionResult DislikeFact([FromBody] string fact_id)
        {
            return Ok(Core.Instance.MessageService.DislikeFact(fact_id));
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
