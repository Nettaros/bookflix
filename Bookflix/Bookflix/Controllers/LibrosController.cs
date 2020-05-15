using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Bookflix.Data;
using Bookflix.Models;
using Bookflix.Views.Libros;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Bookflix.Controllers
{
    public class LibrosController : Controller
    {
        BookflixContext _context;
        public LibrosController()
        {
            _context = new BookflixContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Libros
        public ActionResult Index()
        {
            return View();
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            var vm = new DatoDeLibroViewModel();
            vm.Generos = _context.Generos.ToList();
            vm.Autores = _context.Autores.ToList();
            vm.Editoriales = _context.Editoriales.ToList();
            vm.Libro = new Libro();
            return View(vm);
        }

        

        // POST: Libros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("ISBN,Titulo,FechaPublicacion,Sinopsis")] Libro libro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(libro);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "No se pudieron realizar los cambios. " +
                    "Intenta nuevamente, y si el problema persiste " +
                    "habla con el administrador del sistema.");
            }
            return View(libro);
        }

        // GET: Libros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Libros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Libros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libros/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}