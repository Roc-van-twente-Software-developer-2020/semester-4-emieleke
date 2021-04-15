using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using chapter12.Data;
using chapter12.Models;

namespace chapter12.Controllers
{
    public class AtleetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AtleetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Atleet
        public async Task<IActionResult> Index()
        {
            var atleten = await _context.Atleet.ToListAsync();
            if(atleten.Count == 0)
            {
                ViewBag.Melding = "Er zijn geen atleten gevonden";
            }
            return View(atleten);
        }

        // GET: Atleet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atleet = await _context.Atleet
                .FirstOrDefaultAsync(m => m.ID == id);
            if (atleet == null)
            {
                return NotFound();
            }

            return View(atleet);
        }

        // GET: Atleet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atleet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Naam,Geboortedatum,Nationaliteit")] Atleet atleet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atleet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atleet);
        }

        // GET: Atleet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atleet = await _context.Atleet.FindAsync(id);
            if (atleet == null)
            {
                return NotFound();
            }
            return View(atleet);
        }

        // POST: Atleet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Naam,Geboortedatum,Nationaliteit")] Atleet atleet)
        {
            if (id != atleet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atleet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtleetExists(atleet.ID))
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
            return View(atleet);
        }

        // GET: Atleet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atleet = await _context.Atleet
                .FirstOrDefaultAsync(m => m.ID == id);
            if (atleet == null)
            {
                return NotFound();
            }

            return View(atleet);
        }

        // POST: Atleet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var atleet = await _context.Atleet.FindAsync(id);
            _context.Atleet.Remove(atleet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtleetExists(int id)
        {
            return _context.Atleet.Any(e => e.ID == id);
        }
    }
}
