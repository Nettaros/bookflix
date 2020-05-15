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
                Subscriptor = new Subscriptor()
            };
            return View(CreacionViewModel);
        }


        private Subscriptor cargarDatosSubscriptor(IFormCollection collection) {
            var sus = new Subscriptor();
            var tar = new Tarjeta();
            string nombre;
            sus.Contraseña = collection["Subscriptor.Contraseña"];
            sus.Email = collection["Subscriptor.Email"];
            sus.NombreCompleto = collection["Subscriptor.NombreCompleto"];
            tar.Dni = collection["Subscriptor.Tarjeta.Dni"];
            tar.Numero = collection["Subscriptor.Tarjeta.Numero"];
            tar.FechaVencimiento = DateTime.Parse(collection["Subscriptor.Tarjeta.FechaVencimiento"]);
            tar.CodigoSeguridad = int.Parse(collection["Subscriptor.Tarjeta.CodigoSeguridad"]);
            sus.Tarjeta = tar;
            var checkbox = collection["quieroSerPremium"];
            if (checkbox.First().Equals("true"))
            {
                nombre = "premium";
            }
            else {
                nombre = "comun";
            }
            sus.Categoria = _context.Categorias.Find(nombre);
            return sus;

        }
        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
             [Bind("Subscriptor.Contraseña,Subscriptor.Email,Subscriptor.NombreCompleto,Subscriptor.Tarjeta.Dni,Subsciptor.Tarjeta.Numero,Subsciptor.Tarjeta.CodigoSeguridad,Subscriptor.Categoria")] Subscriptor sus)
        {

            try
            {
                /*var sus = cargarDatosSubscriptor(collection);
                string email = sus.Email; string dni = sus.Tarjeta.Dni;
                var emailExistente = _context.Subscriptores.Find(email);
                if (emailExistente is null)
                {
                    List<Subscriptor> susList = _context.Subscriptores.ToList();
                    Boolean encontro = false;
                    foreach (Subscriptor suscr in susList)
                        if (suscr.Tarjeta.Dni.Equals(dni))
                        {
                            encontro = true;
                        }
                    if (!encontro)
                    {
                        _context.Subscriptores.Add(sus);
                        _context.SaveChanges();
                        Session.UserLogged = sus;
                        return View("Inicio"); /*Falta implentar el inicio*/

                /*  }
                 else {
                /* Encontro una tarjeta con el mismo dueño */
                /*  return RedirectToAction(nameof(Index));
                       }
                   }
                   else {
                       /*Encontro el mail en otro lado */

                /*return RedirectToAction(nameof(Index));

             } */
                if (ModelState.IsValid) {
                    _context.Add(sus);
                    await _context.SaveChangesAsync();
                    Session.UserLogged = sus;
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "No se pudieron realizar los cambios. "+ 
                    "Intentalo de nuevo, y si el problema persiste "+ 
                    "llama a tu administrador de sistema");
            }
            return View(sus);
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