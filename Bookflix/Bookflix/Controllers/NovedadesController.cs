using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookflix.Controllers
{
    public class NovedadesController : Controller
    {
        // GET: Novedad
        public ActionResult Index()
        {
            var novedades = new BookflixContext().Novedades.ToList();
            return View(novedades);
        }

        // GET: Novedad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Novedad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novedad/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Novedad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Novedad/Edit/5
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

        // GET: Novedad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Novedad/Delete/5
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