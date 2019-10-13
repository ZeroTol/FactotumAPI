using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FactotumModels;
using FactotumAPI.Repository;
using FactotumAPI.Helpers;
using FactotumAPI.Data;

namespace FactotumAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class RootController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RootController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api
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

            //var msgs = Core.Instance.MessageService.GetMessages();
            //var sorted = msgs.OrderByDescending((arg) => arg.Rating);
            return Ok(true);//sorted.ToArray();
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] MRegister data)
        {
            await _context.SaveChangesAsync();

            return Ok(true);

            //return Ok(FakeMessages.AppendFact(fact)); // Ok(Core.Instance.MessageService.AppendFact(fact));
        }

        [HttpGet]
        [Route("Login")]
        public async Task<IActionResult> Login()
        {
            await _context.SaveChangesAsync();

            return Ok(true);

            //return Ok(FakeMessages.AppendFact(fact)); // Ok(Core.Instance.MessageService.AppendFact(fact));
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MessageController(ApplicationDbContext context)
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

            //var msgs = Core.Instance.MessageService.GetMessages();
            //var sorted = msgs.OrderByDescending((arg) => arg.Rating);
            return Ok(true);//sorted.ToArray();
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

        [HttpPost]
        [Route("AppendFact")]
        public async Task<IActionResult> AppendFactAsync([FromBody] MDashBoardFact fact)
        {
            ETempDashBoardFact eTempDashBoardFact = new ETempDashBoardFact()
            {
                //FactId = 0,
                FactCreateDate = DateTime.Now,
                FactTitle = fact.FactTitle,
                FactLink = fact.FactLink,
                FactRating = 0,
                FactHashTags = fact.FactHashTags,
                FactId = fact.FactId
            };

            _context.TempDashboard.Add(eTempDashBoardFact);
            await _context.SaveChangesAsync();

            return Ok(true);

            //return Ok(FakeMessages.AppendFact(fact)); // Ok(Core.Instance.MessageService.AppendFact(fact));
        }

        [HttpPost]
        [Route("LikeFact")]
        public IActionResult LikeFact([FromBody] string fact_id)
        {
            //FakeMessages.LikeFact(fact_id);
            var fact_item = _context.Dashboard.FirstOrDefault(i => i.FactId == new Guid(fact_id)/*int.Parse(fact_id)*/);//Core.Instance.dbContext.Dashboard.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

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
            var fact_item = _context.Dashboard.FirstOrDefault(i => i.FactId == new Guid(fact_id)/*int.Parse(fact_id)*/);//Core.Instance.dbContext.Dashboard.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

            fact_item.FactRating--;
            fact_item.FactLastRateDate = DateTime.Now;

            _context.Dashboard.Update(fact_item);
            _context.SaveChanges();
            //FakeMessages.DislikeFact(fact_id);
            return Ok(true);
            //return Ok(Core.Instance.MessageService.DislikeFact(fact_id));
        }
    }
}
