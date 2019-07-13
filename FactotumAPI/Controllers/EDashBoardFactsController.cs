using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FactotumAPI.Data;
using FactotumModels;

namespace FactotumAPI.Controllers
{
    public class EDashBoardFactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EDashBoardFactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EDashBoardFacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dashboard.ToListAsync());
        }

        // GET: EDashBoardFacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eDashBoardFact = await _context.Dashboard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eDashBoardFact == null)
            {
                return NotFound();
            }

            return View(eDashBoardFact);
        }

        // GET: EDashBoardFacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EDashBoardFacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FactId,FactRating,FactCreateDate,FactLastRateDate,FactTitle,FactLink,FactHashTags")] EDashBoardFact eDashBoardFact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eDashBoardFact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eDashBoardFact);
        }

        // GET: EDashBoardFacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eDashBoardFact = await _context.Dashboard.FindAsync(id);
            if (eDashBoardFact == null)
            {
                return NotFound();
            }
            return View(eDashBoardFact);
        }

        // POST: EDashBoardFacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FactId,FactRating,FactCreateDate,FactLastRateDate,FactTitle,FactLink,FactHashTags")] EDashBoardFact eDashBoardFact)
        {
            if (id != eDashBoardFact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eDashBoardFact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EDashBoardFactExists(eDashBoardFact.Id))
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
            return View(eDashBoardFact);
        }

        // GET: EDashBoardFacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eDashBoardFact = await _context.Dashboard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eDashBoardFact == null)
            {
                return NotFound();
            }

            return View(eDashBoardFact);
        }

        // POST: EDashBoardFacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eDashBoardFact = await _context.Dashboard.FindAsync(id);
            _context.Dashboard.Remove(eDashBoardFact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EDashBoardFactExists(int id)
        {
            return _context.Dashboard.Any(e => e.Id == id);
        }
    }
}
