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
    public class TasksController : Controller
    {
        private readonly LOTOContext _context;

        public TasksController(LOTOContext context)
        {
            _context = context;
        }

        // GET: Tasks
        public async Task<IActionResult> IndexTasks()
        {
            return View(await _context.Task.ToListAsync());
        }

        // GET: Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Task = await _context.Task
                .FirstOrDefaultAsync(m => m.TID == id);
            if (Task == null)
            {
                return NotFound();
            }

            return View(Task);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TaskName")] Models.Task Task)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexTasks));
            }
            return View(Task);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Task = await _context.Task.FindAsync(id);
            if (Task == null)
            {
                return NotFound();
            }
            return View(Task);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TaskName")] Models.Task Task)
        {
            if (id != Task.TID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Task);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskExists(Task.TID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexTasks));
            }
            return View(Task);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Task = await _context.Task
                .FirstOrDefaultAsync(m => m.TID == id);
            if (Task == null)
            {
                return NotFound();
            }

            return View(Task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Task = await _context.Task.FindAsync(id);
            _context.Task.Remove(Task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexTasks));
        }

        private bool TaskExists(int id)
        {
            return _context.Task.Any(e => e.TID == id);
        }
    }
}
