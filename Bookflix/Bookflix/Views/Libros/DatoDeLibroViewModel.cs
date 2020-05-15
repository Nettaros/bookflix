using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookflix.Views.Libros
{
    public class DatoDeLibroViewModel
    {
        public IEnumerable<Genero> Generos { get; set; }
        public IEnumerable<Autor> Autores { get; set; }
        public IEnumerable<Editorial> Editoriales { get; set; }
        public Libro Libro { get; set; }
    }
}
