using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Bookflix.Models
{
    public class Subscriptor : Cuenta
    {
        [Required (ErrorMessage = "Nombre completo requerido")]
        [DataType(DataType.Text)]
        public String NombreCompleto { get; set; }
        
        [Required(ErrorMessage = "DNI requerido")]
        public String Dni { get; set; }
        
        [Required]
        public Tarjeta Tarjeta { get; set; }

        public Categoria Categoria { get; set; }

        public List<Perfil> Perfiles { get; set; }

    }
}
