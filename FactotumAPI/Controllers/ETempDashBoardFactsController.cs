using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FactotumAPI.Data;
using FactotumModels;
using Microsoft.AspNetCore.Authorization;

namespace FactotumAPI.Controllers
{
    [Authorize]
    public class ETempDashBoardFactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ETempDashBoardFactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ETempDashBoardFacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.TempDashboard.ToListAsync());
        }

        public async Task<IActionResult> Approve(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eTempDashBoardFact = await _context.TempDashboard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eTempDashBoardFact == null)
            {
                return NotFound();
            }

            var eDashBoardFact = new EDashBoardFact()
            {
                FactCreateDate = eTempDashBoardFact.FactCreateDate,
                FactHashTags = eTempDashBoardFact.FactHashTags,
                FactLastRateDate = eTempDashBoardFact.FactLastRateDate,
                FactLink = eTempDashBoardFact.FactLink,
                FactRating = eTempDashBoardFact.FactRating,
                FactTitle = eTempDashBoardFact.FactTitle,
                FactId = eTempDashBoardFact.FactId,
            };

            _context.Dashboard.Add(eDashBoardFact);

            _context.TempDashboard.Remove(eTempDashBoardFact);

            _context.SaveChanges();

            return View(eDashBoardFact);
        }

        // GET: ETempDashBoardFacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eTempDashBoardFact = await _context.TempDashboard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eTempDashBoardFact == null)
            {
                return NotFound();
            }

            return View(eTempDashBoardFact);
        }

        // GET: ETempDashBoardFacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ETempDashBoardFacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FactId,FactRating,FactCreateDate,FactLastRateDate,FactTitle,FactLink,FactHashTags")] ETempDashBoardFact eTempDashBoardFact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eTempDashBoardFact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eTempDashBoardFact);
        }

        // GET: ETempDashBoardFacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eTempDashBoardFact = await _context.TempDashboard.FindAsync(id);
            if (eTempDashBoardFact == null)
            {
                return NotFound();
            }
            return View(eTempDashBoardFact);
        }

        // POST: ETempDashBoardFacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FactId,FactRating,FactCreateDate,FactLastRateDate,FactTitle,FactLink,FactHashTags")] ETempDashBoardFact eTempDashBoardFact)
        {
            if (id != eTempDashBoardFact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eTempDashBoardFact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ETempDashBoardFactExists(eTempDashBoardFact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(eTempDashBoardFact);
        }

        // GET: ETempDashBoardFacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eTempDashBoardFact = await _context.TempDashboard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eTempDashBoardFact == null)
            {
                return NotFound();
            }

            return View(eTempDashBoardFact);
        }

        // POST: ETempDashBoardFacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eTempDashBoardFact = await _context.TempDashboard.FindAsync(id);
            _context.TempDashboard.Remove(eTempDashBoardFact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ETempDashBoardFactExists(int id)
        {
            return _context.TempDashboard.Any(e => e.Id == id);
        }
    }
}
