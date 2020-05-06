using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public class Subscriptor : Cuenta
    {
        [Required]
        public String NombreCompleto { get; set; }
        [Required]
        public String Dni { get; set; }
        [Required]
        public Tarjeta Tarjeta { get; set; }

        public Categoria Categoria { get; set; }
#nullable enable
        public List<Perfil>? Perfiles { get; set; }

       
#nullable disable
    }
}
