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
    public class VentaMotoesController : Controller
    {
        private readonly ConcesionariaDatabaseContext _context;

        public VentaMotoesController(ConcesionariaDatabaseContext context)
        {
            _context = context;
        }

        // GET: VentaMotoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VentaMoto.ToListAsync());
        }

        // GET: VentaMotoes/Details/

        // GET: VentaMotoes/Create
        public IActionResult Create()
        {
           
            return View();
        }

        // POST: VentaMotoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVentaMoto,IdCliente,Id")] VentaMoto ventaMoto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ventaMoto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ventaMoto);
        }

        private bool VentaMotoExists(int id)
        {
            return _context.VentaMoto.Any(e => e.IdVentaMoto == id);
        }
    }
}
