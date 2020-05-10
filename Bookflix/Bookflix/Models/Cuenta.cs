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
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email requerido")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Constraseña requerida")]
        [MinLength(8, ErrorMessage = "La longitud maxima de la contraseña es 8 caracteres")]
        [RegularExpression(@"^[A-Z0-9a-z""']*$")]
        [DataType(DataType.Password)]
        public String Contraseña { get; set; }

    }
}
