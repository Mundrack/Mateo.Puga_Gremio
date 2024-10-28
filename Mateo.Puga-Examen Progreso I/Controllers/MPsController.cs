using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mateo.Puga_Examen_Progreso_I.Data;
using Mateo.Puga_Examen_Progreso_I.Models;

namespace Mateo.Puga_Examen_Progreso_I.Controllers
{
    public class MPsController : Controller
    {
        private readonly MateoPuga_Examen_Progreso_IContext _context;

        public MPsController(MateoPuga_Examen_Progreso_IContext context)
        {
            _context = context;
        }

        // GET: MPs
        public async Task<IActionResult> Index()
        {
            return View(await _context.MP.ToListAsync());
        }

        // GET: MPs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mP = await _context.MP
                .FirstOrDefaultAsync(m => m.MPID == id);
            if (mP == null)
            {
                return NotFound();
            }

            return View(mP);
        }

        // GET: MPs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MPID,MPNameLibro,MPDescription,MPFechaPublicacion,MPFechaRegistro")] MP mP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mP);
        }

        // GET: MPs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mP = await _context.MP.FindAsync(id);
            if (mP == null)
            {
                return NotFound();
            }
            return View(mP);
        }

        // POST: MPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MPID,MPNameLibro,MPDescription,MPFechaPublicacion,MPFechaRegistro")] MP mP)
        {
            if (id != mP.MPID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MPExists(mP.MPID))
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
            return View(mP);
        }

        // GET: MPs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mP = await _context.MP
                .FirstOrDefaultAsync(m => m.MPID == id);
            if (mP == null)
            {
                return NotFound();
            }

            return View(mP);
        }

        // POST: MPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mP = await _context.MP.FindAsync(id);
            if (mP != null)
            {
                _context.MP.Remove(mP);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MPExists(int id)
        {
            return _context.MP.Any(e => e.MPID == id);
        }
    }
}
