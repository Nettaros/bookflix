using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Bookflix.Models
{
    public abstract class Cuenta
    {
        [Key]
        [Column(Order = 1)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un Email valido")]
        [Required(ErrorMessage = "Email requerido")]
        [DisplayName("Correo electronico")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Constraseña requerida")]
        [MinLength(8, ErrorMessage = "La longitud maxima de la contraseña es 8 caracteres")]
        [RegularExpression(@"^[A-Z0-9a-z""']*$",ErrorMessage ="La contraseña no debe contener simbolos")]
        [DataType(DataType.Password)]
        [DisplayName("Contraseña")]
        public String Contraseña { get; set; }
    }
}
