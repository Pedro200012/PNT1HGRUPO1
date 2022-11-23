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
    public class VentaCamionetasController : Controller
    {
        private readonly ConcesionariaDatabaseContext _context;

        public VentaCamionetasController(ConcesionariaDatabaseContext context)
        {
            _context = context;
        }

        // GET: VentaCamionetas
        public async Task<IActionResult> Index()
        {
            return View(await _context.VentaCamioneta.ToListAsync());
        }

        
        // GET: VentaCamionetas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VentaCamionetas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVentaCamioneta,IdCliente,Id")] VentaCamioneta ventaCamioneta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ventaCamioneta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ventaCamioneta);
        }

     
        private bool VentaCamionetaExists(int id)
        {
            return _context.VentaCamioneta.Any(e => e.IdVentaCamioneta == id);
        }
    }
}
