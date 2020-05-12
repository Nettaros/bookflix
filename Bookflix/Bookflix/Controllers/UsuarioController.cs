using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Data;
using Bookflix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

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
        public ActionResult Create()
        {
            var CreacionViewModel = new DatosCreacionViewModel()
            {
                Categorias = _context.Categorias.ToList(),
                Subscriptor = new Subscriptor()
            };
            return View(CreacionViewModel);
         }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {

            try
            {

                var sus = new Subscriptor();
                var tar = new Tarjeta();
                sus.Contraseña = collection["Contraseña"];
                sus.Email = collection["Email"];
                sus.NombreCompleto = collection["NombreCompleto"];
                tar.Dni = collection["Tarjeta.Dni"];
                tar.Numero = collection["Tarjeta.Numero"];
                tar.FechaVencimiento = DateTime.Parse(collection["Tarjeta.FechaVencimiento"]);
                tar.CodigoSeguridad = int.Parse(collection["Tarjeta.CodigoSeguridad"]);
                sus.Tarjeta = tar;
                var emailExistente = _context.Subscriptores.Find(collection["Email"]);
                if (emailExistente is null)
                {
                    List<Subscriptor> susList = _context.Subscriptores.ToList();
                    Boolean encontro = false;
                    foreach (Subscriptor suscr in susList)
                        if (suscr.Tarjeta.Dni.Equals(collection["Tarjeta.Dni"]))
                        {
                            encontro = true;
                        }
                    if (!encontro)
                    {
                        _context.Subscriptores.Add(sus);
                        _context.SaveChanges();
                        Session.UserLogged = sus;
                        return View("Inicio"); /*Falta implentar el inicio*/

                    }
                    else {
                        /* Encontro una tarjeta con el mismo dueño */
                        return RedirectToAction(nameof(Index));
                    }
                }
                else {
                    /*Encontro el mail en otro lado */

                    return RedirectToAction(nameof(Index));

                }

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