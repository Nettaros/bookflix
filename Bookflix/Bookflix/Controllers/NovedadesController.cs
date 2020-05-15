using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Data;
using Bookflix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookflix.Controllers
{
    public class NovedadesController : Controller
    {
        private BookflixContext _context;
        public NovedadesController()
        {
            _context = new BookflixContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult MostrarNovedades()
        {
            return View(_context.Novedades.ToList());
        }

        // GET: Novedad
        public ActionResult Index()
        {
            var novedades = _context.Novedades.ToList();
            return View(novedades);
        }

        // GET: Novedad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nov = await _context.Novedades.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

            if (nov == null)
            {
                return NotFound();
            }

            return View(nov);
        }

          


        // GET: Novedad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novedad/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( 
            [Bind("Titulo,Descripcion,FechaOcultacion")] Novedad novedad)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _context.Add(novedad);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch (DbUpdateException ex )
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "No se pudieron realizar los cambios. " +
                    "Intenta nuevamente, y si el problema persiste " +
                    "habla con el administrador del sistema.");
            }
            return View(novedad);
        }

        // GET: Novedad/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var nov = await _context.Novedades.FirstOrDefaultAsync(s => s.Id == id);
            return View(nov);
        }

        // POST: Novedad/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var nuevaNovedad = await _context.Novedades.FirstOrDefaultAsync(s => s.Id == id);
            if (await TryUpdateModelAsync<Novedad>(nuevaNovedad, "",
                s => s.Titulo, s => s.Descripcion, s => s.FechaOcultacion))
            {
                try
                {   
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex )
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Imposible realizar cambios. " +
                        "Intentalo Nuevamente, y si el problema persiste, " +
                        "habla con el administrador del sistema.");
                }
            }
            return View(nuevaNovedad);
        }

        // GET: Novedad/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novedad = await _context.Novedades
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (novedad == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Borrado fallido. Intentalo Nuevamente, y si el problema persiste , habla con el administrador del sistema.";
            }

            return View(novedad);
        }

        // POST: Novedad/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var novedad = await _context.Novedades.FindAsync(id);
            if (novedad == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.Novedades.Remove(novedad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException  ex )
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }
    }
}