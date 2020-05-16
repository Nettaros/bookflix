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
        DatoDeLibroViewModel vm;
        public LibrosController()
        {
            vm = new DatoDeLibroViewModel();
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
            var libros = _context.Libros.Include(l => l.Genero).Include(l => l.Autor).Include(l => l.Editorial).ToList();
            return View(libros);
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            vm = CargarVM(new Libro());
            return View(vm);
        }

        

        // POST: Libros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DatoDeLibroViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var gen = _context.Generos.SingleOrDefault(g => g.Nombre == model.Genero);
                    var aut = _context.Autores.SingleOrDefault(g => g.Nombre == model.Autor);
                    var edi = _context.Editoriales.SingleOrDefault(g => g.Nombre == model.Editorial);
                    gen.AgregarOCrear(model.Libro);
                    aut.AgregarOCrear(model.Libro);
                    edi.AgregarOCrear(model.Libro);
                    _context.SaveChanges();
                    
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
            vm = CargarVM(model.Libro);
            return View(vm);
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

        private DatoDeLibroViewModel CargarVM(Libro libro)
        {
            IEnumerable<Genero> gen = _context.Generos.ToList();
            IEnumerable<Autor> aut = _context.Autores.ToList();
            IEnumerable<Editorial> edi = _context.Editoriales.ToList();
            vm.Generos = new SelectList(gen, "Nombre", "Nombre");
            vm.Autores = new SelectList(aut, "Nombre", "Nombre");
            vm.Editoriales = new SelectList(edi, "Nombre", "Nombre");
            vm.Libro = libro;
            return vm;
        }
    }
}