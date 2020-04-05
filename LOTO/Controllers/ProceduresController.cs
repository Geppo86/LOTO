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
    public class ProceduresController : Controller
    {
        private readonly LOTOContext _context;

        public ProceduresController(LOTOContext context)
        {
            _context = context;
        }

        // GET: Procedures
        public async Task<IActionResult> IndexProcedures()
        {
            return View(await _context.Procedure.ToListAsync());
        }

        // GET: Procedures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Procedure = await _context.Procedure
                .FirstOrDefaultAsync(m => m.PID == id);
            if (Procedure == null)
            {
                return NotFound();
            }

            return View(Procedure);
        }

        // GET: Procedures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Procedures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PID,Name,step")] Procedure Procedure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Procedure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexProcedures));
            }
            return View(Procedure);
        }

        // GET: Procedures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Procedure = await _context.Procedure.FindAsync(id);
            if (Procedure == null)
            {
                return NotFound();
            }
            return View(Procedure);
        }

        // POST: Procedures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PID,Name,step")] Procedure Procedure)
        {
            if (id != Procedure.PID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Procedure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcedureExists(Procedure.PID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexProcedures));
            }
            return View(Procedure);
        }

        // GET: Procedures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Procedure = await _context.Procedure
                .FirstOrDefaultAsync(m => m.PID == id);
            if (Procedure == null)
            {
                return NotFound();
            }

            return View(Procedure);
        }

        // POST: Procedures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Procedure = await _context.Procedure.FindAsync(id);
            _context.Procedure.Remove(Procedure);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexProcedures));
        }

        private bool ProcedureExists(int id)
        {
            return _context.Procedure.Any(e => e.PID == id);
        }
    }
}
