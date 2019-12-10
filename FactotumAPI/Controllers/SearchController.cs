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
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("tag/{tagvalue}")]
        public async Task<ActionResult<IEnumerable<EDashBoardFact>>> Tag(string tagvalue)
        {
            var matches = from m in _context.Dashboard
                          where m.FactHashTags.Contains(tagvalue)
                          select m;

            var eDashBoardFact = _context.Dashboard
                .FirstOrDefault(i => i.FactHashTags.Contains(tagvalue));


            return await _context.Dashboard.Where(m => m.FactHashTags.Contains(tagvalue)).ToListAsync();

            //TODO: Uncomment when the database will be up and running
            //return Core.Instance.MessageService.GetDashBoardFacts(order).ToArray();

            //switch (order)
            //{
            //    case "byrating":
            //        return await _context.Dashboard.OrderByDescending(m => m.FactRating).ToListAsync();//asList.OrderByDescending(m => m.FactRating);

            //    case "latestrated":
            //        return await _context.Dashboard.OrderByDescending(m => m.FactLastRateDate).ToListAsync();

            //    case "latestadded":
            //        return await _context.Dashboard.OrderByDescending(m => m.FactCreateDate).ToListAsync();
            //    default:
            //        return await _context.Dashboard.OrderByDescending(m => m.FactRating).ToListAsync();
            //}

            //return await _context.Dashboard.ToListAsync();// FakeMessages.GetDashBoardFacts(order).ToList();
        }

        // GET: Search/Details/5
        public async Task<IActionResult> TagA(string tagName)
        {
            if (tagName == null)
            {
                return NotFound();
            }

            var matches = from m in _context.Dashboard
                          where m.FactHashTags.Contains(tagName)
                          select m;

            var eDashBoardFact = _context.Dashboard
                .FirstOrDefault(i => i.FactHashTags.Contains(tagName));

            if (eDashBoardFact == null)
            {
                return NotFound();
            }

            return View(eDashBoardFact);
        }

        // GET: Search
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Dashboard.ToListAsync());
        //}

        // GET: Search/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eDashBoardFact = await _context.Dashboard
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (eDashBoardFact == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(eDashBoardFact);
        //}

        //// GET: Search/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Search/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,FactId,FactRating,FactCreateDate,FactLastRateDate,FactTitle,FactLink,FactHashTags")] EDashBoardFact eDashBoardFact)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(eDashBoardFact);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(eDashBoardFact);
        //}

        //// GET: Search/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eDashBoardFact = await _context.Dashboard.FindAsync(id);
        //    if (eDashBoardFact == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(eDashBoardFact);
        //}

        //// POST: Search/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,FactId,FactRating,FactCreateDate,FactLastRateDate,FactTitle,FactLink,FactHashTags")] EDashBoardFact eDashBoardFact)
        //{
        //    if (id != eDashBoardFact.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(eDashBoardFact);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EDashBoardFactExists(eDashBoardFact.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(eDashBoardFact);
        //}

        //// GET: Search/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eDashBoardFact = await _context.Dashboard
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (eDashBoardFact == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(eDashBoardFact);
        //}

        //// POST: Search/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var eDashBoardFact = await _context.Dashboard.FindAsync(id);
        //    _context.Dashboard.Remove(eDashBoardFact);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EDashBoardFactExists(int id)
        //{
        //    return _context.Dashboard.Any(e => e.Id == id);
        //}
    }
}
