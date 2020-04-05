using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LOTO.Data;
using LOTO.Models;

namespace LOTO.Controllers
{
    public class BuildingsController : Controller   
    {
        private readonly LOTOContext _context;

        public BuildingsController(LOTOContext context)
        {
            _context = context;
        }

        // GET: Buildings
        public async Task<IActionResult> IndexBuildings()
        {
            return View(await _context.Building.ToListAsync());
        }

        // GET: Buildings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Building = await _context.Building
                .FirstOrDefaultAsync(m => m.BID == id);
            if (Building == null)
            {
                return NotFound();
            }

            return View(Building);
        }

        // GET: Buildings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Buildings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BID,NameBuilding,Map,Coordinates")] Building Building)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Building);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexBuildings));
            }
            return View(Building);
        }

        // GET: Buildings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Building = await _context.Building.FindAsync(id);
            if (Building == null)
            {
                return NotFound();
            }
            return View(Building);
        }

        // POST: Buildings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NameBuilding,Map,Coordinates")] Building Building)
        {
            if (id != Building.BID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Building);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuildingExists(Building.BID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexBuildings));
            }
            return View(Building);
        }

        // GET: Buildings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Building = await _context.Building
                .FirstOrDefaultAsync(m => m.BID == id);
            if (Building == null)
            {
                return NotFound();
            }

            return View(Building);
        }

        // POST: Buildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Building = await _context.Building.FindAsync(id);
            _context.Building.Remove(Building);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBuildings));
        }

        private bool BuildingExists(int id)
        {
            return _context.Building.Any(e => e.BID == id);
        }
    }
}
