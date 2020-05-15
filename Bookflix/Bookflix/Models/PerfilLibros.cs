using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public class PerfilLibros
    {
        public int Id { get; set; }
        public int LibroISBN { get; set; }
        public Libro Libro { get; set; }


        
        public Perfil Perfil { get; set; }
        public String PerfilId { get; set; }

    }
}
