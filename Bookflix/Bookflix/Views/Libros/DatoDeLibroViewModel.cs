using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookflix.Views.Libros
{
    public class DatoDeLibroViewModel
    {

        [Required(ErrorMessage = "Genero Requerido")]
        public String Genero { get; set; }
        public SelectList Generos { get; set; }

        [Required(ErrorMessage = "Autor Requerido")]
        public String Autor { get; set; }

        public SelectList Autores { get; set; }

        [Required(ErrorMessage = "Editorial Requerida")]
        public String Editorial { get; set; }
        public SelectList Editoriales { get; set; }
        public Libro Libro { get; set; }
    }
}
