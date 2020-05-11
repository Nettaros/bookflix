using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Data;
using Bookflix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Bookflix.Views.Usuario
{

    public class UsuarioController : Controller
    {
        private BookflixContext _context = new BookflixContext();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(IFormCollection collection)
        {
           
            try
            {
                var sus = new Subscriptor();
                var tar = new Tarjeta();
                sus.Contraseña = collection["Contraseña"];
                sus.Email = collection["Email"];
                sus.NombreCompleto = collection["NombreCompleto"];
                sus.Dni = collection["Dni"];
                tar.Numero = collection["Tarjeta.Numero"];
                tar.FechaVencimiento = DateTime.Parse(collection["Tarjeta.FechaVencimiento"]);
                tar.CodigoSeguridad = int.Parse(collection["Tarjeta.CodigoSeguridad"]);
                sus.Tarjeta= tar;
                _context.Subscriptores.Add(sus);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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