using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookflix.Models
{
    public class Categoria
    {
        [Key]
        public String Nombre { get; set; }
        public int MaxPerfiles { get; set; }
        public List<Subscriptor> Subscriptores { get; set; }

    }
}
