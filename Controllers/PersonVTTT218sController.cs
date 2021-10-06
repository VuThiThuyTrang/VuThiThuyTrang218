using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuThiThuyTrang218.Models;

namespace VuThiThuyTrang218.Controllers
{
    public class PersonVTTT218sController : Controller
    {
        private readonly ApplicationContext _context;

        public PersonVTTT218sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonVTTT218s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonVTTT218.ToListAsync());
        }

        // GET: PersonVTTT218s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personVTTT218 = await _context.PersonVTTT218
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personVTTT218 == null)
            {
                return NotFound();
            }

            return View(personVTTT218);
        }

        // GET: PersonVTTT218s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonVTTT218s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonVTTT218 personVTTT218)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personVTTT218);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personVTTT218);
        }

        // GET: PersonVTTT218s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personVTTT218 = await _context.PersonVTTT218.FindAsync(id);
            if (personVTTT218 == null)
            {
                return NotFound();
            }
            return View(personVTTT218);
        }

        // POST: PersonVTTT218s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,PersonName")] PersonVTTT218 personVTTT218)
        {
            if (id != personVTTT218.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personVTTT218);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonVTTT218Exists(personVTTT218.PersonId))
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
            return View(personVTTT218);
        }

        // GET: PersonVTTT218s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personVTTT218 = await _context.PersonVTTT218
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personVTTT218 == null)
            {
                return NotFound();
            }

            return View(personVTTT218);
        }

        // POST: PersonVTTT218s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personVTTT218 = await _context.PersonVTTT218.FindAsync(id);
            _context.PersonVTTT218.Remove(personVTTT218);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonVTTT218Exists(int id)
        {
            return _context.PersonVTTT218.Any(e => e.PersonId == id);
        }
    }
}
