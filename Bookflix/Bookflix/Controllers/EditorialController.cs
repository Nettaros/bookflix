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
    public class EditorialController : Controller
    {
        private BookflixContext _context = new BookflixContext();
        // GET: Editorial
        public ActionResult Index()
        {
            return View();
        }

        // GET: Editorial/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Editorial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Editorial/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Nombre")] Editorial editorial)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(editorial);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (DbUpdateException /* ex */)
            {
                ModelState.AddModelError("", "No se pudieron realizar los cambios. " +
                    "Intentelo de nuevo, y si el problema persiste " +
                    "llama a tu administrador del sistema.");
            }
            return View();
        }

        // GET: Editorial/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Editorial/Edit/5
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

        // GET: Editorial/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Editorial/Delete/5
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