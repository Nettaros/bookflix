using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Models
{
    public abstract class Cuenta
    {
        [Key]
        [Column(Order = 1)]
        public String Email { get; set; }
        [Required]
        public String Contraseña { get; set; }

    }
}
