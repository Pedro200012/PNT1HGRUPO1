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
    public class MotoController : Controller
    {
        private readonly ConcesionariaDatabaseContext _context;

        public MotoController(ConcesionariaDatabaseContext context)
        {
            _context = context;
        }

        // GET: Moto
        public async Task<IActionResult> Index()
        {
            return View(await _context.Motos.ToListAsync());
        }

        // GET: Moto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moto = await _context.Motos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (moto == null)
            {
                return NotFound();
            }

            return View(moto);
        }

        // GET: Moto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Moto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tipo,ID,Marca,Modelo,EsUsado,CantKm")] Moto moto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moto);
        }

        // GET: Moto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moto = await _context.Motos.FindAsync(id);
            if (moto == null)
            {
                return NotFound();
            }
            return View(moto);
        }

        // POST: Moto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Tipo,ID,Marca,Modelo,EsUsado,CantKm")] Moto moto)
        {
            if (id != moto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotoExists(moto.ID))
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
            return View(moto);
        }

        // GET: Moto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moto = await _context.Motos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (moto == null)
            {
                return NotFound();
            }

            return View(moto);
        }

        // POST: Moto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moto = await _context.Motos.FindAsync(id);
            _context.Motos.Remove(moto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotoExists(int id)
        {
            return _context.Motos.Any(e => e.ID == id);
        }
    }
}
