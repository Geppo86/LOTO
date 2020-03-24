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
    public class FacilitiesController : Controller
    {
        private readonly LOTOContext _context;

        public FacilitiesController(LOTOContext context)
        {
            _context = context;
        }

        // GET: Facilities
        public async Task<IActionResult> IndexFacilities()
        {
            return View(await _context.Facility.ToListAsync());
        }

        // GET: Facilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Facility = await _context.Facility
                .FirstOrDefaultAsync(m => m.FID == id);
            if (Facility == null)
            {
                return NotFound();
            }

            return View(Facility);
        }

        // GET: Facilities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Facilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FacilityName,FacilityLocation")] Facility Facility)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Facility);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexFacilities));
            }
            return View(Facility);
        }

        // GET: Facilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Facility = await _context.Facility.FindAsync(id);
            if (Facility == null)
            {
                return NotFound();
            }
            return View(Facility);
        }

        // POST: Facilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FacilityName,FacilityLocation")] Facility Facility)
        {
            if (id != Facility.FID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Facility);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacilityExists(Facility.FID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexFacilities));
            }
            return View(Facility);
        }

        // GET: Facilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Facility = await _context.Facility
                .FirstOrDefaultAsync(m => m.FID == id);
            if (Facility == null)
            {
                return NotFound();
            }

            return View(Facility);
        }

        // POST: Facilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Facility = await _context.Facility.FindAsync(id);
            _context.Facility.Remove(Facility);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexFacilities));
        }

        private bool FacilityExists(int id)
        {
            return _context.Facility.Any(e => e.FID == id);
        }
    }
}
