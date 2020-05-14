using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Data;
using Bookflix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookflix.Controllers
{
    public class NovedadesController : Controller
    {
        private BookflixContext _context = new BookflixContext();
        // GET: Novedad
        public ActionResult Index()
        {
            var novedades = new BookflixContext().Novedades.ToList();
            return View(novedades);
        }

        // GET: Novedad/Details/5
        public ActionResult Details(int id)
        {
            var nov = _context.Novedades.Find(id);
            if(nov is null)
            {
                return RedirectToAction(nameof(NotFoundResult));
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var nov = new Novedad();
                    nov.Titulo = collection["Titulo"];
                    nov.Descripcion = collection["Descripcion"];

                    _context.Novedades.Add(nov);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                return View();
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
                if(ModelState.IsValid)
                {
                    var nov = _context.Novedades.Find(id);
                    if (nov is null)
                    {
                        return RedirectToAction(nameof(NotFoundResult));
                    }

                    nov.Titulo = collection["Titulo"];
                    nov.Descripcion = collection["Descripcion"];

                    _context.Novedades.Update(nov);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Novedad/Delete/5
        public ActionResult Delete(int id)
        {
            var nov = _context.Novedades.Find(id);
            if (nov is null)
            {
                return RedirectToAction(nameof(NotFoundResult));
            }
            return View(nov);
        }

        // POST: Novedad/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var nov = _context.Novedades.Find(id);
                if(nov is null)
                {
                    return RedirectToAction(nameof(NotFoundResult));
                }

                _context.Novedades.Remove(nov);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}