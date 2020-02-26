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
    public class MachineZonesController : Controller
    {
        private readonly LOTOContext _context;

        public MachineZonesController(LOTOContext context)
        {
            _context = context;
        }

        // GET: MachineZones
        public async Task<IActionResult> IndexMachineZones()
        {
            return View(await _context.MachineZone.ToListAsync());
        }

        // GET: MachineZones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var machineZone = await _context.MachineZone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (machineZone == null)
            {
                return NotFound();
            }

            return View(machineZone);
        }

        // GET: MachineZones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MachineZones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Zone,ZoneMapFile,HatchingFile")] MachineZone machineZone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(machineZone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexMachineZones));
            }
            return View(machineZone);
        }

        // GET: MachineZones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var machineZone = await _context.MachineZone.FindAsync(id);
            if (machineZone == null)
            {
                return NotFound();
            }
            return View(machineZone);
        }

        // POST: MachineZones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Zone,ZoneMapFile,HatchingFile")] MachineZone machineZone)
        {
            if (id != machineZone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(machineZone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MachineZoneExists(machineZone.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexMachineZones));
            }
            return View(machineZone);
        }

        // GET: MachineZones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var machineZone = await _context.MachineZone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (machineZone == null)
            {
                return NotFound();
            }

            return View(machineZone);
        }

        // POST: MachineZones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var machineZone = await _context.MachineZone.FindAsync(id);
            _context.MachineZone.Remove(machineZone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexMachineZones));
        }

        private bool MachineZoneExists(int id)
        {
            return _context.MachineZone.Any(e => e.Id == id);
        }
    }
}
