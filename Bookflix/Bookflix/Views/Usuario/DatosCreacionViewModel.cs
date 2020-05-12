using Bookflix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookflix.Views.Usuario
{
    public class DatosCreacionViewModel
    {
        public List<Categoria> Categorias { get; set; }
         public Subscriptor Subscriptor { get; set; }
    }
}
