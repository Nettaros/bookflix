using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models
{
    public abstract class DatoDeLibro
    {
        [Key]
        public String Nombre { get; set; }
#nullable enable
        public List<Libro>? Libros { get; set; }
#nullable disable

    }
}
