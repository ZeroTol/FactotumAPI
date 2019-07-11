using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FactotumModels;
using FactotumModels.Context;

namespace FactotumAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EDashBoardFactsController : ControllerBase
    {
        private readonly FtDbContext _context;

        public EDashBoardFactsController(FtDbContext context)
        {
            _context = context;
        }

        // GET: api/EDashBoardFacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EDashBoardFact>>> GetDashboard()
        {
            return await _context.Dashboard.ToListAsync();
        }

        // GET: api/EDashBoardFacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EDashBoardFact>> GetEDashBoardFact(int id)
        {
            var eDashBoardFact = await _context.Dashboard.FindAsync(id);

            if (eDashBoardFact == null)
            {
                return NotFound();
            }

            return eDashBoardFact;
        }

        // PUT: api/EDashBoardFacts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEDashBoardFact(int id, EDashBoardFact eDashBoardFact)
        {
            if (id != eDashBoardFact.Id)
            {
                return BadRequest();
            }

            _context.Entry(eDashBoardFact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EDashBoardFactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EDashBoardFacts
        [HttpPost]
        public async Task<ActionResult<EDashBoardFact>> PostEDashBoardFact(EDashBoardFact eDashBoardFact)
        {
            _context.Dashboard.Add(eDashBoardFact);
            await _context.SaveChangesAsync();

            return Ok(true);
                /*CreatedAtAction("GetEDashBoardFact", new { id = eDashBoardFact.Id }, eDashBoardFact);*/
        }

        // DELETE: api/EDashBoardFacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EDashBoardFact>> DeleteEDashBoardFact(int id)
        {
            var eDashBoardFact = await _context.Dashboard.FindAsync(id);
            if (eDashBoardFact == null)
            {
                return NotFound();
            }

            _context.Dashboard.Remove(eDashBoardFact);
            await _context.SaveChangesAsync();

            return eDashBoardFact;
        }

        private bool EDashBoardFactExists(int id)
        {
            return _context.Dashboard.Any(e => e.Id == id);
        }
    }
}
