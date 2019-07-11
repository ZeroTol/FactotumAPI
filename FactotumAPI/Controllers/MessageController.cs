using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FactotumModels;
using FactotumModels.Context;
using FactotumAPI.Repository;
using FactotumAPI.Helpers;

namespace FactotumAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly FtDbContext _context;

        public MessageController(FtDbContext context)
        {
            _context = context;
        }

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
            var msgs = FakeMessages.GetDashBoardMessages();

            return msgs.ToArray();
        }

        // GET api/message/dashboard/byrating
        [HttpGet("dashboard/{order}")]
        public async Task<ActionResult<IEnumerable<EDashBoardFact>>> GetDashBoardFacts(string order)
        {
            //TODO: Uncomment when the database will be up and running
            //return Core.Instance.MessageService.GetDashBoardFacts(order).ToArray();

            switch (order)
            {
                case "byrating":
                    return await _context.Dashboard.OrderByDescending(m => m.FactRating).ToListAsync();//asList.OrderByDescending(m => m.FactRating);

                case "latestrated":
                    return await _context.Dashboard.OrderByDescending(m => m.FactLastRateDate).ToListAsync();

                case "latestadded":
                    return await _context.Dashboard.OrderByDescending(m => m.FactCreateDate).ToListAsync();
                default:
                    return await _context.Dashboard.OrderByDescending(m => m.FactRating).ToListAsync();
            }

            //return await _context.Dashboard.ToListAsync();// FakeMessages.GetDashBoardFacts(order).ToList();
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
        public async Task<ActionResult<IEnumerable<EDashBoardFact>>> FakeGet()
        {
            //List<EMessage> data = Core.Instance.dbContext.Messages.ToList();
            //return data.AsEnumerable();

            //List<EDashBoardFact> data = Core.Instance.ftDbContext.Dashboard.ToList();

            EDashBoardFact eDashBoardFact = new EDashBoardFact()
            {
                //FactId = 0,
                FactCreateDate = DateTime.Now,
                FactTitle = "what a fact",
                FactLink = "lipsum.com",
                FactRating = 0,
                FactHashTags = "#waf",
            };

            _context.Dashboard.Add(eDashBoardFact);
            await _context.SaveChangesAsync();

            //var fact_id = "1";
            //FakeMessages.LikeFact(fact_id);
            //MDashBoardFact fact = new MDashBoardFact();

            //fact.FactTitle = "What a fact";
            //fact.FactLink = "lipsum.com";


            //return Ok(FakeMessages.AppendFact(fact));
            return Ok(await _context.Dashboard.ToListAsync());

            //Core.Instance.MessageService.DislikeFact(fact_id);

            //return Ok(true);
        }

        [HttpPost]
        [Route("AppendFact")]
        public async Task<IActionResult> AppendFactAsync([FromBody] MDashBoardFact fact)
        {
            EDashBoardFact eDashBoardFact = new EDashBoardFact()
            {
                //FactId = 0,
                FactCreateDate = DateTime.Now,
                FactTitle = fact.FactTitle,
                FactLink = fact.FactLink,
                FactRating = 0,
                FactHashTags = fact.FactHashTags,
                FactId = fact.FactId
            };

            _context.Dashboard.Add(eDashBoardFact);
            await _context.SaveChangesAsync();

            return Ok(true);

            //return Ok(FakeMessages.AppendFact(fact)); // Ok(Core.Instance.MessageService.AppendFact(fact));
        }

        [HttpPost]
        [Route("LikeFact")]
        public IActionResult LikeFact([FromBody] string fact_id)
        {
            //FakeMessages.LikeFact(fact_id);
            var fact_item = _context.Dashboard.FirstOrDefault(i => i.FactId == new Guid(fact_id)/*int.Parse(fact_id)*/);//Core.Instance.dbContext.DashBoardFacts.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

            fact_item.FactRating++;
            fact_item.FactLastRateDate = DateTime.Now;

            _context.Dashboard.Update(fact_item);
            _context.SaveChanges();

            return Ok(true);
            //return Ok(Core.Instance.MessageService.LikeFact(fact_id));
            //return Ok(fact_id);
        }

        [HttpPost]
        [Route("DislikeFact")]
        public IActionResult DislikeFact([FromBody] string fact_id)
        {
            var fact_item = _context.Dashboard.FirstOrDefault(i => i.FactId == new Guid(fact_id)/*int.Parse(fact_id)*/);//Core.Instance.dbContext.DashBoardFacts.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

            fact_item.FactRating--;
            fact_item.FactLastRateDate = DateTime.Now;

            _context.Dashboard.Update(fact_item);
            _context.SaveChanges();
            //FakeMessages.DislikeFact(fact_id);
            return Ok(true);
            //return Ok(Core.Instance.MessageService.DislikeFact(fact_id));
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
