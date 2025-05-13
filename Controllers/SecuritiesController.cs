using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AllForOne_Store.Data;
using AllForOne_Store.Models;

namespace AllForOne_Store.Controllers
{
    public class SecuritiesController : Controller
    {
        private readonly AppDbContext _context;

        public SecuritiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Securities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Securities.ToListAsync());
        }

        // GET: Securities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var security = await _context.Securities
                .FirstOrDefaultAsync(m => m.SecurityId == id);
            if (security == null)
            {
                return NotFound();
            }

            return View(security);
        }

        // GET: Securities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Securities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SecurityId,Action,ActionDate")] Security security)
        {
            if (ModelState.IsValid)
            {
                _context.Add(security);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(security);
        }

        // GET: Securities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var security = await _context.Securities.FindAsync(id);
            if (security == null)
            {
                return NotFound();
            }
            return View(security);
        }

        // POST: Securities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SecurityId,Action,ActionDate")] Security security)
        {
            if (id != security.SecurityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(security);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecurityExists(security.SecurityId))
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
            return View(security);
        }

        // GET: Securities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var security = await _context.Securities
                .FirstOrDefaultAsync(m => m.SecurityId == id);
            if (security == null)
            {
                return NotFound();
            }

            return View(security);
        }

        // POST: Securities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var security = await _context.Securities.FindAsync(id);
            if (security != null)
            {
                _context.Securities.Remove(security);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecurityExists(int id)
        {
            return _context.Securities.Any(e => e.SecurityId == id);
        }
    }
}
