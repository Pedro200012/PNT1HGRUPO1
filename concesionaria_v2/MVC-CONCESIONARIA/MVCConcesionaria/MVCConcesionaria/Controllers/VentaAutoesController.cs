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
    public class VentaAutoesController : Controller
    {
        private readonly ConcesionariaDatabaseContext _context;

        public VentaAutoesController(ConcesionariaDatabaseContext context)
        {
            _context = context;
        }

        // GET: VentaAutoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VentaAuto.ToListAsync());
        }

        // GET: VentaAutoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VentaAutoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVentAuto,IdCliente,Id")] VentaAuto ventaAuto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ventaAuto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ventaAuto);
        }

        
        private bool VentaAutoExists(int id)
        {
            return _context.VentaAuto.Any(e => e.IdVentAuto == id);
        }
    }
}
