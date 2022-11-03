using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCConcesionaria.Context;
using MVCConcesionaria.Models;

namespace MVCConcesionaria.Controllers
{
    public class CamionetaController : Controller
    {
        private readonly ConcesionariaDatabaseContext _context;

        public CamionetaController(ConcesionariaDatabaseContext context)
        {
            _context = context;
        }

        // GET: Camioneta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Camionetas.ToListAsync());
        }

        // GET: Camioneta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camioneta = await _context.Camionetas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (camioneta == null)
            {
                return NotFound();
            }

            return View(camioneta);
        }

        // GET: Camioneta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Camioneta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Es4x4,EsDobleCabina,ID,Marca,Modelo,EsUsado,CantKm")] Camioneta camioneta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camioneta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(camioneta);
        }

        // GET: Camioneta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camioneta = await _context.Camionetas.FindAsync(id);
            if (camioneta == null)
            {
                return NotFound();
            }
            return View(camioneta);
        }

        // POST: Camioneta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Es4x4,EsDobleCabina,ID,Marca,Modelo,EsUsado,CantKm")] Camioneta camioneta)
        {
            if (id != camioneta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camioneta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamionetaExists(camioneta.ID))
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
            return View(camioneta);
        }

        // GET: Camioneta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camioneta = await _context.Camionetas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (camioneta == null)
            {
                return NotFound();
            }

            return View(camioneta);
        }

        // POST: Camioneta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var camioneta = await _context.Camionetas.FindAsync(id);
            _context.Camionetas.Remove(camioneta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamionetaExists(int id)
        {
            return _context.Camionetas.Any(e => e.ID == id);
        }
    }
}
