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
    public class AutorController : Controller
    {
        private BookflixContext _context = new BookflixContext();
        // GET: Autor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Autor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Nombre")] Autor autor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(autor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "No se pudieron realizar los cambios. " +
                    "Intentelo de nuevo, y si el problema persiste " +
                    "llama a tu administrador del sistema.");
            }
            return View(autor);
        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Autor/Edit/5
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

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autor/Delete/5
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